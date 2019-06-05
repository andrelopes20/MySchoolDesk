﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Login : Form
    {


        public string nomeprof = "";
        public Form carregamento = new Loading();
        private void login()
        {
            Task.Delay(30000);
            //MODELO SELECT
            string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

            MySqlConnection conexao = null;
            try
            {
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                //COMANDO SQL
                comando.CommandText = "SELECT email_professor, senha_professor, nome_professor FROM tb_professor WHERE email_professor=@email and senha_professor=@senha";

                //VARIAVEIS
                comando.Parameters.AddWithValue("@email", textBox1.Text);
                comando.Parameters.AddWithValue("@senha", textBox2.Text);

                comando.ExecuteNonQuery();

                MySqlDataReader leitor = comando.ExecuteReader();
                //se há linhas
                if (leitor.HasRows)
                {
                    leitor.Read();
                    nomeprof = leitor.GetString(2);

                    Form home = new Home();
                    home.Closed += (s, args) => this.Close();
                    carregamento.Close();
                    home.Show();
                }
                else
                {
                    carregamento.Hide();
                    this.Show();
                    textBox1.Text="";
                    textBox2.Text="";
                    MessageBox.Show("Usuario e/ou senha incorretos");
                }

            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO SELECT

        }

        public Login()
        {
            InitializeComponent();

            textBox2.PasswordChar = '\0';
            textBox2.Text = "SENHA";
            textBox2.ForeColor = Color.DarkGray;
            textBox1.ForeColor = Color.DarkGray;
            textBox1.GotFocus += new EventHandler(this.TextGotFocustb1);
            textBox1.LostFocus += new EventHandler(this.TextLostFocustb1);

            textBox2.GotFocus += new EventHandler(this.TextGotFocustb2);
            textBox2.LostFocus += new EventHandler(this.TextLostFocustb2);

            this.ActiveControl = textBox3;
        }

        public void TextGotFocustb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox1.Text == "EMAIL")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox1.Text == "")
            {
                textBox1.Text = "EMAIL";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        public void TextGotFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "SENHA")
            {
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "SENHA";
                textBox2.ForeColor = Color.DarkGray;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            carregamento.Show();
            login();
        }

        public void Label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            carregamento.Show();
            login();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            carregamento.Show();
            login();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }


