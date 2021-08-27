
namespace Bolillero
{
    partial class Fcarton
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
            this.btSortear = new System.Windows.Forms.Button();
            this.btElegir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSortear
            // 
            this.btSortear.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btSortear.Location = new System.Drawing.Point(12, 47);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(101, 37);
            this.btSortear.TabIndex = 0;
            this.btSortear.Text = "Sortear Carton";
            this.btSortear.UseVisualStyleBackColor = true;
            // 
            // btElegir
            // 
            this.btElegir.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btElegir.Location = new System.Drawing.Point(12, 4);
            this.btElegir.Name = "btElegir";
            this.btElegir.Size = new System.Drawing.Size(101, 37);
            this.btElegir.TabIndex = 1;
            this.btElegir.Text = "Elegir Numeros";
            this.btElegir.UseVisualStyleBackColor = true;
            // 
            // Fcarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 88);
            this.Controls.Add(this.btElegir);
            this.Controls.Add(this.btSortear);
            this.Name = "Fcarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fcarton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSortear;
        public System.Windows.Forms.Button btElegir;
    }
}