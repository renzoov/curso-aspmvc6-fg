using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TareasMVC.Servicios
{
    public class Constantes
    {
        public const string RolAdmin = "admin";

        public static readonly SelectListItem[] CulturasUISoportadas = new SelectListItem[]
        {
            new SelectListItem{Value = "es", Text = "Español"},
            new SelectListItem{Value = "en", Text = "English"}
        };
    }
}
