using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerWinform
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

      

       

        private void bnt_boton1_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            lblSaludar.Text = "HOLA " + texto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string elemento = txtElemento.Text;
            lvListado.Items.Add(elemento);
            txtElemento.Clear();



        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCV.Text;
            DateTime fecharda = dtpFecha.Value.Date;
            //operador ternario 
            string humano = chbPregunta.Checked == true ? "si, e humanoide" : "no, eh human";
            string color;
            if (rbBlanco.Checked == true) color = "blanco";
            else if (rbRojo.Checked == true) color = "rojo";
            else color = "NEGRONCIO "; 

            string numero = cbNumeros.SelectedItem.ToString();

            MessageBox.Show("SE chiama: " + nombre + " naceu : " + fecharda + "  é humnoide? "+ humano + "  le gusta el rosa? " + color + "  numerolo de la suertela " + numero);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            cbNumeros.Items.Add("1");
            cbNumeros.Items.Add("2");
            cbNumeros.Items.Add("3");
            cbNumeros.Items.Add("4");

        }
    }
}
