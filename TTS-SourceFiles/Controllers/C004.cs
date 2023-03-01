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

    [HttpGet]
    public IActionResult Index(
        string LANGUAGE_SETTINGS,
        string CURRENT_USER,
        string Sucess_Message_V00401_01,
        string Error_Message_V00401_01)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        ViewBag.Sucess_Message_V00401 = Sucess_Message_V00401_01;
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
    }


    [HttpPost]
    public IActionResult Index(string LANGUAGE_SETTINGS, string CURRENT_USER)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
    }

    [HttpPost]
    public IActionResult CreateAccountPage(string LANGUAGE_SETTINGS, string CURRENT_USER)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        return View("~/Views/V004_Account/V00402_CreateAccountPage.cshtml", model);
    }

    public IActionResult CreateAccount(
        string uname,
        string psw,
        string checkbox,
        string CURRENT_USER,
        string LANGUAGE_SETTINGS)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
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
            bool isSuccess = repo.M00404_CreateNewAccount(uname, psw, isChecked, CURRENT_USER);
            if(isSuccess) {
                return RedirectToAction(
                    "Index",
                    "C004",
                    new 
                    {
                        LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                        CURRENT_USER = CURRENT_USER,
                        Sucess_Message_V00401_01 = "Sucess"
                    });
            } else {
                return RedirectToAction(
                    "Index",
                    "C004",
                    new
                    {
                        LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                        CURRENT_USER = CURRENT_USER,
                        Error_Message_V00401_01 = "Failed"
                    });
            }
        }
    }

    [HttpPost]
    public IActionResult ReturnAccountPage(string LANGUAGE_SETTINGS)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
    }

    [Route("C004/DeleteAccount/LANGUAGE_SETTINGS = {LANGUAGE_SETTINGS}/CURRENT_USER = {CURRENT_USER}/ACCOUNT_ID = {ACCOUNT_ID}")]
    public IActionResult DeleteAccount(
        string LANGUAGE_SETTINGS,
        string CURRENT_USER,
        int ACCOUNT_ID)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        bool result = repo.M00405_DeleteAccount(ACCOUNT_ID);
        if(result){
            model.CURRENT_USER = CURRENT_USER;
            ViewBag.Sucess_Message_V00402 = "Delete Account Success";
            return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
        } else {
            model.CURRENT_USER = CURRENT_USER;
            ViewBag.Error_Message_V00402 = "Delete Account Failed";
            return View("~/Views/V004_Account/V00401_AccountPage.cshtml", model);
        }
        
    }
}
