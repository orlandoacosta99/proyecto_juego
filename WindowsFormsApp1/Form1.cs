using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salir(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void limparDatos(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox1, this, groupBox2);
        }
       
        // metodos Codificador
        private void textCodificar(object sender, EventArgs e)
        {

        }
         private void letrapista1(object sender, EventArgs e)
        {

        }
         private void buttonCodificar(object sender, EventArgs e)
        {

        }

         private void datosCodificados(object sender, EventArgs e)
        {

        }

        // metodos Decodificar

        private void textDecodificar(object sender, EventArgs e)
        {

        }
      
        private void buttonDecodificar(object sender, EventArgs e)
        {

        }
        private void letrapista2(object sender, EventArgs e)
        {

        }
         private void datosDecodificados(object sender, EventArgs e)
        {

        }
        // pantilla 

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }       

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }      

        private void comboBox1(object sender, EventArgs e)
        {

        }

        private void comboBox2(object sender, EventArgs e)
        {

        }
    }
}
