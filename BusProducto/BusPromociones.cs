using Opticx.Productos.Bussiness.Entity;
using Opticx.Productos.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opticx.Productos.Business
{
    public class BusPromociones
    {
        public BusPromociones() { }

        public List<EntPromociones> TopCincoPromociones()
        {
            DataTable dt = new DatPromociones().TopCincoPromociones();
            List<EntPromociones> lst = new List<EntPromociones>();
            foreach(DataRow dr in dt.Rows)
            {
                EntPromociones ent = new EntPromociones();
                ent.Id = Convert.ToInt32(dr["PROM_ID"].ToString());
                ent.Nombre=dr["PROM_NOMB"].ToString();
                ent.Descripcion=dr["PROM_DESC"].ToString();
                ent.Foto=dr["PROM_FOTO"].ToString();
                ent.mesId=Convert.ToInt32(dr["PROM_MES_ID"].ToString());
                ent.Mes.Nombre=dr["MES_NOMB"].ToString();
                ent.FechaCaptura = Convert.ToDateTime(dr["PROM_FECH_CAPT"].ToString());
                lst.Add(ent);

            }
            return lst;
        }
    }
}
