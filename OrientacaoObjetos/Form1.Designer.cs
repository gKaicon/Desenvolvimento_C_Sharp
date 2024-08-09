namespace OrientacaoObjetos
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS EMPREGADOS";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(154, 129);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 5;
            button1.Text = "ATUALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 78);
            label3.Name = "label3";
            label3.Size = new Size(15, 17);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(129, 78);
            trackBar1.Maximum = 90;
            trackBar1.Minimum = 16;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(157, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 16;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 25);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 1;
            label2.Text = "Qual a sua idade?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 0;
            label1.Text = "Qual o seu nome?";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(46, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS EMPREGADO ATUALIZADOS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 72);
            label7.Name = "label7";
            label7.Size = new Size(23, 17);
            label7.TabIndex = 8;
            label7.Text = ".....";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 44);
            label6.Name = "label6";
            label6.Size = new Size(23, 17);
            label6.TabIndex = 7;
            label6.Text = ".....";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(154, 100);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 6;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 72);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 2;
            label5.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 44);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 1;
            label4.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 400);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TrackBar trackBar1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
    }
}
