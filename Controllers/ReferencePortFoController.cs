using System.Collections;
using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> Upload(IFormFile? file)
    {
       return Ok(reader.ReadTheStocks(file));
    }
}