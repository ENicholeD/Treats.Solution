using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Treats.Controllers
{
   
  public class FlavorController : Controller
  {
    private readonly TreatsContext _db;
    
   public FlavorController(TreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavor.ToList();
      return View(model);
    }
    [Authorize]
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      _db.Flavor.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Info(int id)
    {
        return View();
    }
    public ActionResult Edit(int id)
    {
      var thisFlavor = _db.Flavor.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }
    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
     public ActionResult Delete(int id)
    {
      var thisFlavor = _db.Flavor.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavor = _db.Flavor.FirstOrDefault(flavor => flavor.FlavorId == id);
      _db.Flavor.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}