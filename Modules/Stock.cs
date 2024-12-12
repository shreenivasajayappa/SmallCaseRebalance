using CsvHelper.Configuration.Attributes;

namespace SmallCaseRebalencer.Modules;

public class Stock
{
    
    [Index(0)]
    public string name { get; set; }
    [Index(1)]
    public string ticker { get; set; }
    [Index(2)]
    public string currentPrice { get; set; } 
    [Index(3)]
    public decimal avgBuyPrice { get; set; } 
    [Index(4)]
    public decimal  returns{ get; set; } 
    [Index(5)]
    public double  weightage{ get; set; } 
    [Index(6)]
    public double  shares{ get; set; } 
    
}