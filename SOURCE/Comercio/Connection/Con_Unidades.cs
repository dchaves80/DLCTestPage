using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public static class Con_Unidades
    {
        public static int insert_unidad(string NombreUnidad, string Simbolo)
        {
            GestionComercioDataSetTableAdapters.INSERT_UNIDADESTableAdapter TA = new GestionComercioDataSetTableAdapters.INSERT_UNIDADESTableAdapter();
            GestionComercioDataSet.INSERT_UNIDADESDataTable DT = new GestionComercioDataSet.INSERT_UNIDADESDataTable();
            if (TA.Fill(DT,NombreUnidad,Simbolo) > 0)
            {
                return int.Parse(DT.Rows[0][0].ToString());
            }
            else { return -1; }
        }


        public static DataTable select_all_unidades()
        {
            GestionComercioDataSet.SELECT_ALL_UNIDADESDataTable DT = new GestionComercioDataSet.SELECT_ALL_UNIDADESDataTable();
            GestionComercioDataSetTableAdapters.SELECT_ALL_UNIDADESTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_ALL_UNIDADESTableAdapter();
            TA.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                return DT;
            } else
            {
                return null;
            }
        }

        public static DataRow select_byid_unidad(int Id)
        {
            GestionComercioDataSet.SELECT_BYID_UNIDADESDataTable DT = new GestionComercioDataSet.SELECT_BYID_UNIDADESDataTable();
            GestionComercioDataSetTableAdapters.SELECT_BYID_UNIDADESTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_BYID_UNIDADESTableAdapter();
            TA.Fill(DT, Id);
            if (DT.Rows.Count > 0)
            {
                return DT.Rows[0];
            }
            else
            {
                return null;
            }


        }

    }
}
