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

    [HttpPost]
    public IActionResult CreateAccountPage(string language)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewBag.Language = language;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(language);
        return View("~/Views/V004_Account/V00402_CreateAccountPage.cshtml", model);
    }

    public IActionResult CreateAccount(string uname, string psw, string checkbox, string language)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewBag.Language = language;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(language);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(language);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        ViewData["uname"] = uname;
        ViewData["psw"] = psw;
        ViewData["checkbox"] = checkbox;
        if(string.IsNullOrEmpty(uname)) {
            ViewBag.Error_Message_V00402_01 = "アカウント名を入力してください。";
            return View("~/Views/V004_Account/V00402_CreateAccountPage.cshtml", model);
        }
        if(string.IsNullOrEmpty(psw) || psw.Length < 4){
            ViewBag.Error_Message_V00402_02 = "パスワードは 4 文字以上である必要があります。";
            return View("~/Views/V004_Account/V00402_CreateAccountPage.cshtml", model);
        }
        bool isExist = repo.M00403_IsCheckUserExists(uname);
        if(isExist){
            ViewBag.Error_Message_V004_03 = "アカウント名は存在しています。";
            return View("~/Views/V004_Account/V00402_CreateAccountPage.cshtml", model);
        }
        else
        {
            int isChecked = 0;
            if(checkbox != null) {
                isChecked = 1;
            }
            bool isSuccess = repo.M00404_CreateNewAccount(uname, psw, isChecked);
            if(isSuccess) {
                ViewBag.Sucess_Message_V00401 = "OK";
            }
            return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
        }
    }

    public IActionResult BackAccountPage(string language)
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
