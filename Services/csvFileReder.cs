using System.Globalization;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.Xml;
using CsvHelper;
using CsvHelper.Configuration;
using SmallCaseRebalencer.Modules;

namespace SmallCaseRebalencer.Services;

public class csvFileReder
{

    Calculation calculater = new Calculation();

    public List<RebalencedStockQun>? ReadTheStocks(IFormFile RefrencePortfolio, IFormFile CurrentPortfolio)
    {
        Portfolio portfolio = new Portfolio();
        portfolio.ReferencePortfolio = ReadTheCSV(RefrencePortfolio).ToList();
        portfolio.ReferenceTotalInvestment =  CalculateTotalInvestment(portfolio.ReferencePortfolio);
        portfolio.Currentportfolio = ReadTheCSV(CurrentPortfolio).ToList();
        portfolio.CurrentTotalInvestment = CalculateTotalInvestment(portfolio.Currentportfolio);

        return calculater.CalculateRebalencedPortfolio(portfolio);   
    }

    public decimal CalculateTotalInvestment(IEnumerable<Stock> stocks)
    {
        decimal totalInvestment = 0;
        foreach (var stock in stocks)
        {
            totalInvestment += stock.CurrentPrice * stock.shares;
        }
        return totalInvestment;
    }

    public IEnumerable<Stock> ReadTheCSV(IFormFile file)
    {

        IEnumerable<Stock> stockList = new List<Stock>();
        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            PrepareHeaderForMatch = heder => heder.Header.ToLower().Replace(" ",""),
            

        };

        using (var stream = file.OpenReadStream())
        using (var fileReader = new StreamReader(stream))
        using (var csvReader = new CsvReader(fileReader, configuration)){

            while (fileReader.Peek() >= 0)
            {
                if (fileReader.ReadLine().ToLower().Contains("current investment")) break;
            }
            fileReader.ReadLine();
            //csvReader.ReadHeader();
            stockList = csvReader.GetRecords<Stock>().ToList();

        }

        return stockList;
    }
}