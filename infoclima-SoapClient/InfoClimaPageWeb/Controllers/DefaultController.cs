using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using InfoClimaPageWeb.ClientSoap;
using InfoClimaPageWeb.Models;
using InfoClimaPageWeb.ServiceReference1;

namespace InfoClimaPageWeb.Controllers
{
    public class DefaultController : Controller
    {
    // GET: Default
    public static int ErrorAuth = 0;
    // GET: Home
    public ActionResult Index()
    {

      LoginUserModel loginModel = new LoginUserModel();

      var auth = Session["isAuth"];
      var user = Session["username"];
      var description = Session["description"];

      if (auth != null && user != null && description != null)
      {
        loginModel.username = user.ToString();
        loginModel.isAuth = (bool)auth;
        loginModel.description = description.ToString();
      }

      if (ErrorAuth == 1)
      { ViewBag.Error = "Los datos ingresados son errados"; }

      return View(loginModel);

    }
    // POST: Home/LoginIn
    [HttpPost]
    public ActionResult LoginIn(FormCollection collection)
    {
      try
      {
        foreach (string _formData in collection)
        {
          ViewData[_formData] = collection[_formData];
        }

        LoginUserModel loginModel = new LoginUserModel();
        loginModel.id = 0;
        loginModel.username = ViewData["username"].ToString();
        loginModel.key = ViewData["key"].ToString();

        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var user = client.Login(loginModel.username, loginModel.key);

        if (user != null)
        {
          loginModel.isAuth = true;
          loginModel.id = user.UserID;
          loginModel.description = user.FirstName + " " + user.LastName;

          Session["username"] = loginModel.username;
          Session["isAuth"] = loginModel.isAuth;
          Session["description"] = loginModel.description;
          Session["id"] = loginModel.id;
          ErrorAuth = 0;
        }
        else
        {
          loginModel.isAuth = false;
          ErrorAuth = 1;
        }

        clientSoap.Closed();

        return RedirectToAction("Index", "Default", loginModel);

      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // GET: Home/LoginOut
    [HttpGet]
    public ActionResult LoginOut()
    {
      Session.Abandon();

      return RedirectToAction("Index");
    }

    public ActionResult About()
    {
      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Contactarnos.";

      return View();
    }
  }
}