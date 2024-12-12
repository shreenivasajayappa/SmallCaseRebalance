using CsvHelper.Configuration.Attributes;

namespace SmallCaseRebalencer.Modules;

public class Stock
{
    
    [Name("Name")]
    //[Index(0)]
    public string name { get; set; }
    [Name("Ticker")]
    //[Index(1)]
    public string ticker { get; set; }
    [Name("Current Price (Rs.)")]
    //[Index(2)]
    public decimal currentPrice { get; set; } 
    //[Name("Avg Buy Price (Rs.)\n")]
    [Index(3)]
    public decimal avgBuyPrice { get; set; } 
    //[Name("Returns (%)")]
    [Index(4)]
    public decimal returns { get; set; } 
    [Name("Weightage")]
    //[Index(5)]
    public decimal weightage { get; set; } 
    [Name("Shares")]
    //[Index(6)]
    public decimal shares { get; set; } 
    
}