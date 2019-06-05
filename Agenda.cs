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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
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
                comando.CommandText = "INSERT INTO tb_agenda (nome_evento, descricao, id_turma) VALUES (@curso,@descricao,@idturma)";
                comando.Prepare();
                //VARIAVEIS
                comando.Parameters.AddWithValue("@curso", textBox1.Text);
                comando.Parameters.AddWithValue("@descricao", textBox3.Text);
                comando.Parameters.AddWithValue("@idturma", textBox2.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Novo evento inserido com sucesso!");

                textBox1.Text = "Nome do Evento";
                textBox1.ForeColor = Color.DarkGray;

                textBox2.Text = "ID da Turma";
                textBox2.ForeColor = Color.DarkGray;

                textBox3.Text = "Descricao";
                textBox3.ForeColor = Color.DarkGray;


            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO INSERT
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += new EventHandler(this.TextGotFocustb1);
            textBox1.LostFocus += new EventHandler(this.TextLostFocustb1);

            textBox2.GotFocus += new EventHandler(this.TextGotFocustb2);
            textBox2.LostFocus += new EventHandler(this.TextLostFocustb2);

            textBox3.GotFocus += new EventHandler(this.TextGotFocustb3);
            textBox3.LostFocus += new EventHandler(this.TextLostFocustb3);
        }
        public void TextGotFocustb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox1.Text == "Nome do Evento")
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
                textBox1.Text = "Nome do Evento";
                textBox1.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "ID da Turma")
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
                textBox2.Text = "ID da Turma";
                textBox2.ForeColor = Color.DarkGray;
            }
        }
        public void TextGotFocustb3(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox3.Text == "Descricao")
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
                textBox3.Text = "Descricao";
                textBox3.ForeColor = Color.DarkGray;
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
