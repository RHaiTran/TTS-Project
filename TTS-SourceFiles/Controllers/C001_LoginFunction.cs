using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
namespace TTS_SourceFiles.Controllers;

public class C001_LoginFunction : Controller
{
    private readonly ILogger<C001_LoginFunction> _logger;

    public C001_LoginFunction(ILogger<C001_LoginFunction> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult LoginRequest(string uname, string psw)
    {
        using(var conn = ConnectDB.ConnectDataBase())
        {
            var test = string.Empty;
            test = test + "abc";
        }
        return View("~/Views/V000_CommonScreen/V00001_HomePage.cshtml");
    }
}
