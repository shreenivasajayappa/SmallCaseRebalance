using System.Globalization;
using CsvHelper;
using SmallCaseRebalencer.Modules;

namespace SmallCaseRebalencer.Services;

public class csvFileReder
{
    public IEnumerable<Stock> ReadTheStocks(IFormFile file)
    {

        IEnumerable<Stock> stockList = new List<Stock>();
        using (var stream = file.OpenReadStream())
        using (var fileReader = new StreamReader(stream))
        using (var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture))
        {
            while (fileReader.Peek() >= 0)
            {
                if (fileReader.ReadLine().Contains("Name,Ticker,Current ")) break;
            }

            stockList = csvReader.GetRecords<Stock>().ToList();

        }

        return stockList;
    }
}