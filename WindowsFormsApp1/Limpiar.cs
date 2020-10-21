using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Limpiar
    {
        public void BorrarCampos(Control control, GroupBox gb, Control control1, GroupBox gb1)
        {
            foreach (var ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                   ((TextBox)ctrl).Clear();
                }
                else if (ctrl is  ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = 0;
                }
            }
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = -1;
                }
            }
            foreach (var ctrl1 in control1.Controls)
            {
                if (ctrl1 is TextBox)
                {
                    ((TextBox)ctrl1).Clear();
                }
                else if (ctrl1 is ComboBox)
                {
                    ((ComboBox)ctrl1).SelectedIndex = 0;
                }
            }
            foreach (var combo1 in gb1.Controls)
            {
                if (combo1 is TextBox)
                {
                    ((TextBox)combo1).Clear();
                }
                else if (combo1 is ComboBox)
                {
                    ((ComboBox)combo1).SelectedIndex = -1;
                }
            }
        }
    }
}
