using System.Collections;
using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using SmallCaseRebalencer.Modules;

namespace SmallCaseRebalencer.Controllers;

public class ReferencePortFoController : Controller
{
    public ReferencePortFoController()
    {
    }


    [HttpPost("upload")]
    public async void Upload(IFormFile? file)
    {
        
      
    }
}