using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormaDePagoDatarow
    {
        bool percent = false;
        int idformapago = 0;
        int idarticulo = 0;
        decimal value = 0;

        public bool ISPERCENT { get => percent; }
        public int IDFORMAPAGO { get => idformapago; }
        public decimal VALUE { get => value; }
        public int IDARTICULO { get => idarticulo; }

        public static List<FormaDePagoDatarow> GetByIdArt(int idART)
        {
            DataTable dt = Connection.Con_FormaDePago.SelectFormasPagoByIdArticulo(idART);
            if (dt != null)
            {
                List<FormaDePagoDatarow> L = new List<FormaDePagoDatarow>();
                foreach (DataRow dr in dt.Rows)
                {
                    L.Add(new FormaDePagoDatarow(dr));

                }
                return L;
            }
            else
            {
                return null;
            }
        }

        public FormaDePago GetFormaDePago()
        {
            return FormaDePago.GetById(idformapago);
        }

        private FormaDePagoDatarow(DataRow dr)
        {
            percent = bool.Parse(dr["isPercent"].ToString());
            idformapago = int.Parse(dr["IdFormaPago"].ToString());
            idarticulo = int.Parse(dr["IdArticulo"].ToString());
            value = decimal.Parse(dr["value"].ToString());
        }

        public void LinkToArticle(int idart)
        {
            Connection.Con_FormaDePago.InsertFormaPago_Articulo(idart,idformapago,percent,value);
            idarticulo = idart;
        }

        public FormaDePagoDatarow(bool per, int idfp, decimal val)
        {
            percent = per;
            idformapago = idfp;
            value = val;
        }

    }
}
