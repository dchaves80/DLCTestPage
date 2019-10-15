using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormaDePago
    {
        private string Nombre = null;
        private int Id=-1;

        public string NOMBRE { get => Nombre; }
        public int ID { get => Id; }

        private FormaDePago(DataRow dr)
        {
            Nombre = dr["NombreFormaPago"].ToString();
            Id = int.Parse(dr["Id"].ToString());
        }

        public static FormaDePago GetById(int ID)
        {
            DataRow dr = Connection.Con_FormaDePago.GetFormaDePagoByID(ID);
            if (dr != null)
            {
                return new FormaDePago(dr);
            }
            else
            {
                return null;
            }
        }

       

        public static List<FormaDePago> GetAll()
        {
            DataTable dt = Connection.Con_FormaDePago.GetFormaDePago();
            if (dt != null)
            {
                List<FormaDePago> lfp = new List<FormaDePago>();
                foreach (DataRow dr in dt.Rows)
                {
                    lfp.Add(new FormaDePago(dr));

                }
                return lfp;
            }
            else
            {
                return null;
            }
        }

        public static FormaDePago InsertNew(string Name)
        {
            int id =Connection.Con_FormaDePago.InsertFormaDePago(Name);
            return GetById(id);
        }

    }
}
