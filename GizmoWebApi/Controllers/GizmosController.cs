using GizmoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace GizmoWebApi.Controllers
{
    public class GizmosController : ApiController
    {
        #region Test Data

        private static List<Gizmo> _gizmos;

        static GizmosController()
        {
            _gizmos = new List<Gizmo>();

            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                _gizmos.Add(new Gizmo
                {
                    Id = i,
                    Name = $"Gizmo_{i}",
                    IntroducedDate = DateTime.Now.AddDays(5 * i),
                    Quantity = rnd.Next(132, 456)
                });
            }
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<Gizmo>> GetAll()
        {

            await Task.Delay(5000);
         
            return _gizmos;
        }
    }
}
