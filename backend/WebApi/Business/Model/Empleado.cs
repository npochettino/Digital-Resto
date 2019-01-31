using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public int DNI { get; set; }
        public DateTime FechadeNac { get; set; }

        public virtual RolEmpleado Rol{ get; }
    }
}
