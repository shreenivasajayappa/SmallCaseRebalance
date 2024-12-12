using CsvHelper.Configuration.Attributes;

namespace SmallCaseRebalencer.Modules;

public class Stock
{
    
    //[Name("Name")]
    [Index(0)]
    public string name { get; set; }
    //[Name("Ticker")]
    [Index(1)]
    public string ticker { get; set; }
    //[Name("Current Price (Rs.)")]
    [Index(2)]
    public string currentPrice { get; set; } 
    //[Name("Avg Buy Price (Rs.)\n")]
    [Index(3)]
    public string avgBuyPrice { get; set; } 
    //[Name("Returns (%)")]
    [Index(4)]
    public string  returns{ get; set; } 
    //[Name("Weightage")]
    [Index(5)]
    public string  weightage{ get; set; } 
    //[Name("Shares")]
    [Index(6)]
    public string  shares{ get; set; } 
    
}