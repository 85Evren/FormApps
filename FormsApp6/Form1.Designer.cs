
namespace FormsApp6
{
    partial class Form1
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
            this.btnEkrem = new System.Windows.Forms.Button();
            this.btnFurkan = new System.Windows.Forms.Button();
            this.btnBahar = new System.Windows.Forms.Button();
            this.lboxIsimler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkrem
            // 
            this.btnEkrem.Location = new System.Drawing.Point(103, 45);
            this.btnEkrem.Name = "btnEkrem";
            this.btnEkrem.Size = new System.Drawing.Size(94, 29);
            this.btnEkrem.TabIndex = 0;
            this.btnEkrem.Text = "ekrem";
            this.btnEkrem.UseVisualStyleBackColor = true;
            this.btnEkrem.Click += new System.EventHandler(this.btnEkrem_Click);
            // 
            // btnFurkan
            // 
            this.btnFurkan.Location = new System.Drawing.Point(233, 45);
            this.btnFurkan.Name = "btnFurkan";
            this.btnFurkan.Size = new System.Drawing.Size(94, 29);
            this.btnFurkan.TabIndex = 1;
            this.btnFurkan.Text = "Furkan";
            this.btnFurkan.UseVisualStyleBackColor = true;
            this.btnFurkan.Click += new System.EventHandler(this.btnEkrem_Click);
            // 
            // btnBahar
            // 
            this.btnBahar.Location = new System.Drawing.Point(360, 43);
            this.btnBahar.Name = "btnBahar";
            this.btnBahar.Size = new System.Drawing.Size(94, 29);
            this.btnBahar.TabIndex = 2;
            this.btnBahar.Text = "Bahar";
            this.btnBahar.UseVisualStyleBackColor = true;
            this.btnBahar.Click += new System.EventHandler(this.btnEkrem_Click);
            // 
            // lboxIsimler
            // 
            this.lboxIsimler.FormattingEnabled = true;
            this.lboxIsimler.ItemHeight = 20;
            this.lboxIsimler.Location = new System.Drawing.Point(103, 105);
            this.lboxIsimler.Name = "lboxIsimler";
            this.lboxIsimler.Size = new System.Drawing.Size(358, 244);
            this.lboxIsimler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.lboxIsimler);
            this.Controls.Add(this.btnBahar);
            this.Controls.Add(this.btnFurkan);
            this.Controls.Add(this.btnEkrem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkrem;
        private System.Windows.Forms.Button btnFurkan;
        private System.Windows.Forms.Button btnBahar;
        private System.Windows.Forms.ListBox lboxIsimler;
    }
}

