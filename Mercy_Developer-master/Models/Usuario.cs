using System;
using System.Collections.Generic;

namespace Mercy_Developer.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? Password { get; set; }

    public string? Rut { get; set; }

    /// <summary>
    /// 0:Inactivo ; 1:Activo
    /// 
    /// </summary>
    public int Estado { get; set; }

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
