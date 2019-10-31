using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Treats.Controllers
{
   
  public class TreatController : Controller
  {
    private readonly TreatsContext _db;
    
    public TreatController(TreatsContext db)
    {
      _db = db;
    }
    
    public ActionResult Index()
    {
      List<Treat> model = _db.Treat.ToList();
      return View(model);
    }
  [Authorize]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treat.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Info(int id)
    {
        var thisTreat = _db.Treat
        .Include(treat => treat.Flavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
        return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treat.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treat.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treat.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treat.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}