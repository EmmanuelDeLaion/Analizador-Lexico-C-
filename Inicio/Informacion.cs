using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();

        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            datosTabla();
        }


        public void datosTabla()
        {
            DataGridViewRow filas = new DataGridViewRow(); 

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
   
}
