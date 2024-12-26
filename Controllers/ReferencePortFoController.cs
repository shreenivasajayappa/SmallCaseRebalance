using System.Collections;
using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using OfficeOpenXml;
using SmallCaseRebalencer.Modules;
using SmallCaseRebalencer.Services;

namespace SmallCaseRebalencer.Controllers;

public class ReferencePortFoController : Controller
{
    public ReferencePortFoController()
    {
    }

    private csvFileReder reader = new csvFileReder(); 

    [HttpPost("upload")]
    public async Task<IActionResult> Upload(IFormFile? RefrencePortfolio, IFormFile CurrentPortfolio)
    {
        if (RefrencePortfolio == null || CurrentPortfolio == null)
        {
            return BadRequest("Please upload the files");
        }
        var referencePortfolio = reader.ReadTheStocks(RefrencePortfolio, CurrentPortfolio);
        return Ok(referencePortfolio);
   
    }
}