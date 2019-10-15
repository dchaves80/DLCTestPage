using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Unidad
    {
        int Id;
        string NombreUnidad;
        string Simbolo;

        public int ID { get => Id; }
        public string NOMBRE_UNIDAD { get => NombreUnidad; }
        public string SIMBOLO { get => Simbolo; }

        private Unidad (DataRow dr)
        {
            Id = int.Parse(dr["Id"].ToString());
            NombreUnidad = dr["NombreUnidad"].ToString();
            Simbolo = dr["Simbolo"].ToString();
        }

        public static List<Unidad> GetAll()
        {
            DataTable DT = Connection.Con_Unidades.select_all_unidades();
            if (DT != null)
            {
                List<Unidad> u = new List<Unidad>();
                foreach (DataRow dr in DT.Rows)
                {
                    u.Add(new Unidad(dr));
                }
                return u;
            }
            else { return null; }
        }

        public static Unidad InsertUnidad(string Nombre, string Simbolo)
        {
           int idu = Connection.Con_Unidades.insert_unidad(Nombre, Simbolo);
            if (idu != -1)
            {
                return GetById(idu);
            }
            else
            {
                return null;
            }
      
        }

        public static Unidad GetById(int ID)
        {
            DataRow dr = Connection.Con_Unidades.select_byid_unidad(ID);
            if (dr != null)
            {
                return new Unidad(dr);
            }
            else
            {
                return null;
            }
        }

    }
}
