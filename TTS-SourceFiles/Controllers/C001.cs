using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C001 : Controller
{
    private readonly ILogger<C001> _logger;

    public C001(ILogger<C001> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View("~/Views/V001_Login/V00101_LoginPage.cshtml");
    }

    [HttpPost]
    public IActionResult LoginRequest(string uname, string psw, string select_language)
    {
        R001 repo = new R001();
        int result = repo.M00101_CheckUserInfo(uname, psw);
        M000_Layout model = new M000_Layout();
        model.M00001_NavigationNames = repo.M00001_SetLanguage(select_language);
        if(result == 1)
        {
            ViewData["CURRENT_USER"] = uname;
            ViewData["LANGUAGE_SETTINGS"] = select_language;
            return View("~/Views/V002_Home/V00201_HomePage.cshtml", model);
        } else if(result == -1)
        {
            ViewBag.Error_Message_V001_002 = SetLanguage.GetFieldName(select_language, "Error_Message_V001_002");
            return View("~/Views/V001_Login/V00101_LoginPage.cshtml");
        }
        else {
            ViewBag.Error_Message_V001_001 = SetLanguage.GetFieldName(select_language, "Error_Message_V001_001");
            return View("~/Views/V001_Login/V00101_LoginPage.cshtml");
        }
    }
}
