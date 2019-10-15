using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public static class Con_Articulo
    {
        public static DataRow selectbyid(int id)
        {
            GestionComercioDataSet.SELECT_BYID_ARTICULODataTable DT = new GestionComercioDataSet.SELECT_BYID_ARTICULODataTable();
            GestionComercioDataSetTableAdapters.SELECT_BYID_ARTICULOTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_BYID_ARTICULOTableAdapter();
            TA.Fill(DT, id);
            if (DT.Rows.Count > 0)
            {
                return DT.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static DataRow insertarticulo(
            string Nombre,
            string Codigo,
            int idProveedor,
            int idUnidad,
            decimal Stock,
            decimal PrecioBruto,
            decimal Iva,
            decimal PrecioNeto,
            decimal PorcentageGanancia,
            decimal PrecioFinal
            )
        {
            GestionComercioDataSet.INSERT_ARTICULODataTable DT = new GestionComercioDataSet.INSERT_ARTICULODataTable();
            GestionComercioDataSetTableAdapters.INSERT_ARTICULOTableAdapter TA = new GestionComercioDataSetTableAdapters.INSERT_ARTICULOTableAdapter();
            TA.Fill(DT, Nombre, Codigo, idProveedor,idUnidad, Stock,PrecioBruto,Iva,PrecioNeto,PorcentageGanancia,PrecioFinal, true);
            if (DT.Rows.Count > 0)
            {
                return DT.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static DataTable select_bynombre_articulos(string nombre)
        {
            GestionComercioDataSet.SELECT_BYNOMBRE_ARTICULODataTable DT = new GestionComercioDataSet.SELECT_BYNOMBRE_ARTICULODataTable();
            GestionComercioDataSetTableAdapters.SELECT_BYNOMBRE_ARTICULOTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_BYNOMBRE_ARTICULOTableAdapter();
            TA.Fill(DT, nombre);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else
            {
                return null;
            }
        }

        

    }
}
