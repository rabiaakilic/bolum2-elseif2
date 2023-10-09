namespace bolum_2_if_else
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
            this.btnTıkla = new System.Windows.Forms.Button();
            this.cbSari = new System.Windows.Forms.CheckBox();
            this.cbKirmizi = new System.Windows.Forms.CheckBox();
            this.lblYaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.Location = new System.Drawing.Point(100, 27);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(114, 44);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "button1";
            this.btnTıkla.UseVisualStyleBackColor = true;
            this.btnTıkla.Click += new System.EventHandler(this.btnTıkla_Click);
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSari.Location = new System.Drawing.Point(100, 100);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(53, 24);
            this.cbSari.TabIndex = 1;
            this.cbSari.Text = "sarı";
            this.cbSari.UseVisualStyleBackColor = true;
            // 
            // cbKirmizi
            // 
            this.cbKirmizi.AutoSize = true;
            this.cbKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKirmizi.Location = new System.Drawing.Point(100, 131);
            this.cbKirmizi.Name = "cbKirmizi";
            this.cbKirmizi.Size = new System.Drawing.Size(71, 24);
            this.cbKirmizi.TabIndex = 2;
            this.cbKirmizi.Text = "kırmızı";
            this.cbKirmizi.UseVisualStyleBackColor = true;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.Location = new System.Drawing.Point(100, 176);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(99, 20);
            this.lblYaz.TabIndex = 3;
            this.lblYaz.Text = "__________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.cbKirmizi);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.btnTıkla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTıkla;
        private System.Windows.Forms.CheckBox cbSari;
        private System.Windows.Forms.CheckBox cbKirmizi;
        private System.Windows.Forms.Label lblYaz;
    }
}

