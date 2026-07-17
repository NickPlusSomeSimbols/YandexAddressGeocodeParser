// YandexExcelConvertor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// RepetitionInfrastructure.Services.YandexApiService
using Yandex.Geocoder;
using Yandex.Geocoder.Models;

public class YandexApiService
{
    public async Task<(List<LatLongModel>, bool)> GetCoordinatesAsync(List<string> streets, string apiKey)
    {
        List<LatLongModel> coordinates = new List<LatLongModel>();
        GeocoderClient geocoderClient = new GeocoderClient(apiKey);
        try
        {
            foreach (string street in streets)
            {
                if (street == "Address")
                {
                    continue;
                }
                GeocoderRequest geocoderRequest = new GeocoderRequest
                {
                    Request = street
                };
                GeocoderResponseType response = null;
                try
                {
                    response = await geocoderClient.Geocode(geocoderRequest);
                }
                catch (Exception)
                {
                    LatLongModel item = new LatLongModel
                    {
                        Latitude = "unable to",
                        Longitude = "set"
                    };

                    coordinates.Add(item);
                    continue;
                }

                if (response == null)
                {
                    if (response.GeoObjectCollection.FeatureMember.Count == 0)
                    {
                        LatLongModel item = new LatLongModel
                        {
                            Latitude = "no",
                            Longitude = "coordinates"
                        };
                        coordinates.Add(item);
                        continue;
                    }
                }

                try
                {
                    string[] arrayTry = response.GeoObjectCollection.FeatureMember.FirstOrDefault().GeoObject.Point.Pos.Split(' ');
                }
                catch (Exception ex)
                {
                    LatLongModel item = new LatLongModel
                    {
                        Latitude = "Unexpected",
                        Longitude = "error"
                    };
                    coordinates.Add(item);
                    continue;
                }

                string[] array = response.GeoObjectCollection.FeatureMember.FirstOrDefault().GeoObject.Point.Pos.Split(' ');

                LatLongModel item2 = new LatLongModel
                {
                    Latitude = array[1],
                    Longitude = array[0]
                };
                coordinates.Add(item2);
            }
        }
        catch (Exception)
        {
            return (coordinates, true);
        }
        return (coordinates, false);
    }
}
