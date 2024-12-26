using CsvHelper.Configuration.Attributes;

namespace SmallCaseRebalencer.Modules;

public class Stock
{
    
    //[Name("Name")]
    //[Index(0)]
    public string name { get; set; }
    [Name("Ticker")]
    //[Index(1)]
    public string ticker { get; set; }
    //[Index(2)]
    [Name("Current Price (Rs.)")]
    public decimal CurrentPrice{ get; set; }
    [Name("Avg Buy Price (Rs.)")]
    //[Index(3)]
    public decimal avgBuyPrice { get; set; }
    //Index(4)]
    [Name("Returns (%)")]
    public decimal returns { get; set; }
    //[Index(5)]
    [Name("Weightage")]
    public decimal weightage { get; set; }
    //[Index(6)]
    [Name("Shares")]
    public decimal shares { get; set; }

}