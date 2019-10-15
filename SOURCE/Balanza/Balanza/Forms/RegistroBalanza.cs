using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Balanza.Forms
{
    

    public partial class RegistroBalanza : Form
    {
        public RegistroBalanza()
        {
            InitializeComponent();
        }


        private bool CargarComboBoxes()
        {
            List<Dictionary<String, String>> Camiones = SQLiteConnector.Seleccionar_TodosLosCamiones();
            if (Camiones == null) { return false; }
            List<Dictionary<String, String>> Choferes = SQLiteConnector.Seleccionar_TodosLosChoferes();
            if (Choferes == null) { return false; }
            List<Dictionary<String, String>> Clientes = SQLiteConnector.Seleccionar_TodosLosClientes();
            if (Clientes == null) { return false; }
            List<Dictionary<String, String>> Productos = SQLiteConnector.Seleccionar_TodosLosProductos();
            if (Productos == null) { return false; }

            //lleno comboboxes
            cmbCamion.DisplayMember = "Name";
            cmbCamion.ValueMember = "Id";
            foreach (Dictionary<String, String> S in Camiones)
            {
                cmbCamion.Items.Add(new Modelos.Item(S["Patente"], S["Id"]));
            }
            cmbCamion.Sorted = true;

            cmbChofer.DisplayMember = "Name";
            cmbChofer.ValueMember = "Id";
            foreach (Dictionary<String, String> S in Choferes)
            {
                cmbChofer.Items.Add(new Modelos.Item(S["Nombre"], S["Id"]));
            }
            cmbChofer.Sorted = true;

            cmbCliente.DisplayMember = "Name";
            cmbCliente.ValueMember = "Id";
            foreach (Dictionary<String, String> S in Clientes)
            {
                cmbCliente.Items.Add(new Modelos.Item(S["Nombre"], S["Id"]));
            }
            cmbCliente.Sorted = true;

            cmbProducto.DisplayMember = "Name";
            cmbProducto.ValueMember = "Id";
            foreach (Dictionary<String, String> S in Productos)
            {
                cmbProducto.Items.Add(new Modelos.Item(S["Nombre"], S["Id"]));
            }
            cmbProducto.Sorted = true;


            return true;
        }

        private void RegistroBalanza_Load(object sender, EventArgs e)
        {
            if (CargarComboBoxes() == false)
            {
                MessageBox.Show("Error Faltan Registros", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
                new Modelos.Modelo_Peso(
                    int.Parse((cmbChofer.SelectedItem as Modelos.Item).Id.ToString()), 
                    int.Parse((cmbCamion.SelectedItem as Modelos.Item).Id.ToString()), 
                    int.Parse((cmbProducto.SelectedItem as Modelos.Item).Id.ToString()), 
                    int.Parse((cmbCliente.SelectedItem as Modelos.Item).Id.ToString())
                );
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
