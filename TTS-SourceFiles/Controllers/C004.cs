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
        M004_User model = new M004_User();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        ViewBag.Sucess_Message_V00401_01 = Sucess_Message_V00401_01;
        ViewBag.Error_Message_V00401_01 = Error_Message_V00401_01;
        ViewBag.Sucess_Message_V00401_02 = Sucess_Message_V00401_02;
        ViewBag.Error_Message_V00401_02 = Error_Message_V00401_02;
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllUsers = repo.M00402_GetAllUsers();
        return View("~/Views/V004_User/V00401_UserPage.cshtml", model);
    }


    [HttpPost]
    public IActionResult Index(string LANGUAGE_SETTINGS, string CURRENT_USER)
    {
        R004 repo = new R004();
        M004_User model = new M004_User();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllUsers = repo.M00402_GetAllUsers();
        return View("~/Views/V004_User/V00401_UserPage.cshtml", model);
    }

    [HttpPost]
    public IActionResult CreateUserForm(string LANGUAGE_SETTINGS, string CURRENT_USER)
    {
        R004 repo = new R004();
        M004_User model = new M004_User();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00403_LabelCreateUserForms = repo.M00403_LabelCreateUserForms(LANGUAGE_SETTINGS);
        return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
    }

    [Route("C004/CreateUser/LANGUAGE_SETTINGS = {LANGUAGE_SETTINGS}/CURRENT_USER = {CURRENT_USER}/UNAME = {UNAME}/PSW = {PSW}/IsActive = {IsActive}/USER_ROLE = {USER_ROLE}")]
    public IActionResult CreateUser(
        string UNAME,
        string PSW,
        string IsActive,
        string USER_ROLE,
        string CURRENT_USER,
        string LANGUAGE_SETTINGS)
    {
        R004 repo = new R004();
        M004_User model = new M004_User();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.CURRENT_USER = CURRENT_USER;
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllUsers = repo.M00402_GetAllUsers();
        if(repo.M00403_IsCheckUserExists(UNAME))
        {
            string errorMessage = SetLanguage.GetFieldName(LANGUAGE_SETTINGS, "Error_Message_V00402_03");
            ViewBag.Error_Message_V00402_03 = string.Format(errorMessage, UNAME);
            model.M00403_LabelCreateUserForms = repo.M00403_LabelCreateUserForms(LANGUAGE_SETTINGS);
            return View("~/Views/V004_User/V00402_CreateUserForm.cshtml", model);
        }
        int USER_STATUS = 0;
        if(IsActive == "true") {
            USER_STATUS = 1;
        }
        bool isSuccess = repo.M00404_CreateNewAccount(UNAME, PSW, USER_STATUS, CURRENT_USER, USER_ROLE);
        if(isSuccess) {
            return RedirectToAction(
                "Index",
                "C004",
                new 
                {
                    LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                    CURRENT_USER = CURRENT_USER,
                    Sucess_Message_V00401_01 = SetLanguage.GetFieldName(LANGUAGE_SETTINGS, "Sucess_Message_V00401_01")
                });
        } else {
            return RedirectToAction(
                "Index",
                "C004",
                new
                {
                    LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                    CURRENT_USER = CURRENT_USER,
                    Error_Message_V00401_01 = SetLanguage.GetFieldName(LANGUAGE_SETTINGS, "Error_Message_V00401_01                                                                                                                                       ")
                });
        }
    }
    
    [Route("C004/ReturnUserPage/LANGUAGE_SETTINGS = {LANGUAGE_SETTINGS}/CURRENT_USER = {CURRENT_USER}")]
    public IActionResult ReturnUserPage(
        string LANGUAGE_SETTINGS,
        string CURRENT_USER)
    {
        R004 repo = new R004();
        M004_User model = new M004_User();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        model.CURRENT_USER = CURRENT_USER;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllUsers = repo.M00402_GetAllUsers();
        return View("~/Views/V004_User/V00401_UserPage.cshtml", model);
    }

    [Route("C004/DeleteUser/LANGUAGE_SETTINGS = {LANGUAGE_SETTINGS}/CURRENT_USER = {CURRENT_USER}/ACCOUNT_ID = {ACCOUNT_ID}")]
    public IActionResult DeleteUser(
        string LANGUAGE_SETTINGS,
        string CURRENT_USER,
        int ACCOUNT_ID)
    {
        R004 repo = new R004();
        M004_User model = new M004_User();
        ViewData["LANGUAGE_SETTINGS"] = LANGUAGE_SETTINGS;
        ViewBag.PageID = "V004";
        model.M00001_NavigationNames = repo.M00400_SetLabelLayout(LANGUAGE_SETTINGS);
        model.M00401_LabelTables = repo.M00401_SetLabelTable(LANGUAGE_SETTINGS);
        model.M00402_GetAllUsers = repo.M00402_GetAllUsers();
        bool result = repo.M00405_DeleteAccount(ACCOUNT_ID);
        if(result){
            return RedirectToAction(
                    "Index",
                    "C004",
                    new 
                    {
                        LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                        CURRENT_USER = CURRENT_USER,
                        Sucess_Message_V00401_02 = SetLanguage.GetFieldName(LANGUAGE_SETTINGS, "Sucess_Message_V00401_02")
                    });
        } else {
            return RedirectToAction(
                "Index",
                "C004",
                new
                {
                    LANGUAGE_SETTINGS = LANGUAGE_SETTINGS, 
                    CURRENT_USER = CURRENT_USER,
                    Error_Message_V00401_02 = SetLanguage.GetFieldName(LANGUAGE_SETTINGS, "Error_Message_V00401_02")
                });
        }
        
    }

    public IActionResult EditUser()
    {
        return NoContent();
    }
}
