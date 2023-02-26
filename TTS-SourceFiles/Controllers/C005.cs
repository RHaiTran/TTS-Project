using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C005 : Controller
{
    private readonly ILogger<C005> _logger;

    public C005(ILogger<C005> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string language)
    {
        R001 repo = new R001();
        M000_Layout model = new M000_Layout();
        ViewBag.Language = language;
        model.M00001_NavigationNames = repo.M00001_SetLanguage(language);
        return View("~/Views/V005_Notification/V00501_NotificationPage.cshtml", model);
    }
}
