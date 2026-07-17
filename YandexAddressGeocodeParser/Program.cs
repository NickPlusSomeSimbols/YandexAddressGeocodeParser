using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using System.Windows.Forms;
using YandexConfertor_5;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ExcelPackage.License.SetNonCommercialPersonal("John Doe");
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(defaultValue: false);
        Form1 mainForm = new Form1();

        mainForm.ButtonClick += async delegate
        {
            await HandleButtonClick(mainForm);
        };
        Application.Run(mainForm);
    }

    private static async Task HandleButtonClick(Form1 mainForm)
    {
        try
        {
            string inputExcelPath = mainForm.InputExcelPath;
            string outputExcelPath = mainForm.OutputExcelPath;
            string yandexApiKey = mainForm.YandexApiKey;
            using IHost host = CreateHostBuilder().Build();
            using IServiceScope serviceScope = host.Services.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;
            ExcelService requiredService = serviceProvider.GetRequiredService<ExcelService>();
            serviceProvider.GetRequiredService<YandexApiService>();
            await requiredService.WriteExcel(inputExcelPath, outputExcelPath, yandexApiKey);
            mainForm.AppendToRichTextBox("Program executed successfully.");
        }
        catch (Exception ex)
        {
            mainForm.AppendToRichTextBox("! " + ex.Message);
        }
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder().ConfigureServices(delegate (IServiceCollection services)
        {
            services.AddScoped<ExcelService>();
            services.AddScoped<YandexApiService>();
        });
    }
}
