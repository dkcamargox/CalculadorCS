﻿namespace Calculador
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDC = new System.Windows.Forms.Button();
            this.btRserie = new System.Windows.Forms.Button();
            this.btRparalelo = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btPolRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADOR DA LEI DE OHM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU PRINCIPAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDC
            // 
            this.btDC.Location = new System.Drawing.Point(137, 152);
            this.btDC.Name = "btDC";
            this.btDC.Size = new System.Drawing.Size(75, 23);
            this.btDC.TabIndex = 2;
            this.btDC.Text = "Lei de Ohm";
            this.btDC.UseVisualStyleBackColor = true;
            this.btDC.Click += new System.EventHandler(this.BtDC_Click);
            // 
            // btRserie
            // 
            this.btRserie.Location = new System.Drawing.Point(137, 252);
            this.btRserie.Name = "btRserie";
            this.btRserie.Size = new System.Drawing.Size(75, 23);
            this.btRserie.TabIndex = 5;
            this.btRserie.Text = "Série DC";
            this.btRserie.UseVisualStyleBackColor = true;
            this.btRserie.Click += new System.EventHandler(this.BtRserie_Click);
            // 
            // btRparalelo
            // 
            this.btRparalelo.Location = new System.Drawing.Point(137, 203);
            this.btRparalelo.Name = "btRparalelo";
            this.btRparalelo.Size = new System.Drawing.Size(75, 23);
            this.btRparalelo.TabIndex = 6;
            this.btRparalelo.Text = "Paralelo DC";
            this.btRparalelo.UseVisualStyleBackColor = true;
            this.btRparalelo.Click += new System.EventHandler(this.BtRparalelo_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(390, 252);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // btPolRec
            // 
            this.btPolRec.Location = new System.Drawing.Point(251, 152);
            this.btPolRec.Name = "btPolRec";
            this.btPolRec.Size = new System.Drawing.Size(121, 23);
            this.btPolRec.TabIndex = 15;
            this.btPolRec.Text = "Polar para Retangular";
            this.btPolRec.UseVisualStyleBackColor = true;
            this.btPolRec.Click += new System.EventHandler(this.BtPolRec_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.Controls.Add(this.btPolRec);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btRparalelo);
            this.Controls.Add(this.btRserie);
            this.Controls.Add(this.btDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador da Lei de Ohm";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDC;
        private System.Windows.Forms.Button btRserie;
        private System.Windows.Forms.Button btRparalelo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btPolRec;
    }
}
