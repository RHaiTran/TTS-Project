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
    public IActionResult Index(
        string LANGUAGE_SETTINGS,
        string CURRENT_USER)
    {
        R002 repo002 = new R002();
        M002_Home modelHome = new M002_Home(); 
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        modelHome.CURRENT_USER = CURRENT_USER;
        ViewBag.PageID = "V002";
        modelHome.M00001_NavigationNames = repo002.M00200_SetLabelLayout(LANGUAGE_SETTINGS);
        return View("~/Views/V002_Home/V00201_HomePage.cshtml", modelHome);
    }

    public IActionResult CreateNotificationPage()
    {
        return View("~/Views/V002_Home/V00202_CreateNotificationForm.cshtml");
    }
}
