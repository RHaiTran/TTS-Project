using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
namespace TTS_SourceFiles.Controllers;

public class C001_Login : Controller
{
    private readonly ILogger<C001_Login> _logger;

    public C001_Login(ILogger<C001_Login> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View("~/Views/V001_Login/V00101_LoginPage.cshtml");
    }

    [HttpPost]
    public IActionResult LoginRequest(string uname, string psw)
    {
        using(var conn = ConnectDB.ConnectDataBase())
        {
            var test = string.Empty;
            test = test + "abc";
        }
        return View("~/Views/V000_Common/V00001_HomePage.cshtml");
    }
}
