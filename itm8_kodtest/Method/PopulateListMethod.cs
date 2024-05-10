using itm8_kodtest.Models;

namespace itm8_kodtest.Method
{
    public class PopulateListMethod
    {
        public List<CityInformation> PopulateList()
        {
            List<CityInformation> cities = new List<CityInformation>
            {
                new CityInformation
                {
                    City = "Malmö", Country = Countries.Sweden.ToString(), Latitude = "55.593056", Longitude = "13.021389"
                },
                new CityInformation
                {
                    City = "Helsingborg", Country = Countries.Sweden.ToString(), Latitude = "56.0425", Longitude = "12.721111"
                },
                new CityInformation
                {
                    City = "Kristianstad", Country = Countries.Sweden.ToString(), Latitude = "56.020556", Longitude = "14.125556"
                },
                new CityInformation
                {
                    City = "Göteborg", Country = Countries.Sweden.ToString(), Latitude = "57.7075", Longitude = "11.9675"
                },
                new CityInformation
                {
                    City = "Stockholm", Country = Countries.Sweden.ToString(), Latitude = "59.329444", Longitude = "18.068611"
                },
                new CityInformation
                {
                    City = "København", Country = Countries.Denmark.ToString(), Latitude = "55.676111", Longitude = "12.568333"
                },
                new CityInformation
                {
                    City = "Aalborg", Country = Countries.Denmark.ToString(), Latitude = "57.05", Longitude = "9.916667"
                },
                new CityInformation
                {
                    City = "Aarhus", Country = Countries.Denmark.ToString(), Latitude = "56.15", Longitude = "10.2"
                },
                new CityInformation
                {
                    City = "Esbjerg", Country = Countries.Denmark.ToString(), Latitude = "55.483333", Longitude = "8.45"
                },
                new CityInformation
                {
                    City = "Herning", Country = Countries.Denmark.ToString(), Latitude = "56.133333", Longitude = "8.966667"
                },
                new CityInformation
                {
                    City = "Kolding", Country = Countries.Denmark.ToString(), Latitude = "55.483333", Longitude = "9.466667"
                },
                new CityInformation
                {
                    City = "Odense", Country = Countries.Denmark.ToString(), Latitude = "55.399722", Longitude = "10.385278"
                },
                new CityInformation
                {
                    City = "Randers", Country = Countries.Denmark.ToString(), Latitude = "56.45", Longitude = "10.05"
                },
                new CityInformation
                {
                    City = "Silkeborg", Country = Countries.Denmark.ToString(), Latitude = "56.175", Longitude = "9.55"
                },
                new CityInformation
                {
                    City = "Næstved", Country = Countries.Denmark.ToString(), Latitude = "55.229444", Longitude = "11.760556"
                },
                new CityInformation
                {
                    City = "Skovlunde", Country = Countries.Denmark.ToString(), Latitude = "55.719722", Longitude = "12.395"
                },
                new CityInformation
                {
                    City = "Vejle", Country = Countries.Denmark.ToString(), Latitude = "55.708333", Longitude = "9.533333"
                },
                new CityInformation
                {
                    City = "Viby", Country = Countries.Denmark.ToString(), Latitude = "56.125", Longitude = "10.161111"
                }
            };
            return cities;
        }
    }
}