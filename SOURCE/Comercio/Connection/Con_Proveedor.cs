using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public static class Con_Proveedor
    {

        public static DataTable select_top_proveedores(int count)
        {
            GestionComercioDataSet.SELECT_TOP_PROVEEDORESDataTable DT = new GestionComercioDataSet.SELECT_TOP_PROVEEDORESDataTable();
            GestionComercioDataSetTableAdapters.SELECT_TOP_PROVEEDORESTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_TOP_PROVEEDORESTableAdapter();
            TA.Fill(DT,count);
            if (DT.Rows.Count > 0)
            {
                return DT;
            }
            else
            {
                return null;
            }

        }

        public static DataTable select_all_proveedores()
        {
            GestionComercioDataSet.SELECT_ALL_PROVEEDORESDataTable DT = new GestionComercioDataSet.SELECT_ALL_PROVEEDORESDataTable();
            GestionComercioDataSetTableAdapters.SELECT_ALL_PROVEEDORESTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_ALL_PROVEEDORESTableAdapter();
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

        public static void update_proveedor_byid(int Id, string Nombre, string Telefono, string CUIT)
        {
            GestionComercioDataSetTableAdapters.QueriesTableAdapter QTA = new GestionComercioDataSetTableAdapters.QueriesTableAdapter();
            QTA.UPDATE_PROVEEDOR(Id, Nombre, Telefono, CUIT);
        }

        public static DataRow select_byid_proveedores(int Id)
        {
                GestionComercioDataSet.SELECT_BYID_PROVEEDORESDataTable DT = new GestionComercioDataSet.SELECT_BYID_PROVEEDORESDataTable();
                GestionComercioDataSetTableAdapters.SELECT_BYID_PROVEEDORESTableAdapter TA = new GestionComercioDataSetTableAdapters.SELECT_BYID_PROVEEDORESTableAdapter();
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
        public static DataRow insert_proveedor(string nombre = null, string telefono = null, string cuit = null)
        {
            GestionComercioDataSet.INSERT_PROVEEDORDataTable DT = new GestionComercioDataSet.INSERT_PROVEEDORDataTable();
            GestionComercioDataSetTableAdapters.INSERT_PROVEEDORTableAdapter TA = new GestionComercioDataSetTableAdapters.INSERT_PROVEEDORTableAdapter();
            TA.Fill(DT, nombre, telefono, cuit);
            return DT.Rows[0];


            
        }

    }
}
