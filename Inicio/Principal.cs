using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using AnalizadorLexico.Analizador;

namespace AnalizadorLexico
{
    public partial class Principal : Form
    {

        Lexico AnalizarCodigo = new Lexico();
        public Principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Principal_Load(object sender, EventArgs e)
        {
        }


        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Informacion abririNFO = new Informacion();
            abririNFO.Hide();

            Inicio abrirPantallaCarga = new Inicio();
            abrirPantallaCarga.Show();
            this.Hide();
            
        }


        private void btnTokens_Click(object sender, EventArgs e)
        {
            Informacion abririNFO = new Informacion();
            abririNFO.Show();
        }



        private void textoEntrada_TextChanged(object sender, EventArgs e)
        {
            AnalizarCodigo.Inicia();
            AnalizarCodigo.AnalizarTexto(textoEntrada.Text);
            Resultados.Rows.Clear();
            if (AnalizarCodigo.NoTokens > 0)
                Resultados.Rows.Add(AnalizarCodigo.NoTokens);
            for (int i = 0; i < AnalizarCodigo.NoTokens; i++)
            {
                Resultados.Rows[i].Cells[0].Value = AnalizarCodigo.Token[i];
                Resultados.Rows[i].Cells[1].Value = AnalizarCodigo.Lexema[i];
            }
            if (textoEntrada.Text == "")
            {
                textoEntrada.Text = "";
                Resultados.Rows.Clear();
                txterrores.Text = "";
            }


            txterrores.Text = "";
            sintactico.imprimirerrores = "";
            bool resultado = sintactico.Parse(textoEntrada.Text);
            string textoResultado;
            if (resultado)
            {
                txterrores.ForeColor = Color.White;
                textoResultado = "No se encontraron errores";
            }
            else
            {
                txterrores.ForeColor = Color.Red;
                textoResultado = sintactico.imprimirerrores;
            }
            txterrores.Text = textoResultado;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textoEntrada.Text = "";
            Resultados.Rows.Clear();
            txterrores.Text = "";

        }
       
        private void abrirArchivo_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;
                Process proceso = new Process();
                proceso.StartInfo.FileName = @"";
                TextReader leer = new StreamReader(direccion);
                MessageBox.Show("La ruta es: \n" + direccion);
                textoEntrada.LoadFile(abrir.FileName, RichTextBoxStreamType.PlainText);
            }
        }  

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
           
        }

        public void cambiarColor()
        { 
            string[] palabrasReservadas = {
                "booleano",
                "romper",
                "caso",
                "capturar",
                "caracter",
                "clase",
                "constante",
                "doble",
                "sino",
                "extender",
                "final",
                "finalmente",
                "flotante",
                "para","si",
                "importar", 
                "entero",
                "largo",
                "nuevo",
                "paquete",
                "privado",
                "publico",
                "retornar", 
                "cadena",
                "cambiar",
                "tratar",
                "vacio",
                "mientras",
                "estatico",
                "imprimir",
                "escaner",
                "sistema"
            };


        }

        public void errores_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnAnalizar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

        }
    }




}


