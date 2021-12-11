
namespace FormApp5_
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
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.lBoxOgrenciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(391, 336);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(94, 29);
            this.btnOgrenciEkle.TabIndex = 0;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // lBoxOgrenciler
            // 
            this.lBoxOgrenciler.FormattingEnabled = true;
            this.lBoxOgrenciler.ItemHeight = 20;
            this.lBoxOgrenciler.Location = new System.Drawing.Point(48, 41);
            this.lBoxOgrenciler.Name = "lBoxOgrenciler";
            this.lBoxOgrenciler.Size = new System.Drawing.Size(284, 324);
            this.lBoxOgrenciler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 398);
            this.Controls.Add(this.lBoxOgrenciler);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkle;
        public System.Windows.Forms.ListBox lBoxOgrenciler;
    }
}

