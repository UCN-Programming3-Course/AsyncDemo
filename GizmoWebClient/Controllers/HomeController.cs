using GizmoWebClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GizmoWebClient.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var model = new TotalModel();

            var client = new RestClient("https://localhost:44318/api");

            #region Synchronous Code

            //var gizmos = client.Get<IEnumerable<Gizmo>>(new RestRequest("/gizmos"));
            //var products = client.Get<IEnumerable<Product>>(new RestRequest("/products"));
            //var widgets = client.Get<IEnumerable<Widget>>(new RestRequest("/widgets"));

            //model.Gizmos = gizmos.Data;
            //model.Products = products.Data;
            //model.Widgets = widgets.Data;

            #endregion

            #region MyRegion

            var gizmos = client.GetAsync<IEnumerable<Gizmo>>(new RestRequest("/gizmos"));
            
            var products = client.GetAsync<IEnumerable<Product>>(new RestRequest("/products"));
            
            var widgets = client.GetAsync<IEnumerable<Widget>>(new RestRequest("/widgets"));

            await Task.WhenAll(gizmos, products, widgets);

            model.Gizmos = gizmos.Result;
            model.Products = products.Result;
            model.Widgets = widgets.Result;

            #endregion

            return View(model);
        }
    }
}