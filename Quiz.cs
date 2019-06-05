using MySql.Data.MySqlClient;
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
    public partial class Quiz : Form
    {

        public void pergunta1()
            {

            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                
                if (textBox1.Text != null && textBox1.Text != "Resposta número 1" && textBox2.Text != null && textBox2.Text != "Resposta número 2" && textBox3.Text != null && textBox3.Text != "Resposta número 3")
                {
                    
                    q1rsp1 = textBox1.Text;
                    q1rsp2 = textBox2.Text;
                    q1rsp3 = textBox3.Text;
                    enun1 = textBox7.Text;

                    if (radioButton1.Checked == true)
                    {
                        q1rsp = 1;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        q1rsp = 2;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        q1rsp = 3;
                    }
                    textBox3.ForeColor = Color.DarkGray;
                    textBox2.ForeColor = Color.DarkGray;
                    textBox1.ForeColor = Color.DarkGray;
                    textBox7.ForeColor = Color.DarkGray;
                    textBox7.Text = "Escreva aqui o enunciado.:";
                    textBox1.Text = "Resposta número 1";
                    textBox2.Text = "Resposta número 2";
                    textBox3.Text = "Resposta número 3";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    i++;
                    questao++;
                    MessageBox.Show("Questão 1 salva!");

                }
                else
                {
                    MessageBox.Show("Você não preencheu todos os campos.");
                    i--;
                }
            }
            else{
                MessageBox.Show("Você não selecionou a resposta correta");
                i--;
            }
        }

        public void pergunta2()
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {                
                if (textBox1.Text != null && textBox1.Text != "Resposta número 1" && textBox2.Text != null && textBox2.Text != "Resposta número 2" && textBox3.Text != null && textBox3.Text != "Resposta número 3")
                {
                    
                    q2rsp1 = textBox1.Text;
                    q2rsp2 = textBox2.Text;
                    q2rsp3 = textBox3.Text;
                    enun2 = textBox7.Text;

                    if (radioButton1.Checked == true)
                    {
                        q2rsp = 1;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        q2rsp = 2;
                    }
                    else
                    {
                        q2rsp = 3;
                    }
                    textBox7.ForeColor = Color.DarkGray;
                    textBox7.Text = "Escreva aqui o enunciado.:";
                    textBox3.ForeColor = Color.DarkGray;
                    textBox2.ForeColor = Color.DarkGray;
                    textBox1.ForeColor = Color.DarkGray;
                    textBox1.Text = "Resposta número 1";
                    textBox2.Text = "Resposta número 2";
                    textBox3.Text = "Resposta número 3";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    i++;
                    questao++;
                    MessageBox.Show("Questão 2 salva!");
                }
                else
                {
                    MessageBox.Show("Você não preencheu todos os campos.");
                    i--;
                }
            }
            else
            {
                MessageBox.Show("Você não selecionou a resposta correta");
                i--;
            }

        }
        public void pergunta3()
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {

                if (textBox1.Text != null && textBox1.Text != "Resposta número 1" && textBox2.Text != null && textBox2.Text != "Resposta número 2" && textBox3.Text != null && textBox3.Text != "Resposta número 3")
                {
                    q3rsp1 = textBox1.Text;
                    q3rsp2 = textBox2.Text;
                    q3rsp3 = textBox3.Text;
                    enun3 = textBox7.Text;

                    if (radioButton1.Checked == true)
                    {
                        q3rsp = 1;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        q3rsp = 2;
                    }
                    else
                    {
                        q3rsp = 3;
                    }
                    textBox7.ForeColor = Color.DarkGray;
                    textBox7.Text = "Escreva aqui o enunciado.:";
                    textBox3.ForeColor = Color.DarkGray;
                    textBox2.ForeColor = Color.DarkGray;
                    textBox1.ForeColor = Color.DarkGray;
                    textBox1.Text = "Resposta número 1";
                    textBox2.Text = "Resposta número 2";
                    textBox3.Text = "Resposta número 3";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    i++;
                    questao++;
                    MessageBox.Show("Questão 3 salva!");
                }
                else{
                    
                        MessageBox.Show("Você não preencheu todos os campos.");
                        i--;
                    
                }
            }
            else
            {
                MessageBox.Show("Você não selecionou a resposta correta");
                i--;
            }

            }
        public void pergunta4()
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (textBox1.Text != null && textBox1.Text != "Resposta número 1" && textBox2.Text != null && textBox2.Text != "Resposta número 2" && textBox3.Text != null && textBox3.Text != "Resposta número 3")
                {
                    q4rsp1 = textBox1.Text;
                    q4rsp2 = textBox2.Text;
                    q4rsp3 = textBox3.Text;
                    enun4 = textBox7.Text;

                    if (radioButton1.Checked == true)
                    {
                        q4rsp = 1;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        q4rsp = 2;
                    }
                    else
                    {
                        q4rsp = 3;
                    }
                    textBox7.ForeColor = Color.DarkGray;
                    textBox7.Text = "Escreva aqui o enunciado.:";
                    textBox3.ForeColor = Color.DarkGray;
                    textBox2.ForeColor = Color.DarkGray;
                    textBox1.ForeColor = Color.DarkGray;
                    textBox1.Text = "Resposta número 1";
                    textBox2.Text = "Resposta número 2";
                    textBox3.Text = "Resposta número 3";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    i++;
                    questao++;
                    MessageBox.Show("Questão 4 salva!");
                }
                else
                {
                    MessageBox.Show("Você não preencheu todos os campos.");
                    i--;
                }

            }
            else
            {
                MessageBox.Show("Você não selecionou a resposta correta");
                i--;
            }
        }
        public void pergunta5()
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (textBox1.Text != null && textBox1.Text != "Resposta número 1" && textBox2.Text != null && textBox2.Text != "Resposta número 2" && textBox3.Text != null && textBox3.Text != "Resposta número 3")
                {
                    q5rsp1 = textBox1.Text;
                    q5rsp2 = textBox2.Text;
                    q5rsp3 = textBox3.Text;
                    enun5 = textBox7.Text;

                    if (radioButton1.Checked == true)
                    {
                        q5rsp = 1;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        q5rsp = 2;
                    }
                    else
                    {
                        q5rsp = 3;
                    }
                    textBox7.ForeColor = Color.DarkGray;
                    textBox7.Text = "Escreva aqui o enunciado.:";
                    textBox3.ForeColor = Color.DarkGray;
                    textBox2.ForeColor = Color.DarkGray;
                    textBox1.ForeColor = Color.DarkGray;
                    textBox1.Text = "Resposta número 1";
                    textBox2.Text = "Resposta número 2";
                    textBox3.Text = "Resposta número 3";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    i++;
                    MessageBox.Show("Questão 5 salva!");
                }
                else
                {
                    MessageBox.Show("Você não preencheu todos os campos.");
                    i--;
                }

            }
            else
            {
                MessageBox.Show("Você não selecionou a resposta correta");
                i--;
            }
        }

        int questao = 1;
        int i = 1;

        string enun1;
        string q1rsp1;
        string q1rsp2;
        string q1rsp3;
        int q1rsp;

        string enun2;
        string q2rsp1;
        string q2rsp2;
        string q2rsp3;
        int q2rsp;

        string enun3;
        string q3rsp1;
        string q3rsp2;
        string q3rsp3;
        int q3rsp;

        string enun4;
        string q4rsp1;
        string q4rsp2;
        string q4rsp3;
        int q4rsp;

        string enun5;
        string q5rsp1;
        string q5rsp2;
        string q5rsp3;
        int q5rsp;


        public Quiz()
        {
            InitializeComponent();

            textBox9.Visible = false;
            pictureBox3.Visible=false;

            textBox1.GotFocus += new EventHandler(this.TextGotFocustb1);
            textBox1.LostFocus += new EventHandler(this.TextLostFocustb1);

            textBox2.GotFocus += new EventHandler(this.TextGotFocustb2);
            textBox2.LostFocus += new EventHandler(this.TextLostFocustb2);

            textBox3.GotFocus += new EventHandler(this.TextGotFocustb3);
            textBox3.LostFocus += new EventHandler(this.TextLostFocustb3);

            textBox9.GotFocus += new EventHandler(this.TextGotFocustb9);
            textBox9.LostFocus += new EventHandler(this.TextLostFocustb9);

            textBox7.GotFocus += new EventHandler(this.TextGotFocustb7);
            textBox7.LostFocus += new EventHandler(this.TextLostFocustb7);
        }
        public void TextGotFocustb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox1.Text == "Resposta número 1")
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
                textBox1.Text = "Resposta número 1";
                textBox1.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "Resposta número 2")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "")
            {
                textBox2.Text = "Resposta número 2";
                textBox2.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb3(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox3.Text == "Resposta número 3")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb3(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox3.Text == "")
            {
                textBox3.Text = "Resposta número 3";
                textBox3.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb9(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox9.Text == "ID da Turma")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb9(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox9.Text == "")
            {
                textBox9.Text = "ID da Turma";
                textBox9.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb7(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox7.Text == "Escreva aqui o enunciado.:")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb7(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox7.Text == "")
            {
                textBox7.Text = "Escreva aqui o enunciado.:";
                textBox7.ForeColor = Color.DarkGray;
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (i <= 9)
            {
                if (i == 1)
                {
                    pergunta1();

                }

                if (i == 3)
                {
                    pergunta2();
                }

                if (i == 5)
                {
                    pergunta3();
                }

                if (i == 7)
                {
                    pergunta4();
                }

                if (i == 9)
                {
                    
                    pergunta5();
                    if (i == 10)
                    {
                        pictureBox2.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        textBox7.Visible = false;
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        textBox9.Visible = true;
                        pictureBox3.Visible = true;
                        MessageBox.Show("O máximo de 5 questões por quiz foi atingido");

                        
                    }
                }
                label1.Text = questao.ToString();
                i++;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            //MODELO INSERT
            string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

            MySqlConnection conexao = null;
            try
            {
                DateTime data = DateTime.Today;
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                //COMANDO SQL
                comando.CommandText = "INSERT INTO quiz (id_turma, validade_quiz) VALUES (@idturma,@validade)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@idturma", textBox9.Text);
                comando.Parameters.AddWithValue("@validade", data.AddDays(7));

                comando.ExecuteNonQuery();

                MessageBox.Show("Novo quiz inserido com sucesso!");


                //SELECT
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                comando.Connection = conexao;
                int idultimo;
                //COMANDO SQL
                comando.CommandText = "SELECT id_quiz IDQuiz FROM quiz ORDER BY id_quiz DESC LIMIT 1;";

                //VARIAVEIS

                comando.ExecuteNonQuery();
                MySqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();

                idultimo = Convert.ToInt32(leitor["IDQuiz"].ToString()); if (conexao != null)
                conexao.Close();

                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO pergunta (id_quiz, enun_pergunta, opcao_1, opcao_2, opcao_3, opcao_correta) VALUES (@id_quiz,@enun_pergunta,@opcao_1,@opcao_2,@opcao_3,@opcao_correta)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@id_quiz", idultimo);
                comando.Parameters.AddWithValue("@enun_pergunta", enun1);
                comando.Parameters.AddWithValue("@opcao_1", q1rsp1);
                comando.Parameters.AddWithValue("@opcao_2", q1rsp2);
                comando.Parameters.AddWithValue("@opcao_3", q1rsp3);
                comando.Parameters.AddWithValue("@opcao_correta", q1rsp);
                comando.ExecuteNonQuery();
                conexao.Close();

                comando.Parameters.Clear();
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO pergunta (id_quiz, enun_pergunta, opcao_1, opcao_2, opcao_3, opcao_correta) VALUES (@id_quiz,@enun_pergunta,@opcao_1,@opcao_2,@opcao_3,@opcao_correta)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@id_quiz", idultimo);
                comando.Parameters.AddWithValue("@enun_pergunta", enun2);
                comando.Parameters.AddWithValue("@opcao_1", q2rsp1);
                comando.Parameters.AddWithValue("@opcao_2", q2rsp2);
                comando.Parameters.AddWithValue("@opcao_3", q2rsp3);
                comando.Parameters.AddWithValue("@opcao_correta", q2rsp);
                comando.ExecuteNonQuery();
                conexao.Close();

                comando.Parameters.Clear();
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO pergunta (id_quiz, enun_pergunta, opcao_1, opcao_2, opcao_3, opcao_correta) VALUES (@id_quiz,@enun_pergunta,@opcao_1,@opcao_2,@opcao_3,@opcao_correta)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@id_quiz", idultimo);
                comando.Parameters.AddWithValue("@enun_pergunta", enun3);
                comando.Parameters.AddWithValue("@opcao_1", q3rsp1);
                comando.Parameters.AddWithValue("@opcao_2", q3rsp2);
                comando.Parameters.AddWithValue("@opcao_3", q3rsp3);
                comando.Parameters.AddWithValue("@opcao_correta", q3rsp);
                comando.ExecuteNonQuery();
                conexao.Close();

                comando.Parameters.Clear();
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO pergunta (id_quiz, enun_pergunta, opcao_1, opcao_2, opcao_3, opcao_correta) VALUES (@id_quiz,@enun_pergunta,@opcao_1,@opcao_2,@opcao_3,@opcao_correta)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@id_quiz", idultimo);
                comando.Parameters.AddWithValue("@enun_pergunta", enun4);
                comando.Parameters.AddWithValue("@opcao_1", q4rsp1);
                comando.Parameters.AddWithValue("@opcao_2", q4rsp2);
                comando.Parameters.AddWithValue("@opcao_3", q4rsp3);
                comando.Parameters.AddWithValue("@opcao_correta", q4rsp);
                comando.ExecuteNonQuery();
                conexao.Close();

                comando.Parameters.Clear();
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO pergunta (id_quiz, enun_pergunta, opcao_1, opcao_2, opcao_3, opcao_correta) VALUES (@id_quiz,@enun_pergunta,@opcao_1,@opcao_2,@opcao_3,@opcao_correta)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@id_quiz", idultimo);
                comando.Parameters.AddWithValue("@enun_pergunta", enun5);
                comando.Parameters.AddWithValue("@opcao_1", q5rsp1);
                comando.Parameters.AddWithValue("@opcao_2", q5rsp2);
                comando.Parameters.AddWithValue("@opcao_3", q5rsp3);
                comando.Parameters.AddWithValue("@opcao_correta", q5rsp);
                comando.ExecuteNonQuery();

                MessageBox.Show("Novas perguntas inserido com sucesso!");

            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }



            //MODELO INSERT
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
