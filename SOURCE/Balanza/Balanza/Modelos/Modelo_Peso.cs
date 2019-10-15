using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Balanza.Modelos
{
    public class Modelo_Peso
    {

        
        int Id=0;
        DateTime HoraYFecha;
        int IdChofer = 0;
        int IdCamion = 0;
        int IdProducto = 0;
        int IdCliente = 0;
        long Bruto=0;
        long Tara=0;
        long Neto=0;
        Decimal Humedad=0;
        long TBruto = 0;
        long TTara = 0;

        public int ID { get => Id; }
        public DateTime HORAYFECHA { get => HoraYFecha; }
        public int IDCHOFER { get => IdChofer; }
        public int IDCAMION { get => IdCamion; }
        public int IDPRODUCTO { get => IdProducto; }
        public int IDCLIENTE { get => IdCliente; }
        public long BRUTO { get => Bruto; }
        public long TARA { get => Tara; }
        public long NETO { get => Neto; }
        public Decimal HUMEDAD { get => Humedad; }
        public long TBRUTO { get => TBruto; }
        public long TTARA { get => TTara; }

        public Modelo_Peso(Dictionary<String,String> i)
        {
            Id = int.Parse(i["Id"]);
            IdCamion = int.Parse(i["IdCamion"]);
            IdChofer = int.Parse(i["IdChofer"]);
            IdCliente = int.Parse(i["IdCliente"]);
            IdProducto = int.Parse(i["IdProducto"]);
            HoraYFecha = Tools.SQLiteDateTimeToDateTime(i["Fecha"], i["Hora"]);
            if (i["Bruto"]!="") Bruto=int.Parse(i["Bruto"]);
            if (i["Tara"] != "") Tara = int.Parse(i["Tara"]);
            if (i["Neto"] != "") Neto = int.Parse(i["Neto"]);
            if (i["TBruto"] != "") TBruto = int.Parse(i["TBruto"]);
            if (i["TTara"] != "") TTara = int.Parse(i["TTara"]);
            if (i["Humedad"] != "") Humedad = Decimal.Parse(i["Humedad"]);

        }

        

        public Modelo_Peso(int idchofer,int idcamion, int idproducto, int idcliente)
        {
            IdChofer = idchofer;
            IdCamion = idcamion;
            IdProducto = idproducto;
            IdCliente = idcliente;
            HoraYFecha = DateTime.Now;
            Id = SQLiteConnector.AgregarPeso(this);
        }

        

        public void Guardar()
        {
            if (Id == 0)
            {

            }
        }

    }
}
