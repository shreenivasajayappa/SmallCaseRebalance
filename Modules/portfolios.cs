using SmallCaseRebalencer.Modules;
using System;

public class Portfolio
{

   
    public List<Stock>? ReferencePortfolio { set; get; }
	public decimal ReferenceTotalInvestment { set; get; }
    public List<Stock>? Currentportfolio { set; get; }
    public decimal CurrentTotalInvestment { set; get; }
    
}
