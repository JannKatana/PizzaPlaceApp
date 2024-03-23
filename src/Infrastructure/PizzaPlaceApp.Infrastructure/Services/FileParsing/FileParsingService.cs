using System.Globalization;
using CsvHelper;

namespace PizzaPlaceApp.Application.Contracts.Services.FileParsing
{
    public class FileParsingService : IFileParsingService
    {
        public async Task<List<object>> ParseAsync(Stream stream, Type type)
        {
           var records = new List<object>();
           using (var reader = new StreamReader(stream))
           using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
           {
               records = csv.GetRecords(type).ToList();
           }

           return records;
        }
    }
}
