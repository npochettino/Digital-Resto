using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Cuenta
    {
        public int cuentaId { get; set; }

        public virtual Mesa Mesa { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }   
    }
}
