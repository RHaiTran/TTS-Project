using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C010 : Controller
{
    private readonly ILogger<C010> _logger;

    public C010(ILogger<C010> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Logout(string LANGUAGE_SETTINGS)
    {
        M001_Login model = new M001_Login();
        R001 repo = new R001();
        ViewBag.Set_Language = LANGUAGE_SETTINGS;
        model.M00102_SetLoginPageLanguages = repo.M00102_SetLoginPageLanguage(LANGUAGE_SETTINGS);
        return View("~/Views/V001_Login/V00101_LoginPage.cshtml", model);
    }
}
