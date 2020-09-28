namespace Calculadora
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Cuadro_ayuda = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // Cuadro_ayuda
            // 
            this.Cuadro_ayuda.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.Cuadro_ayuda, "Cuadro_ayuda");
            this.Cuadro_ayuda.Name = "Cuadro_ayuda";
            // 
            // Ayuda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Cuadro_ayuda);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.Name = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Cuadro_ayuda;
    }
}