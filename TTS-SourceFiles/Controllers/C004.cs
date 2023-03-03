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
        string Error_Message_V00401_01,
        string Sucess_Message_V00401_02,
        string Error_Message_V00401_02)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        ViewBag.Sucess_Message_V00401_01 = Sucess_Message_V00401_01;
        ViewBag.Error_Message_V00401_01 = Error_Message_V00401_01;
        ViewBag.Sucess_Message_V00401_02 = Sucess_Message_V00401_02;
        ViewBag.Error_Message_V00401_02 = Error_Message_V00401_02;
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllAccounts = repo.M00402_GetAllAccounts();
        return View("~/Views/V004_User/V00401_UserPage.cshtml", model);
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
        return View("~/Views/V004_User/V00401_UserPage.cshtml", model);
    }

    [HttpPost]
    public IActionResult CreateUserForm(string LANGUAGE_SETTINGS, string CURRENT_USER)
    {
        R004 repo = new R004();
        M004_Account model = new M004_Account();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
    }

    [Route("C004/CreateUser/LANGUAGE_SETTINGS = {LANGUAGE_SETTINGS}/CURRENT_USER = {CURRENT_USER}/UNAME = {UNAME}/PSW = {PSW}/IsActive = {IsActive}")]
    public IActionResult CreateUser(
        string UNAME,
        string PSW,
        string IsActive,
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
        if(string.Compare(UNAME, "res") == 0) {
            ViewData["uname"] = null;
        } else {
            ViewData["uname"] = UNAME;
        }

        if(string.Compare(PSW, "res") == 0) {
            ViewData["psw"] = null;
        } else {
            ViewData["psw"] = PSW;
        }
        
        ViewData["checkbox"] = IsActive;
        if(string.Compare(UNAME, "res") == 0) 
        {
            ViewBag.Error_Message_V00402_01 = "アカウント名を入力してください。";
            return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
        } 
        else if (string.Compare(UNAME.Substring(UNAME.Length-8,8), "@tts.com") != 0)
        {
            ViewBag.Error_Message_V00402_04 = "メールは検証されていません。フォマット[@tts.com]";
            return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
        } 
        else if (PSW.Length < 4)
        {
            ViewBag.Error_Message_V00402_02 = "パスワードは 4 文字以上である必要があります。";
            return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
        } 
        else if(repo.M00403_IsCheckUserExists(UNAME))
        {
            ViewBag.Error_Message_V00402_03 = "アカウント名は存在しています。";
            return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
        }
        else
        {
            int USER_STATUS = 0;
            if(IsActive == "true") {
                USER_STATUS = 1;
            }
            bool isSuccess = repo.M00404_CreateNewAccount(UNAME, PSW, USER_STATUS, CURRENT_USER);
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
        return View("~/Views/V004_User/V00401_UserPage.cshtml", model);
    }

    [Route("C004/DeleteUser/LANGUAGE_SETTINGS = {LANGUAGE_SETTINGS}/CURRENT_USER = {CURRENT_USER}/ACCOUNT_ID = {ACCOUNT_ID}")]
    public IActionResult DeleteUser(
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
            string Sucess_Message_V00401_02 = "Delete Account Success";
            return RedirectToAction(
                    "Index",
                    "C004",
                    new 
                    {
                        LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                        CURRENT_USER = CURRENT_USER,
                        Sucess_Message_V00401_02 = Sucess_Message_V00401_02
                    });
        } else {
            string Error_Message_V00401_02 = "Delete Account Failed";
            return RedirectToAction(
                "Index",
                "C004",
                new
                {
                    LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                    CURRENT_USER = CURRENT_USER,
                    Error_Message_V00401_02 = Error_Message_V00401_02
                });
        }
        
    }
}
