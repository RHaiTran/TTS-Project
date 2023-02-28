using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C008 : Controller
{
    private readonly ILogger<C008> _logger;

    public C008(ILogger<C008> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string LANGUAGE_SETTINGS)
    {
        R001 repo = new R001();
        M000_Layout model = new M000_Layout();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V008";
        model.M00001_NavigationNames = repo.M00001_SetLanguage(LANGUAGE_SETTINGS);
        return View("~/Views/V008_FileManagement/V00801_FileManagementPage.cshtml", model);
    }
}
