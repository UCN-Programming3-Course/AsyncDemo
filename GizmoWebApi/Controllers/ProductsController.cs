using GizmoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace GizmoWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        #region Test Data

        private static List<Product> _products;

        static ProductsController()
        {
            _products = new List<Product>();

            for (int i = 0; i < 8; i++)
            {
                _products.Add(new Product
                {
                    Id = i,
                    Name = $"Product_{i}",
                    Price = .88M + i
                });
            }
        } 
        #endregion

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            Thread.Sleep(3000);

            return _products;
        }
    }
}
