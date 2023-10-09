namespace radio_button_if_else_renk_1550
{
    partial class Form1
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
            this.rbMor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.rbSari = new System.Windows.Forms.RadioButton();
            this.renkDegistir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMor
            // 
            this.rbMor.AutoSize = true;
            this.rbMor.Location = new System.Drawing.Point(21, 35);
            this.rbMor.Name = "rbMor";
            this.rbMor.Size = new System.Drawing.Size(42, 17);
            this.rbMor.TabIndex = 0;
            this.rbMor.TabStop = true;
            this.rbMor.Text = "mor";
            this.rbMor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.renkDegistir);
            this.groupBox1.Controls.Add(this.rbSari);
            this.groupBox1.Controls.Add(this.rbMavi);
            this.groupBox1.Controls.Add(this.rbKirmizi);
            this.groupBox1.Controls.Add(this.rbMor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "renkler";
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Location = new System.Drawing.Point(21, 58);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(53, 17);
            this.rbKirmizi.TabIndex = 1;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Location = new System.Drawing.Point(21, 82);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(47, 17);
            this.rbMavi.TabIndex = 2;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            // 
            // rbSari
            // 
            this.rbSari.AutoSize = true;
            this.rbSari.Location = new System.Drawing.Point(21, 105);
            this.rbSari.Name = "rbSari";
            this.rbSari.Size = new System.Drawing.Size(41, 17);
            this.rbSari.TabIndex = 3;
            this.rbSari.TabStop = true;
            this.rbSari.Text = "sarı";
            this.rbSari.UseVisualStyleBackColor = true;
            // 
            // renkDegistir
            // 
            this.renkDegistir.Location = new System.Drawing.Point(21, 155);
            this.renkDegistir.Name = "renkDegistir";
            this.renkDegistir.Size = new System.Drawing.Size(75, 23);
            this.renkDegistir.TabIndex = 2;
            this.renkDegistir.Text = "renk değistir";
            this.renkDegistir.UseVisualStyleBackColor = true;
            this.renkDegistir.Click += new System.EventHandler(this.renkDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSari;
        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.Button renkDegistir;
    }
}

