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
    public partial class CadastroAluno : Form
    {
        string ativo;
        public CadastroAluno()
        {
            InitializeComponent();

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox10.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += new EventHandler(this.TextGotFocustb1);
            textBox1.LostFocus += new EventHandler(this.TextLostFocustb1);

            textBox2.GotFocus += new EventHandler(this.TextGotFocustb2);
            textBox2.LostFocus += new EventHandler(this.TextLostFocustb2);

            textBox3.GotFocus += new EventHandler(this.TextGotFocustb3);
            textBox3.LostFocus += new EventHandler(this.TextLostFocustb3);

            textBox4.GotFocus += new EventHandler(this.TextGotFocustb4);
            textBox4.LostFocus += new EventHandler(this.TextLostFocustb4);

            textBox5.GotFocus += new EventHandler(this.TextGotFocustb5);
            textBox5.LostFocus += new EventHandler(this.TextLostFocustb5);

            textBox6.GotFocus += new EventHandler(this.TextGotFocustb6);
            textBox6.LostFocus += new EventHandler(this.TextLostFocustb6);

            textBox10.GotFocus += new EventHandler(this.TextGotFocustb7);
            textBox10.LostFocus += new EventHandler(this.TextLostFocustb7);

            textBox7.GotFocus += new EventHandler(this.TextGotFocustb8);
            textBox7.LostFocus += new EventHandler(this.TextLostFocustb8);



        }

        private void TextBox1_OnClick(object sender, EventArgs e)
        {


        }
        public void TextGotFocustb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox1.Text == "Nome completo")
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
                textBox1.Text = "Nome completo";
                textBox1.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb5(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox5.Text == "Turma")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb5(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox5.Text == "")
            {
                textBox5.Text = "Turma";
                textBox5.ForeColor = Color.DarkGray;
            }
        }

        public void TextGotFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "Repita senha")
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
                textBox2.Text = "Repita senha";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

        public void TextGotFocustb3(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox3.Text == "Email")
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
                textBox3.Text = "Email";
                textBox3.ForeColor = Color.DarkGray;
            }
        }

        public void TextGotFocustb4(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox4.Text == "Senha")
            {
                textBox4.PasswordChar = '*';
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb4(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox4.Text == "")
            {
                textBox4.PasswordChar = '\0';
                textBox4.Text = "Senha";
                textBox4.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb8(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox7.Text == "Curso da turma")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb8(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox7.Text == "")
            {
                textBox7.Text = "Curso da turma";
                textBox7.ForeColor = Color.DarkGray;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //INSERT ALUNO
            if (ativo.Equals("Aluno")){

                if (textBox2.Text.Equals(textBox4.Text))
                {
                    //MODELO INSERT
                    string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

                    MySqlConnection conexao = null;
                    try
                    {
                        conexao = new MySqlConnection(conexaostr);
                        conexao.Open();
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = conexao;
                        //COMANDO SQL
                        comando.CommandText = "INSERT INTO tb_aluno (nome_aluno, email_aluno, senha_aluno, pontos_aluno) VALUES (@nome,@email,@senha,0);" +
                            "INSERT INTO tb_aux_aluno_turma(id_aluno, id_turma) VALUES(LAST_INSERT_ID(),@turma)"; 
                        comando.Prepare();
                        //VARIAVEIS
                        comando.Parameters.AddWithValue("@nome", textBox1.Text);
                        comando.Parameters.AddWithValue("@turma", textBox5.Text);
                        comando.Parameters.AddWithValue("@email", textBox3.Text);
                        comando.Parameters.AddWithValue("@senha", textBox2.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Novo aluno inserido com sucesso!");

                        textBox1.Text = "Nome completo";
                        textBox1.ForeColor = Color.DarkGray;

                        textBox2.PasswordChar = '\0';
                        textBox2.Text = "Repita senha";
                        textBox2.ForeColor = Color.DarkGray;

                        textBox3.Text = "Email";
                        textBox3.ForeColor = Color.DarkGray;

                        textBox4.PasswordChar = '\0';
                        textBox4.Text = "Senha";
                        textBox4.ForeColor = Color.DarkGray;

                        textBox5.Text = "Turma";
                        textBox5.ForeColor = Color.DarkGray;

                    }
                    finally
                    {
                        if (conexao != null)
                            conexao.Close();
                    }



                    //MODELO INSERT
                }

                else
                {
                    MessageBox.Show("Senhas incompativeis");
                }
            }
            //INSERT ALUNO

            //INSERT PROFESSOR
            if (ativo.Equals("Professor"))
            {

                if (textBox2.Text.Equals(textBox4.Text))
                {
                    //MODELO INSERT
                    string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

                    MySqlConnection conexao = null;
                    try
                    {
                        conexao = new MySqlConnection(conexaostr);
                        conexao.Open();
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = conexao;
                        //COMANDO SQL
                        comando.CommandText = "INSERT INTO tb_professor (nome_professor , email_professor, senha_professor) VALUES (@nome,@email,@senha)";
                        comando.Prepare();
                        //VARIAVEIS
                        comando.Parameters.AddWithValue("@nome", textBox1.Text);
                        comando.Parameters.AddWithValue("@email", textBox3.Text);
                        comando.Parameters.AddWithValue("@senha", textBox2.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Novo professor inserido com sucesso!");

                        textBox1.Text = "Nome completo";
                        textBox1.ForeColor = Color.DarkGray;

                        textBox2.PasswordChar = '\0';
                        textBox2.Text = "Repita senha";
                        textBox2.ForeColor = Color.DarkGray;

                        textBox3.Text = "Email";
                        textBox3.ForeColor = Color.DarkGray;

                        textBox4.PasswordChar = '\0';
                        textBox4.Text = "Senha";
                        textBox4.ForeColor = Color.DarkGray;


                    }
                    finally
                    {
                        if (conexao != null)
                            conexao.Close();
                    }



                    //MODELO INSERT
                }

                else
                {
                    MessageBox.Show("Senhas incompativeis");
                }
            }
            //INSERT PROFESSOR

            //INSERT CURSO
            if (ativo.Equals("Curso"))
            {

                    //MODELO INSERT
                    string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

                    MySqlConnection conexao = null;
                    try
                    {
                        conexao = new MySqlConnection(conexaostr);
                        conexao.Open();
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = conexao;
                        //COMANDO SQL
                        comando.CommandText = "INSERT INTO tb_curso (nome_curso , descricao_curso) VALUES (@nome,@descricao)";
                        comando.Prepare();
                        //VARIAVEIS
                        comando.Parameters.AddWithValue("@nome", textBox10.Text);
                        comando.Parameters.AddWithValue("@descricao", textBox6.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Novo curso inserido com sucesso!");

                        textBox10.Text = "Nome do Curso";
                        textBox10.ForeColor = Color.DarkGray;

                        textBox6.Text = "Descricao";
                        textBox6.ForeColor = Color.DarkGray;


                    }
                    finally
                    {
                        if (conexao != null)
                            conexao.Close();
                    }



                    //MODELO INSERT
                
            }
            //INSERT CURSO
        }


        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }


        public void TextGotFocustb6(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox6.Text == "Descricao")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb6(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox6.Text == "")
            {
                textBox6.Text = "Descricao";
                textBox6.ForeColor = Color.DarkGray;
            }
        }

        public void TextGotFocustb7(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox10.Text == "Nome do Curso")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }

        public void TextLostFocustb7(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox10.Text == "")
            {
                textBox10.Text = "Nome do Curso";
                textBox10.ForeColor = Color.DarkGray;
            }
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            //MODELO INSERT
            string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

            MySqlConnection conexao = null;
            try
            {
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                //COMANDO SQL
                comando.CommandText = "INSERT INTO tb_curso (nome_curso, descricao_curso) VALUES (@nome,@descricao)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@nome", textBox10.Text);
                comando.Parameters.AddWithValue("@descricao", textBox6.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Novo curso inserido com sucesso!");

                textBox10.Text = "Nome do Curso";
                textBox10.ForeColor = Color.DarkGray;

                textBox6.Text = "Descricao";
                textBox6.ForeColor = Color.DarkGray;


            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO INSERT
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;            
            textBox7.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            textBox6.Visible = false;
            textBox10.Visible = false;
            ativo = "Aluno";
        }
        private void PictureBox5_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Aluno";
        }
        private void PictureBox2_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Professor";
        }
        private void PictureBox8_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Curso";
        }
        private void PictureBox7_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Turma";
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox10.Visible = false;
            ativo = "Professor";
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            textBox6.Visible = true;
            textBox7.Visible = false;
            textBox10.Visible = true;
            ativo = "Curso";
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = true;
            textBox10.Visible = false;
            ativo = "Turma";
            
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
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
                comando.CommandText = "SELECT id_curso IDCurso FROM tb_curso WHERE nome_curso=@nome";

                //VARIAVEIS
                comando.Parameters.AddWithValue("@nome", textBox7.Text);

                comando.ExecuteNonQuery();
                MySqlDataReader leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    leitor.Read();
                    string idstr = leitor["IDCurso"].ToString();
    
                    int id = Convert.ToInt32(idstr);



                    conexao.Close();
                    //MODELO SELECT

                    //MODELO INSERT
                    conexao = new MySqlConnection(conexaostr);
                    conexao.Open();
                    comando.Connection = conexao;
                    //COMANDO SQL
                    comando.CommandText = "INSERT INTO tb_turma (id_curso) VALUES (@id)";
                    comando.Prepare();
                    //VARIAVEIS
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Nova turma inserida com sucesso!");

                    textBox7.Text = "Curso da turma";
                    textBox7.ForeColor = Color.DarkGray;

                }
                else
                {
                    MessageBox.Show("Esse curso não existe, digite novamente ou crie um novo.");

                    textBox7.Text = "Curso da turma";
                    textBox7.ForeColor = Color.DarkGray;
                }
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO INSERT
        }
    }
}
