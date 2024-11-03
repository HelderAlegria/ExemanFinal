using System;
using System.Collections.Generic;

namespace WEBAPICRUD.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? genero { get; set; }

    public string? fechaNacimeinto { get; set; }

    public string? estado { get; set; }

    public string? direccion { get; set; }

    public string? fechaCreacion { get; set; }

    public string? fechaActualizacion { get; set; }

    public int? usuarioCreo { get; set; }

    public string? estadoInformacion { get; set; }
}
