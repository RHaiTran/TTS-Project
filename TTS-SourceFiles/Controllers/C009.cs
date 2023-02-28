using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C009 : Controller
{
    private readonly ILogger<C009> _logger;

    public C009(ILogger<C009> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string LANGUAGE_SETTINGS)
    {
        R001 repo = new R001();
        M000_Layout model = new M000_Layout();
       ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V009";
        model.M00001_NavigationNames = repo.M00001_SetLanguage(LANGUAGE_SETTINGS);
        return View("~/Views/V009_Setting/V009_SettingPage.cshtml", model);
    }
}
