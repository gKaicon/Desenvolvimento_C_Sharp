﻿namespace ClassesFusca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.textAro = new System.Windows.Forms.TextBox();
            this.textCor = new System.Windows.Forms.TextBox();
            this.textcorP = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.vel = new System.Windows.Forms.Label();
            this.gear = new System.Windows.Forms.Label();
            this.Ligar = new System.Windows.Forms.Button();
            this.maisVel = new System.Windows.Forms.Button();
            this.menosVel = new System.Windows.Forms.Button();
            this.menosMarcha = new System.Windows.Forms.Button();
            this.maisMarcha = new System.Windows.Forms.Button();
            this.textVidro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFusca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cor Parachoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Velocidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marcha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Criar Fusca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(68, 30);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(100, 20);
            this.textPlaca.TabIndex = 8;
            // 
            // textAro
            // 
            this.textAro.Location = new System.Drawing.Point(68, 55);
            this.textAro.Name = "textAro";
            this.textAro.Size = new System.Drawing.Size(100, 20);
            this.textAro.TabIndex = 9;
            // 
            // textCor
            // 
            this.textCor.Location = new System.Drawing.Point(68, 81);
            this.textCor.Name = "textCor";
            this.textCor.Size = new System.Drawing.Size(100, 20);
            this.textCor.TabIndex = 10;
            // 
            // textcorP
            // 
            this.textcorP.Location = new System.Drawing.Point(118, 107);
            this.textcorP.Name = "textcorP";
            this.textcorP.Size = new System.Drawing.Size(100, 20);
            this.textcorP.TabIndex = 11;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(75, 219);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(13, 13);
            this.estado.TabIndex = 12;
            this.estado.Text = "_";
            // 
            // vel
            // 
            this.vel.AutoSize = true;
            this.vel.Location = new System.Drawing.Point(94, 246);
            this.vel.Name = "vel";
            this.vel.Size = new System.Drawing.Size(13, 13);
            this.vel.TabIndex = 13;
            this.vel.Text = "_";
            // 
            // gear
            // 
            this.gear.AutoSize = true;
            this.gear.Location = new System.Drawing.Point(78, 271);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(13, 13);
            this.gear.TabIndex = 14;
            this.gear.Text = "_";
            // 
            // Ligar
            // 
            this.Ligar.Location = new System.Drawing.Point(310, 214);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(75, 23);
            this.Ligar.TabIndex = 15;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // maisVel
            // 
            this.maisVel.Location = new System.Drawing.Point(251, 246);
            this.maisVel.Name = "maisVel";
            this.maisVel.Size = new System.Drawing.Size(77, 23);
            this.maisVel.TabIndex = 16;
            this.maisVel.Text = "+ velocidade";
            this.maisVel.UseVisualStyleBackColor = true;
            this.maisVel.Click += new System.EventHandler(this.maisVel_Click);
            // 
            // menosVel
            // 
            this.menosVel.Location = new System.Drawing.Point(334, 246);
            this.menosVel.Name = "menosVel";
            this.menosVel.Size = new System.Drawing.Size(75, 23);
            this.menosVel.TabIndex = 17;
            this.menosVel.Text = "- velocidade";
            this.menosVel.UseVisualStyleBackColor = true;
            this.menosVel.Click += new System.EventHandler(this.menosVel_Click);
            // 
            // menosMarcha
            // 
            this.menosMarcha.Location = new System.Drawing.Point(334, 275);
            this.menosMarcha.Name = "menosMarcha";
            this.menosMarcha.Size = new System.Drawing.Size(75, 23);
            this.menosMarcha.TabIndex = 19;
            this.menosMarcha.Text = "- marcha";
            this.menosMarcha.UseVisualStyleBackColor = true;
            this.menosMarcha.Click += new System.EventHandler(this.menosMarcha_Click);
            // 
            // maisMarcha
            // 
            this.maisMarcha.Location = new System.Drawing.Point(251, 275);
            this.maisMarcha.Name = "maisMarcha";
            this.maisMarcha.Size = new System.Drawing.Size(77, 23);
            this.maisMarcha.TabIndex = 18;
            this.maisMarcha.Text = "+ marcha";
            this.maisMarcha.UseVisualStyleBackColor = true;
            this.maisMarcha.Click += new System.EventHandler(this.maisMarcha_Click);
            // 
            // textVidro
            // 
            this.textVidro.Location = new System.Drawing.Point(89, 133);
            this.textVidro.Name = "textVidro";
            this.textVidro.Size = new System.Drawing.Size(100, 20);
            this.textVidro.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo Vidro:";
            // 
            // labelFusca
            // 
            this.labelFusca.AutoSize = true;
            this.labelFusca.Location = new System.Drawing.Point(271, 30);
            this.labelFusca.Name = "labelFusca";
            this.labelFusca.Size = new System.Drawing.Size(0, 13);
            this.labelFusca.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.labelFusca);
            this.Controls.Add(this.textVidro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menosMarcha);
            this.Controls.Add(this.maisMarcha);
            this.Controls.Add(this.menosVel);
            this.Controls.Add(this.maisVel);
            this.Controls.Add(this.Ligar);
            this.Controls.Add(this.gear);
            this.Controls.Add(this.vel);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.textcorP);
            this.Controls.Add(this.textCor);
            this.Controls.Add(this.textAro);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textAro;
        private System.Windows.Forms.TextBox textCor;
        private System.Windows.Forms.TextBox textcorP;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label vel;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.Button Ligar;
        private System.Windows.Forms.Button maisVel;
        private System.Windows.Forms.Button menosVel;
        private System.Windows.Forms.Button menosMarcha;
        private System.Windows.Forms.Button maisMarcha;
        private System.Windows.Forms.TextBox textVidro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFusca;
    }
}

