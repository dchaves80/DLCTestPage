using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public static class Con_FormaDePago
    {
        public static DataTable GetFormaDePago()
        {
            GestionComercioDataSet.SELECT_ALL_FORMASDEPAGODataTable DT = new GestionComercioDataSet.SELECT_ALL_FORMASDEPAGODataTable();
            GestionComercioDataSetTableAdapters.SELECT_ALL_FORMASDEPAGOTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_ALL_FORMASDEPAGOTableAdapter();
            TA.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else
            {
                return null;
            }

        }

        public static DataRow GetFormaDePagoByID(int id)
        {
            GestionComercioDataSet.SELECT_BYID_FORMADEPAGODataTable DT = new GestionComercioDataSet.SELECT_BYID_FORMADEPAGODataTable();
            GestionComercioDataSetTableAdapters.SELECT_BYID_FORMADEPAGOTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_BYID_FORMADEPAGOTableAdapter();
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

        public static int InsertFormaPago_Articulo(int idarticulo, int idformapago, bool percent, decimal value)
        {
            GestionComercioDataSetTableAdapters.INSERT_FORMAPAGOARTICULOTableAdapter TA = new GestionComercioDataSetTableAdapters.INSERT_FORMAPAGOARTICULOTableAdapter();
            GestionComercioDataSet.INSERT_FORMAPAGOARTICULODataTable DT = new GestionComercioDataSet.INSERT_FORMAPAGOARTICULODataTable();
            TA.Fill(DT,idarticulo,idformapago,percent,value);
            if (DT.Rows.Count > 0)
            {
                return int.Parse(DT.Rows[0]["Id"].ToString());
            }
            else
            {
                return -1;
            }
        }

        public static int InsertFormaDePago(string Nombre)
        {
            GestionComercioDataSet.INSERT_FORMADEPAGODataTable DT = new GestionComercioDataSet.INSERT_FORMADEPAGODataTable();
            GestionComercioDataSetTableAdapters.INSERT_FORMADEPAGOTableAdapter TA = new GestionComercioDataSetTableAdapters.INSERT_FORMADEPAGOTableAdapter();
            TA.Fill(DT, Nombre);
            if (DT.Rows.Count > 0)
            {
                return int.Parse(DT.Rows[0][0].ToString());
            }
            else
            {
                return -1;
            }
        }

        public static void deleteformasdepagoarticulo(int idarticulo)
        {
            GestionComercioDataSetTableAdapters.QueriesTableAdapter qta = new GestionComercioDataSetTableAdapters.QueriesTableAdapter();
            qta.DELETE_BYIDARTICULO_FORMAPAGOARTICULO(idarticulo);
        }

        public static DataTable SelectFormasPagoByIdArticulo(int IdArticulo)
        {
            GestionComercioDataSet.SELECT_BYIDARTICULO_FORMASPAGOARTICULOSDataTable DT = new GestionComercioDataSet.SELECT_BYIDARTICULO_FORMASPAGOARTICULOSDataTable();
            GestionComercioDataSetTableAdapters.SELECT_BYIDARTICULO_FORMASPAGOARTICULOSTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_BYIDARTICULO_FORMASPAGOARTICULOSTableAdapter();
            TA.Fill(DT, IdArticulo);
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
