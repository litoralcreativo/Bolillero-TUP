
namespace Bolillero
{
    partial class Loteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loteria));
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.numericUdJugadores = new System.Windows.Forms.NumericUpDown();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brInicio = new System.Windows.Forms.Button();
            this.gbSorteo = new System.Windows.Forms.GroupBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.lbrestantes = new System.Windows.Forms.Label();
            this.btSortear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUdJugadores)).BeginInit();
            this.gbSorteo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.BackColor = System.Drawing.Color.Transparent;
            this.gbInicio.Controls.Add(this.numericUdJugadores);
            this.gbInicio.Controls.Add(this.tbNombre);
            this.gbInicio.Controls.Add(this.label2);
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Controls.Add(this.brInicio);
            this.gbInicio.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbInicio.Location = new System.Drawing.Point(13, 10);
            this.gbInicio.Margin = new System.Windows.Forms.Padding(4);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Padding = new System.Windows.Forms.Padding(4);
            this.gbInicio.Size = new System.Drawing.Size(287, 337);
            this.gbInicio.TabIndex = 0;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio";
            // 
            // numericUdJugadores
            // 
            this.numericUdJugadores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUdJugadores.Location = new System.Drawing.Point(179, 104);
            this.numericUdJugadores.Margin = new System.Windows.Forms.Padding(4);
            this.numericUdJugadores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUdJugadores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUdJugadores.Name = "numericUdJugadores";
            this.numericUdJugadores.Size = new System.Drawing.Size(80, 26);
            this.numericUdJugadores.TabIndex = 4;
            this.numericUdJugadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUdJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNombre.Location = new System.Drawing.Point(81, 42);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 26);
            this.tbNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de Jugadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // brInicio
            // 
            this.brInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brInicio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.brInicio.Location = new System.Drawing.Point(81, 184);
            this.brInicio.Margin = new System.Windows.Forms.Padding(4);
            this.brInicio.Name = "brInicio";
            this.brInicio.Size = new System.Drawing.Size(117, 66);
            this.brInicio.TabIndex = 2;
            this.brInicio.Text = "Iniciar";
            this.brInicio.UseVisualStyleBackColor = false;
            this.brInicio.Click += new System.EventHandler(this.brInicio_Click);
            // 
            // gbSorteo
            // 
            this.gbSorteo.BackColor = System.Drawing.Color.Transparent;
            this.gbSorteo.Controls.Add(this.btReiniciar);
            this.gbSorteo.Controls.Add(this.lbrestantes);
            this.gbSorteo.Controls.Add(this.btSortear);
            this.gbSorteo.Controls.Add(this.listBox1);
            this.gbSorteo.Enabled = false;
            this.gbSorteo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbSorteo.Location = new System.Drawing.Point(315, 11);
            this.gbSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.gbSorteo.Name = "gbSorteo";
            this.gbSorteo.Padding = new System.Windows.Forms.Padding(4);
            this.gbSorteo.Size = new System.Drawing.Size(792, 336);
            this.gbSorteo.TabIndex = 1;
            this.gbSorteo.TabStop = false;
            this.gbSorteo.Text = "Sorteo";
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btReiniciar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btReiniciar.Location = new System.Drawing.Point(542, 258);
            this.btReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(117, 66);
            this.btReiniciar.TabIndex = 3;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Visible = false;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // lbrestantes
            // 
            this.lbrestantes.AutoSize = true;
            this.lbrestantes.ForeColor = System.Drawing.Color.Black;
            this.lbrestantes.Location = new System.Drawing.Point(299, 279);
            this.lbrestantes.Name = "lbrestantes";
            this.lbrestantes.Size = new System.Drawing.Size(184, 24);
            this.lbrestantes.TabIndex = 2;
            this.lbrestantes.Text = "Bolillas Restantes: -";
            // 
            // btSortear
            // 
            this.btSortear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSortear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btSortear.Location = new System.Drawing.Point(667, 258);
            this.btSortear.Margin = new System.Windows.Forms.Padding(4);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(117, 66);
            this.btSortear.TabIndex = 1;
            this.btSortear.Text = "Sortear";
            this.btSortear.UseVisualStyleBackColor = false;
            this.btSortear.Click += new System.EventHandler(this.btSortear_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(9, 29);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(775, 220);
            this.listBox1.TabIndex = 0;
            // 
            // Loteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1120, 364);
            this.Controls.Add(this.gbSorteo);
            this.Controls.Add(this.gbInicio);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Loteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loteria";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUdJugadores)).EndInit();
            this.gbSorteo.ResumeLayout(false);
            this.gbSorteo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.NumericUpDown numericUdJugadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brInicio;
        private System.Windows.Forms.Button btSortear;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.GroupBox gbSorteo;
        public System.Windows.Forms.Label lbrestantes;
        public System.Windows.Forms.GroupBox gbInicio;
        public System.Windows.Forms.Button btReiniciar;
    }
}

