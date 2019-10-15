using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace Balanza
{
    public static class SQLiteConnector
    {

        const string Insert_Camion = "insert into Camiones(Patente) values ('[Patente]')";
        const string Insert_Cliente = "insert into Clientes(Nombre) values ('[Nombre]')";
        const string Insert_Producto = "insert into Productos(Nombre) values ('[Nombre]')";
        const string Insert_Chofer = "insert into Choferes(Nombre) values ('[Nombre]')";
        const string Insert_RegistroBalanza = "insert into RegistrosBalanza(Fecha,Hora,IdCamion,IdChofer,IdChofer,IdCliente,IdProducto) values ('[Fecha]','[Hora]',[IdCamion],[IdChofer],[IdChofer],[IdCliente],[IdProducto])";
        const string Get_AllRegistroBalanza = "select * from RegistrosBalanza";
        const string Get_LastRegistroBalanza = "select Id from RegistrosBalanza order by Id Desc LIMIT 1";
        const string Get_RegistroBalanzaById = "select * from RegistrosBalanza Where Id = [Id]";
        const string Get_CamionById = "select * from Camiones Where Id=[Id]";
        const string Get_ChoferById = "select * from Choferes Where Id=[Id]";
        const string Get_ClienteById = "select * from Clientes Where Id=[Id]";
        const string Get_ProductoById = "select * from Productos Where Id=[Id]";
        const string Get_AllCamiones = "select * from Camiones";
        const string Get_AllChoferes = "select * from Choferes";
        const string Get_AllClientes = "select * from Clientes";
        const string Get_AllProductos = "select * from Productos";
        const string Get_Configuration = "Select Valor from Configuracion where Nombre='[Nombre]'";
        const string Update_RegistroBalanzaBruto = "Update RegistrosBalanza set Bruto=[Bruto], TBruto=[TBruto] where Id=[Id]";
        const string Update_RegistroBalanzaTara = "Update RegistrosBalanza set Tara=[Tara], TBruto=[TTara] where Id=[Id]";
        const string Update_RegistroBalanzaNeto = "Update RegistrosBalanza set Neto=[Neto] where Id=[Id]";
        const string Update_RegistroBalanzaHumedad = "Update RegistrosBalanza set Humedad=[Humedad] where Id=[Id]";
        const string Update_Configuracion = "Update Configuracion set Valor='[Valor]' where Nombre='[Nombre]'";
        const string Delete_ResgistroBalanza = "Delete from RegistrosBalanza";




        private static void Ejecutar(string p_Command)
        {
           
            IDbConnection C = new SQLiteConnection("DataSource=.\\數據庫.db;Version=3");
            C.Open();
            IDbCommand Command = C.CreateCommand();
            Command.CommandText = p_Command;
            Command.ExecuteNonQuery();
            C.Close();
        }

        public static void BorrarRegistros()
        {
            string cmd = Delete_ResgistroBalanza;
            Ejecutar(cmd);
        }

        public static void UpdateConfiguracion(string key, string value)
        {
            string cmd;
            cmd = Update_Configuracion.Replace("[Nombre]", key).Replace("[Valor]",value);
            Ejecutar(cmd);
            
        }

        public static string GetConfiguration(string Key)
        {
            string cmd;
            cmd = Get_Configuration.Replace("[Nombre]", Key);
            List<Dictionary<String,String>> MyList = EjecutarConsulta(cmd);
            if (MyList != null && MyList.Count > 0)
            {
                return MyList[0]["Valor"];
            }
            else
            {
                return null;
            }
        }

        public static Dictionary<String, String> Seleccionar_CamionById(int id)
        {
            Dictionary<String, String> D = new Dictionary<string, string>();
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_CamionById.Replace("[Id]", id.ToString()));
            if (L != null)
            {
                return L[0];
            }
            else
            {
                return null;
            }
        }


        public static void Actualizar_Bruto(int Id, int Bruto, int Tbruto)
        {
            string cmd;
            cmd = Update_RegistroBalanzaBruto.Replace("[Bruto]", Bruto.ToString());
            cmd = cmd.Replace("[TBruto]", Tbruto.ToString());
            cmd = cmd.Replace("[Id]", Id.ToString());
            Ejecutar(cmd);

        }

        public static void Actualizar_Neto(int Id, int Neto)
        {
            string cmd;
            cmd = Update_RegistroBalanzaNeto.Replace("[Neto]", Neto.ToString());
            cmd = cmd.Replace("[Id]", Id.ToString());
            Ejecutar(cmd);

        }

        public static void Actualizar_Humedad(int Id, int Humedad)
        {
            string cmd;
            cmd = Update_RegistroBalanzaHumedad.Replace("[Humedad]", Humedad.ToString());
            cmd = cmd.Replace("[Id]", Id.ToString());
            Ejecutar(cmd);

        }

        public static void Actualizar_Tara(int Id, int Tara, int Ttara)
        {
            string cmd;
            cmd = Update_RegistroBalanzaTara.Replace("[Tara]", Tara.ToString());
            cmd = cmd.Replace("[TTara]", Ttara.ToString());
            cmd = cmd.Replace("[Id]", Id.ToString());
            Ejecutar(cmd);

        }
        public static Dictionary<String, String> Seleccionar_ChoferById(int id)
        {
            Dictionary<String, String> D = new Dictionary<string, string>();
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_ChoferById.Replace("[Id]", id.ToString()));
            if (L != null)
            {
                return L[0];
            }
            else
            {
                return null;
            }
        }

        public static Dictionary<String, String> Seleccionar_ClienteById(int id)
        {
            Dictionary<String, String> D = new Dictionary<string, string>();
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_ClienteById.Replace("[Id]", id.ToString()));
            if (L != null)
            {
                return L[0];
            }
            else
            {
                return null;
            }
        }

        public static Dictionary<String, String> Seleccionar_ProductoById(int id)
        {
            Dictionary<String, String> D = new Dictionary<string, string>();
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_ProductoById.Replace("[Id]", id.ToString()));
            if (L != null)
            {
                return L[0];
            }
            else
            {
                return null;
            }
        }



        private static List<Dictionary<String,String>> EjecutarConsulta(string p_Command)
        {

            SQLiteConnection C = new SQLiteConnection("DataSource=.\\數據庫.db;Version=3");
            C.Open();
            SQLiteCommand Command = C.CreateCommand();
            Command.CommandText = p_Command;

            List<Dictionary<String,String>> L = new List<Dictionary<String,String>>();

            SQLiteDataReader R = Command.ExecuteReader();

            while (R.Read())
            {
                L.Add(new Dictionary<string, string>());
                for (int a = 0; a < R.FieldCount; a++)
                {
                    L[L.Count-1].Add(R.GetName(a),R[a].ToString());
                }
            }



            C.Close();
            if (L.Count > 0)
            {
                return L;
            }
            else
            {
                return null;
            }
        }

        

        public static int Seleccionar_IdUltimoPeso()
        {
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_LastRegistroBalanza);
            if (L != null)
            {
                return int.Parse(L[0]["Id"]);
            }
            else
            {
                return 0;
            }
        }

        public static Modelos.Modelo_Peso Seleccionar_PesosById(int Id)
        {
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_RegistroBalanzaById.Replace("[Id]",Id.ToString()));
            if (L != null)
            {
                return new Modelos.Modelo_Peso(L[0]);
            }
            else
            {
                return null;
            }
        }

        public static List<Dictionary<String,String>> Seleccionar_TodosLosCamiones()
        {
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_AllCamiones);
            if (L != null)
            {
                return L;
            }
            else
            {
                return null;
            }
        }

        public static List<Dictionary<String, String>> Seleccionar_TodosLosChoferes()
        {
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_AllChoferes);
            if (L != null)
            {
                return L;
            }
            else
            {
                return null;
            }
        }

        public static List<Dictionary<String, String>> Seleccionar_TodosLosClientes()
        {
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_AllClientes);
            if (L != null)
            {
                return L;
            }
            else
            {
                return null;
            }
        }
        public static List<Dictionary<String, String>> Seleccionar_TodosLosProductos()
        {
            List<Dictionary<String, String>> L = EjecutarConsulta(Get_AllProductos);
            if (L != null)
            {
                return L;
            }
            else
            {
                return null;
            }
        }



        public static List<Modelos.Modelo_Peso> Seleccionar_TodosLosPesos()
        {
            List<Dictionary<String,String>> L = EjecutarConsulta(Get_AllRegistroBalanza);

            if (L != null)
            {
                List<Modelos.Modelo_Peso> lp = new List<Modelos.Modelo_Peso>();
                foreach (Dictionary<String,String> i in L)
                {
                    Modelos.Modelo_Peso p = new Modelos.Modelo_Peso(i);
                    lp.Add(p);
                }
                return lp;

            }
            else
            {
                return null;
            }


        }

        public static int AgregarPeso(Modelos.Modelo_Peso p)
        {
            string cmd = Insert_RegistroBalanza;
            cmd = cmd.Replace("[Fecha]", Tools.DateTimeToSQLiteDate(p.HORAYFECHA));
            cmd = cmd.Replace("[Hora]", Tools.DateTimeToSQLiteTime(p.HORAYFECHA));
            cmd = cmd.Replace("[IdCamion]", p.IDCAMION.ToString());
            cmd = cmd.Replace("[IdChofer]", p.IDCHOFER.ToString());
            cmd = cmd.Replace("[IdCliente]", p.IDCLIENTE.ToString());
            cmd = cmd.Replace("[IdProducto]", p.IDPRODUCTO.ToString());
            Ejecutar(cmd);
            return Seleccionar_IdUltimoPeso();
        }

        public static void AgregarChofer(string Nombre)
        {
            string cmd;
            cmd = Insert_Chofer.Replace("[Nombre]", Nombre);
            Ejecutar(cmd);
        }

        public static void AgregarProducto(string Nombre)
        {
            string cmd;
            cmd = Insert_Producto.Replace("[Nombre]", Nombre);
            Ejecutar(cmd);
        }

        public static void AgregarCliente(string Nombre)
        {
            string cmd;
            cmd = Insert_Cliente.Replace("[Nombre]", Nombre);
            Ejecutar(cmd);
        }

        public static void AgregarCamion(string Patente)
        {
            string cmd;
            cmd = Insert_Camion.Replace("[Patente]", Patente);
            Ejecutar(cmd);
        }

    }
}
