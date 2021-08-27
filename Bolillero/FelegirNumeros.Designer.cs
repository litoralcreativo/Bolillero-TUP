
namespace Bolillero
{
    partial class FelegirNumeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero del 1 al 90:";
            // 
            // tbNumero
            // 
            this.tbNumero.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tbNumero.Cursor = System.Windows.Forms.Cursors.No;
            this.tbNumero.Location = new System.Drawing.Point(184, 10);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(39, 23);
            this.tbNumero.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAgregar.Location = new System.Drawing.Point(13, 39);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(210, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // FelegirNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 71);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label1);
            this.Name = "FelegirNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FelegirNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btAgregar;
        public System.Windows.Forms.TextBox tbNumero;
    }
}