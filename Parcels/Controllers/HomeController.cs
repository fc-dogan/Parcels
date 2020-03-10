using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult ParcelForm()
      {
        return View();
      }

      [Route("/result")]
      public ActionResult Result(int weight, int length, int width, int height)
      {
        Parcel newParcel = new Parcel(weight, length, width, height);
        newParcel.Volumer(length, width, height);
        newParcel.CostToShip();

        return View(newParcel);
      }



    }
}