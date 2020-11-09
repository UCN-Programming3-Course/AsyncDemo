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
    public class WidgetsController : ApiController
    {
        #region Test Data

        private static List<Widget> _widgets;

        static WidgetsController()
        {
            _widgets = new List<Widget>();

            for (int i = 0; i < 11; i++)
            {
                _widgets.Add(new Widget
                {
                    Id = i, 
                    Name = $"Widget_{i}", 
                    Price = .99M + i
                });
            }
        }
        #endregion

        [HttpGet]
        public IEnumerable<Widget> GetAll()
        {
            Thread.Sleep(4000);

            return _widgets;
        }
    }
}
