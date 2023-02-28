using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C003 : Controller
{
    private readonly ILogger<C003> _logger;

    public C003(ILogger<C003> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string LANGUAGE_SETTINGS)
    {
        R001 repo = new R001();
        M000_Layout model = new M000_Layout();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V003";
        model.M00001_NavigationNames = repo.M00001_SetLanguage(LANGUAGE_SETTINGS);
        return View("~/Views/V003_Department/V00301_DepartmentPage.cshtml", model);
    }
}
