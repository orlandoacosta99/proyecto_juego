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
        Codificador codificar = new Codificador();
        Decodificador decodificar= new Decodificador();

        public Form1()
        {
            InitializeComponent();
        }

        private void salir(object sender, EventArgs e)
        {	
	        MessageBox.Show("Seguro que desea salir?");
            this.Close();
        }

        private void limparDatos(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox1, this, groupBox2);
        }

        

        // datos de codificador
  

        private void textCodificar_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCodificar_Click(object sender, EventArgs e)
        {
           
          

        }
        private void labeldatosCodificados(object sender, EventArgs e)
        {

        }
        private void labelCodificados_decimal(object sender, EventArgs e)
        {

        }


        // Datos decodificar
        private void textDecodificar_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonDecodificar_Click(object sender, EventArgs e)
        {

        }
        private void labelDecodificados(object sender, EventArgs e)
        {

        }

        // Datos text del formulario


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
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
   

        
    }
}
