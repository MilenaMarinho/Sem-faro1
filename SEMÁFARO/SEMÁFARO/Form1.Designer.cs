namespace SEMÁFARO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picRua1 = new System.Windows.Forms.PictureBox();
            this.picRua2 = new System.Windows.Forms.PictureBox();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua2 = new System.Windows.Forms.Label();
            this.lblRua1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).BeginInit();
            this.SuspendLayout();
            // 
            // picRua1
            // 
            this.picRua1.Image = global::SEMÁFARO.Properties.Resources.GREEN;
            this.picRua1.Location = new System.Drawing.Point(286, 111);
            this.picRua1.Name = "picRua1";
            this.picRua1.Size = new System.Drawing.Size(106, 267);
            this.picRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRua1.TabIndex = 0;
            this.picRua1.TabStop = false;
            this.picRua1.Click += new System.EventHandler(this.picRua1_Click);
            // 
            // picRua2
            // 
            this.picRua2.Image = global::SEMÁFARO.Properties.Resources.RED;
            this.picRua2.Location = new System.Drawing.Point(12, 111);
            this.picRua2.Name = "picRua2";
            this.picRua2.Size = new System.Drawing.Size(106, 267);
            this.picRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRua2.TabIndex = 1;
            this.picRua2.TabStop = false;
            this.picRua2.Click += new System.EventHandler(this.picRua2_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(139, 141);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(126, 46);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "VERMELHO";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(139, 220);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(126, 46);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "AMARELO";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(139, 303);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(126, 46);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.Text = "VERDE";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(139, 67);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(126, 20);
            this.txtRua.TabIndex = 5;
            // 
            // lblRua2
            // 
            this.lblRua2.AutoSize = true;
            this.lblRua2.Location = new System.Drawing.Point(40, 70);
            this.lblRua2.Name = "lblRua2";
            this.lblRua2.Size = new System.Drawing.Size(45, 13);
            this.lblRua2.TabIndex = 6;
            this.lblRua2.Text = "RUA 02";
            // 
            // lblRua1
            // 
            this.lblRua1.AutoSize = true;
            this.lblRua1.Location = new System.Drawing.Point(316, 70);
            this.lblRua1.Name = "lblRua1";
            this.lblRua1.Size = new System.Drawing.Size(45, 13);
            this.lblRua1.TabIndex = 7;
            this.lblRua1.Text = "RUA 01";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(203, 30);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 403);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblRua1);
            this.Controls.Add(this.lblRua2);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.picRua2);
            this.Controls.Add(this.picRua1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SEMÁFARO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRua1;
        private System.Windows.Forms.PictureBox picRua2;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua2;
        private System.Windows.Forms.Label lblRua1;
        private System.Windows.Forms.Label lblEstado;
    }
}

