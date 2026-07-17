using OfficeOpenXml;

public class ExcelService
{
    private readonly YandexApiService _coordinateService;

    public ExcelService(YandexApiService coordinateService)
    {
        _coordinateService = coordinateService;
    }

    public List<ExcelInputModel> ReadExcel(string excelPath)
    {
        using ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelPath));
        var workSheet = excelPackage.Workbook.Worksheets;

        return (from s in workSheet.FirstOrDefault().ConvertSheetToObjects<ExcelInputModel>()
                where s.Address != null
                select s).ToList();
    }

    public async Task WriteExcel(string InputExcelPath, string OutputExcelPath, string yandexApiKey)
    {
        using ExcelPackage package = new ExcelPackage();
        string extension1 = Path.GetExtension(InputExcelPath);
        string extension2 = Path.GetExtension(OutputExcelPath);
        if (extension1 != ".xlsx" && extension1 != ".xls")
        {
            throw new Exception("Provided input file's type is not .xlsx or .xls");
        }
        if (extension2 != ".xlsx" && extension2 != ".xls")
        {
            throw new Exception("Provided output file's type is not .xlsx or .xls");
        }
        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("ExchangeRate");
        worksheet.Cells[1, 1].Value = "Address";
        worksheet.Cells[1, 2].Value = "Latitude";
        worksheet.Cells[1, 3].Value = "Longitude";
        List<ExcelInputModel> PlaceAddressExcel = ReadExcel(InputExcelPath);
        List<string> list = new List<string>();
        foreach (ExcelInputModel item2 in PlaceAddressExcel)
        {
            list.Add(item2.Address);
        }
        using FileStream stream = File.Create(OutputExcelPath);
        (List<LatLongModel>, bool) tuple = await _coordinateService.GetCoordinatesAsync(list, yandexApiKey);
        List<LatLongModel> item = tuple.Item1;
        for (int i = 0; i < item.Count; i++)
        {
            worksheet.Cells[$"A{i + 2}"].Value = PlaceAddressExcel[i].Address;
            worksheet.Cells[$"B{i + 2}"].Value = item[i].Latitude;
            worksheet.Cells[$"C{i + 2}"].Value = item[i].Longitude;
        }
        package.SaveAs(stream);
        stream.Close();
        if (tuple.Item2)
        {
            throw new Exception("Unexpected error, not all records are written");
        }
    }
}
