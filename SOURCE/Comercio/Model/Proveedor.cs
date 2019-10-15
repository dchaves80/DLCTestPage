using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;

namespace Model
{
    public class Proveedor
    {
        int Id;
        string Nombre;
        string Telefono;
        string Cuit;

        public int ID { get { return Id; } }
        public string NOMBRE { get { return Nombre; } }
        public string TELEFONO { get { return Telefono; } }
        public string CUIT { get { return Cuit; } }

        private Proveedor(DataRow p)
        {
            Id = int.Parse(p["Id"].ToString());
            Nombre = p["Nombre"].ToString();
            if (!p.IsNull("Telefono")) { Telefono = p["Telefono"].ToString(); }
            if (!p.IsNull("Cuit")) { Cuit = p["Cuit"].ToString(); }
        }

        public static List<Proveedor> GetTop(int Count)
        {
            DataTable DT = Con_Proveedor.select_top_proveedores(Count);
            if (DT != null)
            {
                List<Proveedor> LP = new List<Proveedor>();
                foreach (DataRow dr in DT.Rows)
                {
                    LP.Add(new Proveedor(dr));
                }
                return LP;
            }
            else
            {
                return null;
            }
        }

        public static List<Proveedor> GetAll()
        {
            DataTable DT = Con_Proveedor.select_all_proveedores();
            if (DT != null)
            {
                List<Proveedor> LP = new List<Proveedor>();
                foreach (DataRow dr in DT.Rows)
                {
                    LP.Add(new Proveedor(dr));
                }
                return LP;
            }
            else
            {
                return null;
            }
        }

        public static Proveedor InsertNew(string nombre, string telefono, string cuit)
        {
            return new Proveedor(Con_Proveedor.insert_proveedor(nombre, telefono, cuit));
        }

        public Proveedor Actualizar(string nombre, string telefono, string cuit)
        {


            if (nombre != null) Nombre = nombre;
            if (telefono != null) Telefono = telefono;
            if (cuit != null) Cuit = cuit;

            Con_Proveedor.update_proveedor_byid(Id, Nombre, Telefono, Cuit);


            return this;

        }

        public static Proveedor GetById(int ID)
        {
            DataRow DR = Con_Proveedor.select_byid_proveedores(ID);
            if (DR != null)
            {
                
                    
                
                return new Proveedor(DR);
            }
            else
            {
                return null;
            }
        }



    }
}
