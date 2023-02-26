using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C007 : Controller
{
    private readonly ILogger<C007> _logger;

    public C007(ILogger<C007> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string language)
    {
        R001 repo = new R001();
        M000_Layout model = new M000_Layout();
        ViewBag.Language = language;
        ViewBag.PageID = "V007";
        model.M00001_NavigationNames = repo.M00001_SetLanguage(language);
        return View("~/Views/V007_Message/V00701_MessagePage.cshtml", model);
    }
}
