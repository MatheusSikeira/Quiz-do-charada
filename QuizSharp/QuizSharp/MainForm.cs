
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizSharp
{
	
	public partial class MainForm : Form
	{
		public MainForm()// método construtor
		{
			
			InitializeComponent();
			pictureBox2.Visible = false;
			
		}
			
			//variaveis globais
			string alternativaCorreta = "x";
			int pontos = 0;
			string nomeImagem = "charada.png";
			string erroImagem = "charadaerro.jpg";

		
		//============alternativas============
		
		void ButtonAClick(object sender, EventArgs e)
		{
			if (alternativaCorreta == "A")
			{
				pictureBox2.Load(nomeImagem);
				MessageBox.Show("Parabéns, resposta correta!");
				pontos++;
				labelPontos.Text = "Pontos:" + pontos;
			}
			else
			{
				MessageBox.Show("Resposta errada!");
				pictureBox2.Load(erroImagem);
			}
			
			panel1.Enabled = false;
				
	
		}
		void BClick(object sender, EventArgs e)
		{
			if (alternativaCorreta == "B")
			{
				pictureBox2.Load(nomeImagem);
				MessageBox.Show("Parabéns, resposta correta!");
				pontos++;
				labelPontos.Text = "Pontos:" + pontos;
			}
			else
			{
				MessageBox.Show("Resposta errada!");
				pictureBox2.Load(erroImagem);
			}
			
			panel1.Enabled = false;
		}
		void CClick(object sender, EventArgs e)
		{
	
			{
			if (alternativaCorreta == "C")
			{
				pictureBox2.Load(nomeImagem);
				MessageBox.Show("Parabéns, resposta correta!");
				pontos++;
				labelPontos.Text = "Pontos:" + pontos;
			}
			else
			{
				MessageBox.Show("Resposta errada!");
				pictureBox2.Load(erroImagem);
			}
			
			panel1.Enabled = false;
		}
			
				

			
		}
		void DClick(object sender, EventArgs e)
		{
			{
			if (alternativaCorreta == "D")
			{
				pictureBox2.Load(nomeImagem);
				MessageBox.Show("Parabéns, resposta correta!");
				pontos++;
				labelPontos.Text = "Pontos:" + pontos;
			}
			else
			{
				MessageBox.Show("Resposta errada!");
				pictureBox2.Load(erroImagem);
			}
			
			panel1.Enabled = false;
		}
		
		}
		void Button1Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;	
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;
		//questão 1	
		pictureBox2.Load("pergunta1.jpg");
		labelPergunta.Text = ("1.Quem é considerado o pai da computação?");  
		labelA.Text = "Alan Turing";
		labelB.Text = "Charles Babbage";
		labelC.Text = "Ada Lovelace";
		labelD.Text = "John von Neumann";
		alternativaCorreta = "A";
		nomeImagem = "alan.jpg";
		
		panel1.Enabled = true;
		
		button1.Enabled = false;
		button2.Enabled = true;
		
				
		}
		void Button2Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 2	
		pictureBox2.Load("ram.jpg");
		labelPergunta.Text = ("2.Qual foi o primeiro computador a usar memória de acesso aleatório (RAM)?");
		labelA.Text = "ENIAC";
		labelB.Text = "Colossus";
		labelC.Text = "UNIVAC I";
		labelD.Text = "Manchester Baby";
		alternativaCorreta = "D";
		nomeImagem = "baby.jpg";
		
		panel1.Enabled = true;
		
		button2.Enabled = false;
		button3.Enabled = true;
		}
		void Button3Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;
		//questão 3	
		pictureBox2.Load("microproc.jpg");
		labelPergunta.Text = ("3.Quem é conhecido como o pai do microprocessador?");
		labelA.Text = "Gordon Moore";
		labelB.Text = "Jack Kilby";
		labelC.Text = "Ted Hoff";
		labelD.Text = "Robert Noyce";
		alternativaCorreta = "C";
		nomeImagem = "hoff.jpg";
		
		panel1.Enabled = true;
		
		button3.Enabled = false;
		button4.Enabled = true;
		
		}
		void Button4Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 4	
		pictureBox2.Load("pcantigo.jpg");
		labelPergunta.Text = ("4.Qual empresa lançou o primeiro computador pessoal com sucesso comercial?");
		labelA.Text = "IBM";
		labelB.Text = "Apple";
		labelC.Text = "Microsoft";
		labelD.Text = "Intel";
		alternativaCorreta = "B";
		nomeImagem = "mac.jpg";
		
		panel1.Enabled = true;
		
		button4.Enabled = false;
		button5.Enabled = true;
		}
		void Button5Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 5	
		pictureBox2.Load("interface.jpg");
		labelPergunta.Text = ("5.O que significa a sigla GUI, comumente associada à interação do usuário com computadores?");
		labelA.Text = "Graphical User Interface";
		labelB.Text = "General Utility Interface";
		labelC.Text = "Grouped User Integration";
		labelD.Text = "Guided User Interaction";
		alternativaCorreta = "A";
		nomeImagem = "gui.png";
		
		panel1.Enabled = true;
		
		button5.Enabled = false;
		button6.Enabled = true;
		}
		void Button6Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 6
		pictureBox2.Load("ibm.jpg");
		labelPergunta.Text = ("6.Qual foi o primeiro computador a usar um sistema operacional de disco?");
		labelA.Text = "IBM 7090";
		labelB.Text = "IBM 1401";
		labelC.Text = "IBM 650";
		labelD.Text = "IBM System/360";
		alternativaCorreta = "B";
		nomeImagem = "ibm1401.jpg";
		
		panel1.Enabled = true;
		
		button6.Enabled = false;
		button7.Enabled = true;
		}
		void Button7Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 7
		pictureBox2.Load("antivirus.jpg");
		labelPergunta.Text = ("7.Quem foi o criador do primeiro programa antivírus comercial?");
		labelA.Text = "John McAfee";
		labelB.Text = "Eugene Kaspersky";
		labelC.Text = "Alan Turing";
		labelD.Text = "Bertrand Meyer";
		alternativaCorreta = "A";
		nomeImagem = "mcafee.jpg";
		
		panel1.Enabled = true;
		
		button7.Enabled = false;
		button8.Enabled = true;
		}
		void Button8Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 8	
		pictureBox2.Load("ip.png");
		labelPergunta.Text = ("8.Em que década o protocolo TCP/IP, a base da internet, foi desenvolvido?");
		labelA.Text = "Década de 1960";
		labelB.Text = "Década de 1970";
		labelC.Text = "Década de 1980";
		labelD.Text = "Década de 1990";
		alternativaCorreta = "C";
		nomeImagem = "arpa.jpeg";
		
		panel1.Enabled = true;
		
		button8.Enabled = false;
		button9.Enabled = true;
		}
		void Button9Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 9
		pictureBox2.Load("producao.jpg");
		labelPergunta.Text = ("9.Qual foi o primeiro computador a ser produzido em massa?");
		labelA.Text = "UNIVAC I";
		labelB.Text = "IBM 701";
		labelC.Text = "IBM 1401";
		labelD.Text = "Ferranti Mark I";
		alternativaCorreta = "C";
		nomeImagem = "ibmpc.jpg";
		
		panel1.Enabled = true;
		
		button9.Enabled = false;
		button10.Enabled = true;
		}
		void Button10Click(object sender, EventArgs e)
		{
		labeltitulo.Visible = false;
		pictureBox1.Visible = false;
		pictureBox2.Visible = true;	
		//questão 10	
		pictureBox2.Load("circuito.jpg");
		labelPergunta.Text = ("10.Qual foi o primeiro computador a utilizar circuitos integrados?");
		labelA.Text = "UNIVAC I";
		labelB.Text = "IBM 1401";
		labelC.Text = "Ferranti Mark I";
		labelD.Text = "IBM 360";
		alternativaCorreta = "A";
		nomeImagem = "univac.jpg";
		
		panel1.Enabled = true;
		
		button10.Enabled = false;
		
		}
		void ButtonReiniciarClick(object sender, EventArgs e)
		{
			Application.Restart();
		}
		void ResultadosClick(object sender, EventArgs e)
		{
			if(pontos == 0)
			{
				MessageBox.Show("Estude mais.Você não domina nada do assunto!!!");
			}
			else if(pontos >= 1 && pontos<= 4)
			{
				MessageBox.Show("Seu conhecimento é de iniciante");
			}
			else if (pontos >= 5 && pontos <= 7)
			{
				MessageBox.Show("Você tem um bom conhecimento!!!");
			}
			else if (pontos >= 8 && pontos <= 9)
			{
				MessageBox.Show("Seu conhecimento é excepcional");
			}
			else{
				MessageBox.Show("Você é um gênio!!!");
			}
		}
	}
}
