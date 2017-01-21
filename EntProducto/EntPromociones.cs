using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opticx.Productos.Bussiness.Entity
{
    public class EntPromociones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public int mesId { get; set; }

        private EntMeses mes;

        public EntMeses Mes
        {
            get
            {
                if (mes == null)
                    mes = new EntMeses();
                return mes;
            }
            set
            {
                if (mes == null)
                    mes = new EntMeses();
                mes = value;
            }
        }

        public DateTime FechaCaptura { get; set; }



    }
}
public class EntMeses
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}
