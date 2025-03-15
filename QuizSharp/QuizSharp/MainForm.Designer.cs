/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 02/05/2024
 * Time: 19:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuizSharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button B;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button D;
		private System.Windows.Forms.Label labelPergunta;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label labelPontos;
		private System.Windows.Forms.Button buttonReiniciar;
		private System.Windows.Forms.Label labelD;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button A;
		private System.Windows.Forms.Button resultados;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label labeltitulo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.labeltitulo = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelD = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.B = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.D = new System.Windows.Forms.Button();
			this.labelPergunta = new System.Windows.Forms.Label();
			this.A = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.labelPontos = new System.Windows.Forms.Label();
			this.buttonReiniciar = new System.Windows.Forms.Button();
			this.resultados = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.labeltitulo);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelD);
			this.panel1.Controls.Add(this.labelC);
			this.panel1.Controls.Add(this.labelB);
			this.panel1.Controls.Add(this.labelA);
			this.panel1.Controls.Add(this.B);
			this.panel1.Controls.Add(this.C);
			this.panel1.Controls.Add(this.D);
			this.panel1.Controls.Add(this.labelPergunta);
			this.panel1.Controls.Add(this.A);
			this.panel1.Location = new System.Drawing.Point(11, 8);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(746, 246);
			this.panel1.TabIndex = 0;
			// 
			// labeltitulo
			// 
			this.labeltitulo.AutoSize = true;
			this.labeltitulo.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltitulo.ForeColor = System.Drawing.Color.DarkGreen;
			this.labeltitulo.Location = new System.Drawing.Point(226, 12);
			this.labeltitulo.Name = "labeltitulo";
			this.labeltitulo.Size = new System.Drawing.Size(307, 36);
			this.labeltitulo.TabIndex = 14;
			this.labeltitulo.Text = "Quiz do Charada";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Location = new System.Drawing.Point(517, 40);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(180, 175);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(639, -2);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(221, 256);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// labelD
			// 
			this.labelD.AutoSize = true;
			this.labelD.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelD.ForeColor = System.Drawing.Color.Gold;
			this.labelD.Location = new System.Drawing.Point(86, 196);
			this.labelD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelD.Name = "labelD";
			this.labelD.Size = new System.Drawing.Size(20, 19);
			this.labelD.TabIndex = 11;
			this.labelD.Text = "?";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelC.ForeColor = System.Drawing.Color.Gold;
			this.labelC.Location = new System.Drawing.Point(86, 147);
			this.labelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(20, 19);
			this.labelC.TabIndex = 10;
			this.labelC.Text = "?";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelB.ForeColor = System.Drawing.Color.Gold;
			this.labelB.Location = new System.Drawing.Point(86, 97);
			this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(20, 19);
			this.labelB.TabIndex = 9;
			this.labelB.Text = "?";
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelA.ForeColor = System.Drawing.Color.Gold;
			this.labelA.Location = new System.Drawing.Point(86, 50);
			this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(20, 19);
			this.labelA.TabIndex = 8;
			this.labelA.Text = "?";
			// 
			// B
			// 
			this.B.BackColor = System.Drawing.Color.Gold;
			this.B.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B.Location = new System.Drawing.Point(13, 88);
			this.B.Margin = new System.Windows.Forms.Padding(2);
			this.B.Name = "B";
			this.B.Size = new System.Drawing.Size(59, 38);
			this.B.TabIndex = 7;
			this.B.Text = "B";
			this.B.UseVisualStyleBackColor = false;
			this.B.Click += new System.EventHandler(this.BClick);
			// 
			// C
			// 
			this.C.BackColor = System.Drawing.Color.Gold;
			this.C.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C.Location = new System.Drawing.Point(13, 137);
			this.C.Margin = new System.Windows.Forms.Padding(2);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(59, 38);
			this.C.TabIndex = 6;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = false;
			this.C.Click += new System.EventHandler(this.CClick);
			// 
			// D
			// 
			this.D.BackColor = System.Drawing.Color.Gold;
			this.D.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.D.Location = new System.Drawing.Point(13, 187);
			this.D.Margin = new System.Windows.Forms.Padding(2);
			this.D.Name = "D";
			this.D.Size = new System.Drawing.Size(59, 38);
			this.D.TabIndex = 5;
			this.D.Text = "D";
			this.D.UseVisualStyleBackColor = false;
			this.D.Click += new System.EventHandler(this.DClick);
			// 
			// labelPergunta
			// 
			this.labelPergunta.AutoSize = true;
			this.labelPergunta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPergunta.ForeColor = System.Drawing.Color.DarkViolet;
			this.labelPergunta.Location = new System.Drawing.Point(2, 0);
			this.labelPergunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPergunta.Name = "labelPergunta";
			this.labelPergunta.Size = new System.Drawing.Size(0, 19);
			this.labelPergunta.TabIndex = 4;
			// 
			// A
			// 
			this.A.BackColor = System.Drawing.Color.Gold;
			this.A.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A.Location = new System.Drawing.Point(13, 40);
			this.A.Margin = new System.Windows.Forms.Padding(2);
			this.A.Name = "A";
			this.A.Size = new System.Drawing.Size(59, 38);
			this.A.TabIndex = 0;
			this.A.Text = "A";
			this.A.UseVisualStyleBackColor = false;
			this.A.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkViolet;
			this.button1.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(29, 257);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 29);
			this.button1.TabIndex = 8;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DarkViolet;
			this.button2.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(107, 257);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 29);
			this.button2.TabIndex = 9;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkViolet;
			this.button3.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(180, 257);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 29);
			this.button3.TabIndex = 10;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DarkViolet;
			this.button4.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(253, 257);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(59, 29);
			this.button4.TabIndex = 11;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DarkViolet;
			this.button5.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(325, 257);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(59, 29);
			this.button5.TabIndex = 12;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DarkViolet;
			this.button6.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(397, 257);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(59, 29);
			this.button6.TabIndex = 13;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.DarkViolet;
			this.button7.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(466, 257);
			this.button7.Margin = new System.Windows.Forms.Padding(2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(59, 29);
			this.button7.TabIndex = 14;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.DarkViolet;
			this.button8.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(535, 257);
			this.button8.Margin = new System.Windows.Forms.Padding(2);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(59, 29);
			this.button8.TabIndex = 15;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.DarkViolet;
			this.button9.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(607, 257);
			this.button9.Margin = new System.Windows.Forms.Padding(2);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(59, 29);
			this.button9.TabIndex = 16;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.DarkViolet;
			this.button10.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(677, 257);
			this.button10.Margin = new System.Windows.Forms.Padding(2);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(59, 29);
			this.button10.TabIndex = 17;
			this.button10.Text = "10";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// labelPontos
			// 
			this.labelPontos.AutoSize = true;
			this.labelPontos.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPontos.ForeColor = System.Drawing.Color.Black;
			this.labelPontos.Location = new System.Drawing.Point(26, 293);
			this.labelPontos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPontos.Name = "labelPontos";
			this.labelPontos.Size = new System.Drawing.Size(97, 19);
			this.labelPontos.TabIndex = 8;
			this.labelPontos.Text = "Pontos:0";
			// 
			// buttonReiniciar
			// 
			this.buttonReiniciar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonReiniciar.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReiniciar.ForeColor = System.Drawing.Color.Black;
			this.buttonReiniciar.Location = new System.Drawing.Point(253, 293);
			this.buttonReiniciar.Margin = new System.Windows.Forms.Padding(2);
			this.buttonReiniciar.Name = "buttonReiniciar";
			this.buttonReiniciar.Size = new System.Drawing.Size(111, 29);
			this.buttonReiniciar.TabIndex = 18;
			this.buttonReiniciar.Text = "Reiniciar";
			this.buttonReiniciar.UseVisualStyleBackColor = false;
			this.buttonReiniciar.Click += new System.EventHandler(this.ButtonReiniciarClick);
			// 
			// resultados
			// 
			this.resultados.BackColor = System.Drawing.Color.LightSteelBlue;
			this.resultados.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultados.ForeColor = System.Drawing.Color.Black;
			this.resultados.Location = new System.Drawing.Point(397, 293);
			this.resultados.Margin = new System.Windows.Forms.Padding(2);
			this.resultados.Name = "resultados";
			this.resultados.Size = new System.Drawing.Size(111, 29);
			this.resultados.TabIndex = 19;
			this.resultados.Text = "Resultados";
			this.resultados.UseVisualStyleBackColor = false;
			this.resultados.Click += new System.EventHandler(this.ResultadosClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.ClientSize = new System.Drawing.Size(768, 328);
			this.Controls.Add(this.resultados);
			this.Controls.Add(this.buttonReiniciar);
			this.Controls.Add(this.labelPontos);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "QuizSharp";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
