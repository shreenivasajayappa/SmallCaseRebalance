using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using SmallCaseRebalencer.Modules;

namespace SmallCaseRebalencer.Services;

public class csvFileReder
{
    public IEnumerable<Stock> ReadTheStocks(IFormFile file)
    {

        IEnumerable<Stock> stockList = new List<Stock>();
        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = false,
            HeaderValidated = null
        };

        using (var stream = file.OpenReadStream())
        using (var fileReader = new StreamReader(stream))
        using (var csvReader = new CsvReader(fileReader, configuration)){

            while (fileReader.Peek()>=0)
            {
                if(fileReader.ReadLine().ToLower().Contains("name,ticker")) break;
            }     
            
            stockList = csvReader.GetRecords<Stock>().ToList();

        }

        return stockList;
    }
}