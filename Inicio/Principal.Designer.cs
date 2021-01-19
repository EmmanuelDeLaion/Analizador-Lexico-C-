namespace AnalizadorLexico
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txterrores = new System.Windows.Forms.RichTextBox();
            this.abrirArchivo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTokens = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Resultados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoEntrada = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 38);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AnalizadorLexico.Properties.Resources.Maximizar;
            this.pictureBox2.Location = new System.Drawing.Point(898, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::AnalizadorLexico.Properties.Resources.LOGO_LETRAS;
            this.pictureBox4.Location = new System.Drawing.Point(34, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::AnalizadorLexico.Properties.Resources.Ultra_HD_3;
            this.pictureBox3.Location = new System.Drawing.Point(4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.min;
            this.pictureBox1.Location = new System.Drawing.Point(868, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::AnalizadorLexico.Properties.Resources.tacha2;
            this.pictureBox5.Location = new System.Drawing.Point(926, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txterrores);
            this.panel2.Controls.Add(this.abrirArchivo);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnTokens);
            this.panel2.Controls.Add(this.Resultados);
            this.panel2.Controls.Add(this.textoEntrada);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 523);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txterrores
            // 
            this.txterrores.AcceptsTab = true;
            this.txterrores.AccessibleDescription = "";
            this.txterrores.AccessibleName = "";
            this.txterrores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txterrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txterrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txterrores.Font = new System.Drawing.Font("Burbank Big Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterrores.ForeColor = System.Drawing.Color.Black;
            this.txterrores.Location = new System.Drawing.Point(25, 426);
            this.txterrores.Name = "txterrores";
            this.txterrores.Size = new System.Drawing.Size(602, 70);
            this.txterrores.TabIndex = 29;
            this.txterrores.Text = "";
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.abrirArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.abrirArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.abrirArchivo.BorderRadius = 0;
            this.abrirArchivo.ButtonText = "ABRIR ARCHIVO";
            this.abrirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abrirArchivo.DisabledColor = System.Drawing.Color.Gray;
            this.abrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirArchivo.Iconcolor = System.Drawing.Color.Transparent;
            this.abrirArchivo.Iconimage = null;
            this.abrirArchivo.Iconimage_right = null;
            this.abrirArchivo.Iconimage_right_Selected = null;
            this.abrirArchivo.Iconimage_Selected = null;
            this.abrirArchivo.IconMarginLeft = 0;
            this.abrirArchivo.IconMarginRight = 0;
            this.abrirArchivo.IconRightVisible = true;
            this.abrirArchivo.IconRightZoom = 0D;
            this.abrirArchivo.IconVisible = true;
            this.abrirArchivo.IconZoom = 90D;
            this.abrirArchivo.IsTab = false;
            this.abrirArchivo.Location = new System.Drawing.Point(102, 23);
            this.abrirArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.abrirArchivo.Name = "abrirArchivo";
            this.abrirArchivo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.abrirArchivo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.abrirArchivo.OnHoverTextColor = System.Drawing.Color.White;
            this.abrirArchivo.selected = false;
            this.abrirArchivo.Size = new System.Drawing.Size(85, 26);
            this.abrirArchivo.TabIndex = 25;
            this.abrirArchivo.Text = "ABRIR ARCHIVO";
            this.abrirArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abrirArchivo.Textcolor = System.Drawing.Color.White;
            this.abrirArchivo.TextFont = new System.Drawing.Font("Burbank Big Condensed", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirArchivo.Click += new System.EventHandler(this.abrirArchivo_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ActiveBorderThickness = 1;
            this.btnBorrar.ActiveCornerRadius = 20;
            this.btnBorrar.ActiveFillColor = System.Drawing.Color.White;
            this.btnBorrar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnBorrar.ActiveLineColor = System.Drawing.Color.White;
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.ButtonText = "BORRAR";
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Burbank Big Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.IdleBorderThickness = 1;
            this.btnBorrar.IdleCornerRadius = 20;
            this.btnBorrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnBorrar.IdleForecolor = System.Drawing.Color.White;
            this.btnBorrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnBorrar.Location = new System.Drawing.Point(510, 10);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(117, 39);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Burbank Big Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(652, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "SALIDA:";
            // 
            // btnTokens
            // 
            this.btnTokens.ActiveBorderThickness = 1;
            this.btnTokens.ActiveCornerRadius = 20;
            this.btnTokens.ActiveFillColor = System.Drawing.Color.White;
            this.btnTokens.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnTokens.ActiveLineColor = System.Drawing.Color.White;
            this.btnTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTokens.BackColor = System.Drawing.Color.White;
            this.btnTokens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTokens.BackgroundImage")));
            this.btnTokens.ButtonText = "TOKENS";
            this.btnTokens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTokens.Font = new System.Drawing.Font("Burbank Big Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTokens.ForeColor = System.Drawing.Color.White;
            this.btnTokens.IdleBorderThickness = 1;
            this.btnTokens.IdleCornerRadius = 20;
            this.btnTokens.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnTokens.IdleForecolor = System.Drawing.Color.White;
            this.btnTokens.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnTokens.Location = new System.Drawing.Point(817, 6);
            this.btnTokens.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnTokens.Name = "btnTokens";
            this.btnTokens.Size = new System.Drawing.Size(117, 39);
            this.btnTokens.TabIndex = 18;
            this.btnTokens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTokens.Click += new System.EventHandler(this.btnTokens_Click);
            // 
            // Resultados
            // 
            this.Resultados.AllowUserToAddRows = false;
            this.Resultados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Resultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Resultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultados.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Resultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Burbank Big Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Resultados.DoubleBuffered = true;
            this.Resultados.EnableHeadersVisualStyles = false;
            this.Resultados.HeaderBgColor = System.Drawing.Color.DarkRed;
            this.Resultados.HeaderForeColor = System.Drawing.Color.White;
            this.Resultados.Location = new System.Drawing.Point(656, 48);
            this.Resultados.Name = "Resultados";
            this.Resultados.ReadOnly = true;
            this.Resultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Resultados.Size = new System.Drawing.Size(278, 448);
            this.Resultados.TabIndex = 15;
            // 
            // Column1
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Burbank Big Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column1.HeaderText = "TOKENS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Burbank Big Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column2.HeaderText = "LEXEMA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // textoEntrada
            // 
            this.textoEntrada.AcceptsTab = true;
            this.textoEntrada.AccessibleDescription = "";
            this.textoEntrada.AccessibleName = "";
            this.textoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoEntrada.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEntrada.ForeColor = System.Drawing.Color.White;
            this.textoEntrada.Location = new System.Drawing.Point(25, 52);
            this.textoEntrada.Name = "textoEntrada";
            this.textoEntrada.Size = new System.Drawing.Size(602, 368);
            this.textoEntrada.TabIndex = 11;
            this.textoEntrada.Text = "";
            this.textoEntrada.TextChanged += new System.EventHandler(this.textoEntrada_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Burbank Big Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ENTRADA:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(963, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textoEntrada;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Resultados;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBorrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTokens;
        private Bunifu.Framework.UI.BunifuFlatButton abrirArchivo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.RichTextBox txterrores;
    }
}