using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C002 : Controller
{
    private readonly ILogger<C002> _logger;

    public C002(ILogger<C002> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string LANGUAGE_SETTINGS)
    {
        R001 repo = new R001();
        M000_Layout model = new M000_Layout();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V002";
        model.M00001_NavigationNames = repo.M00001_SetLanguage(LANGUAGE_SETTINGS);
        return View("~/Views/V002_Home/V00201_HomePage.cshtml", model);
    }
}
