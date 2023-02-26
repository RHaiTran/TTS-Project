using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TTS_SourceFiles.Models;
using TTS_SourceFiles.Common;
using TTS_SourceFiles.Repository;
namespace TTS_SourceFiles.Controllers;

public class C004 : Controller
{
    private readonly ILogger<C004> _logger;

    public C004(ILogger<C004> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Index(string language)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewBag.Language = language;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(language);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(language);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
    }
}
