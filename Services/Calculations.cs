using SmallCaseRebalencer.Modules;
using System;
using System.Reflection.Metadata.Ecma335;

public class Calculation
{
    internal List<RebalencedStockQun> CalculateRebalencedPortfolio(Portfolio portfolio)
    
    {
        List<RebalencedStockQun> RebalencedStickQunList = new List<RebalencedStockQun>();

        foreach (var stock in portfolio.ReferencePortfolio)
        {

                var Quntity = (stock.weightage * portfolio.CurrentTotalInvestment)/(stock.CurrentPrice*100);
            RebalencedStickQunList.Add(new RebalencedStockQun() { Stock = stock, Quantity = Quntity });
            }

        return RebalencedStickQunList;
    }

    
}
