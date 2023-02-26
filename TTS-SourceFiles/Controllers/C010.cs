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
    public IActionResult Logout()
    {
        return View("~/Views/V001_Login/V00101_LoginPage.cshtml");
    }
}
