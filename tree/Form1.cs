using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace tree
{
    public partial class Form1 : MetroForm
    {
        //nombramos a los registros del usuario como item 
        ListViewItem Item;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            //boton resumen
            Form2 Form2 = new Form2();
            //muestra el formulario 2
            Form2.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Item != null)
            {
                lvDetalle.Items.Remove(Item);

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvDetalle.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //boton ver
            var Vendedor = new vendedor();
            //muestra el contenido de cada caja en 4 textos
            string nombre = this.txtNombre.Text;//recolecta
            //this.lblNombre.Text = "Nombre: " + " " + nombre.ToString();//muestra
            

            //copiamos los datos que el usuario ingresa hacia el listView 
            ListViewItem Registrar = new ListViewItem(txtNombre.Text);
            Registrar.SubItems.Add(txtNumero.Text);
            Registrar.SubItems.Add(txtMonto.Text);
          
            Registrar.SubItems.Add(time.Text);

            //importante! para registrar todo
            lvDetalle.Items.Add(Registrar);

            

            //limpiamos los texbox para que el usuario pueda ingresar mas registros
            txtNombre.Clear();
            txtNumero.Clear();
           
        }
    }
}
