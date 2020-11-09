using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GizmoWebClient.Models
{
    public class Gizmo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime IntroducedDate { get; set; }
        public int Quantity { get; set; }
    }
}