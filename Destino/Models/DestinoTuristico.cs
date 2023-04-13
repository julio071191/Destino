using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Web;
using Destino.Models;


namespace Destino.Models
{
    public class DestinoTuristico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public byte[] Foto { get; set; }
    }

}