using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GizmoWebClient.Models
{
    public class TotalModel
    {
        public IEnumerable<Gizmo> Gizmos { get; set; }
        public IEnumerable<Widget> Widgets { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}