using InfoClimaPageWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InfoClimaPageWeb.ServiceReference1;
using InfoClimaPageWeb.ClientSoap;

namespace InfoClimaPageWeb.Controllers
{
    public class ClimaController : Controller
    {
    // GET: Clima
    // GET: Subject
    public ActionResult Index()
    {
      try
      {
        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var climas = client.ConsultarTodos();

        List<ClimaModel> listClimas = new List<ClimaModel>();

        foreach (var clima in climas)
        {
          listClimas.Add(new ClimaModel()
          {
            Id = clima.ClimaID,
            Ciudad = clima.City,
            Descripcion = clima.Description,
            Temperatura = clima.Temperature,
            Humedad = clima.Humidity,
            Viento = clima.Wind,
            Fecha = clima.Date
          });
        }

        clientSoap.Closed();

        return View(listClimas);
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // GET: Subject/Details/5
    public ActionResult Details(int id)
    {
      try
      {
        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var clima = client.Consultar(id.ToString());

        var climamodel = new ClimaModel()
        {
          Id = clima.ClimaID,
          Ciudad = clima.City,
          Descripcion = clima.Description,
          Temperatura = clima.Temperature,
          Humedad = clima.Humidity,
          Viento = clima.Wind,
          Fecha = clima.Date
        };

        clientSoap.Closed();

        return View(climamodel);
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // GET: Subject/Create
    public ActionResult Create()
    {
      try
      {
        return View();
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // POST: Subject/Create
    [HttpPost]
    public ActionResult Create(ClimaModel climamodel)
    {
      try
      {
        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var clima = new Clima()
        {
          ClimaID = climamodel.Id,
          City = climamodel.Ciudad,
          Description = climamodel.Descripcion,
          Temperature = climamodel.Temperatura,
          Humidity = Convert.ToInt32(climamodel.Humedad),
          Wind = climamodel.Viento,
          Date = climamodel.Fecha
        };
        var response = client.Registar(clima);

        clientSoap.Closed();

        if (response.IsSuccess)
        {
          return RedirectToAction("Index");
        }
        else
        {
          ViewBag.Message = response.Messange;

          return View("~/Views/Shared/Error.cshtml");
        }
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // GET: Subject/Edit/5
    public ActionResult Edit(int id)
    {
      try
      {
        if (id == null)
        {
          return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var clima = client.Consultar(id.ToString());

        var climamodel = new ClimaModel()
        {
          Id = clima.ClimaID,
          Ciudad = clima.City,
          Descripcion = clima.Description,
          Temperatura = clima.Temperature,
          Humedad = clima.Humidity,
          Viento = clima.Wind,
          Fecha = clima.Date
        };

        clientSoap.Closed();

        return View(climamodel);
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
        //return HttpNotFound(ex.Message);
      }
    }

    // POST: Subject/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, ClimaModel climamodel)
    {
      try
      {
        if (ModelState.IsValid)
        {
          ClientSOAP clientSoap = new ClientSOAP();
          var client = clientSoap.Initialize();
          var clima = new Clima()
          {
            ClimaID = climamodel.Id,
            City = climamodel.Ciudad,
            Description = climamodel.Descripcion,
            Temperature = climamodel.Temperatura,
            Humidity = Convert.ToInt32(climamodel.Humedad),
            Wind = climamodel.Viento,
            Date = climamodel.Fecha
          };
          var response = client.Actualizar(clima);

          clientSoap.Closed();

          if (response.IsSuccess)
          {
            return RedirectToAction("Index");
          }
          else
          {
            ViewBag.Message = response.Messange;

            return View("~/Views/Shared/Error.cshtml");
          }
        }
        else
        {
          return View(climamodel);
        }
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // GET: Subject/Delete/5
    public ActionResult Delete(int id)
    {
      try
      {
        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var clima = client.Consultar(id.ToString());

        var climamodel = new ClimaModel()
        {
          Id = clima.ClimaID,
          Ciudad = clima.City,
          Descripcion = clima.Description,
          Temperatura = clima.Temperature,
          Humedad = clima.Humidity,
          Viento = clima.Wind,
          Fecha = clima.Date
        };

        clientSoap.Closed();

        return View(climamodel);
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }

    // POST: Subject/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
      try
      {
        ClientSOAP clientSoap = new ClientSOAP();
        var client = clientSoap.Initialize();
        var result = client.Eliminar(id.ToString());


        clientSoap.Closed();

        if (result.IsSuccess)
        {
          return RedirectToAction("Index");
        }
        else
        {
          ViewBag.Message = result.Messange;

          return View("~/Views/Shared/Error.cshtml");
        }
      }
      catch (Exception ex)
      {
        ViewBag.Message = ex.Message;

        return View("~/Views/Shared/Error.cshtml");
      }
    }
  }
}