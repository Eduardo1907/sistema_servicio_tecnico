using System;
using System.Collections.Generic;

namespace Mercy_Developer.Models;

public partial class Descripcionservicio
{
    public int Id { get; set; }

    public int ServicioId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Servicio Servicio { get; set; } = null!;
}
