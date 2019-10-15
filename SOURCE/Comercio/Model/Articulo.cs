using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Articulo
    {
        int id;
        string nombre;
        string codigo;
        int idproveedor;
        decimal stock;
        bool habilitado;
        public Unidad unidad;
        decimal preciobruto;
        decimal iva;
        decimal precioneto;
        decimal porcentajeganancia;
        decimal preciofinal;

        public int ID { get => id; }
        public string NOMBRE { get => nombre; }
        public string CODIGO { get => codigo; }
        public decimal STOCK { get => stock; }
        public bool HABILITADO { get => habilitado; }
        public Unidad UNIDAD { get => unidad; }
        public decimal PRECIOBRUTO { get => preciobruto; }
        public decimal IVA { get => iva; }
        public decimal PRECIONETO { get => precioneto; }
        public decimal PORCENTAJEGANANCIA { get => porcentajeganancia; }
        public decimal PRECIOFINAL { get => preciofinal; }
        public int IDPROVEEDOR { get => idproveedor; }



        private Articulo(DataRow a)
        {
            id = int.Parse(a["Id"].ToString());
            nombre = a["Nombre"].ToString();
            codigo = a["Codigo"].ToString();
            idproveedor = int.Parse(a["IdProveedor"].ToString());
            stock = decimal.Parse(a["Stock"].ToString());
            habilitado = a["Habilitado"].ToString() == "True";
            unidad = Unidad.GetById(int.Parse(a["IdUnidad"].ToString()));
            preciobruto = decimal.Parse(a["PrecioBruto"].ToString());
            iva = decimal.Parse(a["Iva"].ToString());
            precioneto = decimal.Parse(a["PrecioNeto"].ToString());
            porcentajeganancia = decimal.Parse(a["PorcentageGanancia"].ToString());
            preciofinal = decimal.Parse(a["PrecioFinal"].ToString());
         
        }

        public static Articulo NewArticle(
            string pnombre,
            string pcodigo,
            int pidunidad,
            int pidproveedor,
            decimal pstock,
            decimal preciobruto,
            decimal iva,
            decimal precioneto,
            decimal porcentajeganancia,
            decimal preciofinal,
            List<FormaDePagoDatarow> formasDePago = null)
        {
            DataRow dr = Connection.Con_Articulo.insertarticulo(pnombre, pcodigo, pidproveedor, pidunidad, pstock,preciobruto,iva,precioneto,porcentajeganancia,preciofinal);

            Articulo a = new Articulo(dr);

            if (formasDePago != null && formasDePago.Count > 0)
            {
                foreach (FormaDePagoDatarow f in formasDePago)
                {
                    f.LinkToArticle(a.ID);
                }
            }
            
            return new Articulo(dr);
        }

        public static List<Articulo> SelectByName(string name)
        {
            DataTable dt = Connection.Con_Articulo.select_bynombre_articulos(name);
            if (dt != null)
            {
                List<Articulo> ArticleList = new List<Articulo>();
                foreach (DataRow dr in dt.Rows)
                {
                    ArticleList.Add(new Articulo(dr));
                }
                return ArticleList;
            }
            else
            {
                return null;
            }
        }

        public static Articulo getById(int ID)
        {
            DataRow dr = Connection.Con_Articulo.selectbyid(ID);
            if (dr != null)
            {
                return new Articulo(dr);
            }
            else
            {
                return null;
            }
        }

        public void BorrarFormasDePago()
        {
            Connection.Con_FormaDePago.deleteformasdepagoarticulo(id);
        }

     

        

    }
}
