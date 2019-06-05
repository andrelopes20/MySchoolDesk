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
    public partial class CadastroNota : Form
    {
       
        public CadastroNota()
        {
            InitializeComponent();

            textBox1.GotFocus += new EventHandler(this.TextGotFocustb1);
            textBox1.LostFocus += new EventHandler(this.TextLostFocustb1);

            dataGridView1.Columns["Nota"].Visible = false;
            dataGridView1.Columns["Descricao"].Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            dataGridView1.Visible = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            dataGridView1.AllowUserToAddRows = false;

            pictureBox3.Visible = false;

        }

        public void TextGotFocustb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox1.Text == "Insira o ID da turma")
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
                textBox1.Text = "Insira o ID da turma";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void Layout_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //MODELO SELECT
            string conexaostr = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

            MySqlConnection conexao = null;
            try
            {
                DataTable tabela = new DataTable();
                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                //COMANDO SQL
                comando.CommandText = "SELECT tb_aluno.id_aluno IDAluno, tb_aluno.nome_aluno Nome, tb_curso.nome_curso Curso, tb_curso.id_curso IDCurso FROM tb_aluno INNER JOIN tb_aux_aluno_turma ON tb_aluno.id_aluno = tb_aux_aluno_turma.id_aluno INNER JOIN tb_turma ON tb_aux_aluno_turma.id_turma = tb_turma.id_turma INNER JOIN tb_curso ON tb_curso.id_curso = tb_turma.id_curso WHERE tb_turma.id_turma = @id; ";

                //VARIAVEIS
                comando.Parameters.AddWithValue("@id", textBox1.Text);

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;

                radioButton1.Visible = true;
                radioButton2.Visible = true;

                MySqlDataReader leitor = comando.ExecuteReader();
                tabela.Load(leitor);

                if (tabela.Rows.Count > 0)
                {
                    
                    dataGridView1.DataSource = tabela;
                    dataGridView1.Visible = true;
                    dataGridView1.Columns["Nota"].Width = 70;
                    dataGridView1.Columns["Nota"].Visible = true;
                    dataGridView1.Columns["Descricao"].Visible = false;
                    dataGridView1.Columns["Nome"].Width = 125;
                    dataGridView1.Columns["Nome"].ReadOnly = true;
                    dataGridView1.Columns["Curso"].ReadOnly = true;
                    dataGridView1.Columns["IDAluno"].ReadOnly = true;
                    dataGridView1.Columns["Curso"].Width = 155;
                    dataGridView1.Columns["Nome"].DisplayIndex = 0;
                    dataGridView1.Columns["Curso"].DisplayIndex = 1;
                    dataGridView1.Columns["IDAluno"].DisplayIndex = 2;
                    dataGridView1.Columns["IDCurso"].DisplayIndex = 3;


                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ClearSelection();
                    dataGridView1.ScrollBars = ScrollBars.Vertical;
                    pictureBox3.Visible = true;
                }          

            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO SELECT
        }

        private void PictureBox3_Click(object sender, EventArgs e)
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
                comando.CommandText = "insert into tb_nota (nota, materia, descricao, id_aluno) values (@nota, @curso,@descricao,@id_aluno);";
                //VARIAVEIS

                double nota;
                string curso;
                string descricao;
                int id_aluno;



                comando.Prepare();


                for (int i=0; i <= dataGridView1.Rows.Count-1; i++)
                {
                    comando.Parameters.Clear();
                    

                    nota = Convert.ToDouble(dataGridView1.Rows[i].Cells["Nota"].Value);
                    curso = dataGridView1.Rows[i].Cells["Curso"].Value.ToString();
                    //descricao = Convert.ToString((dataGridView1.Rows[i].Cells["Descricao"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                    descricao = dataGridView1.Rows[i].Cells["Descricao"].Value.ToString();
                    id_aluno = Convert.ToInt32(dataGridView1.Rows[i].Cells["IDAluno"].Value.ToString());
                    //Convert.ToString((DataGridView1.Rows[0].Cells["dgcombocell"] as DataGridViewComboBoxCell).FormattedValue.ToString());

                    comando.Parameters.AddWithValue("@nota", nota);
                    comando.Parameters.AddWithValue("@curso", curso);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@id_aluno", id_aluno);

                    comando.ExecuteNonQuery();
                }   
                MessageBox.Show("Notas adicionadas com sucesso!");               

            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO INSERT
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {


                dataGridView1.Rows[i].Cells["Descricao"].Value = radioButton1.Text;

            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                dataGridView1.Rows[i].Cells["Descricao"].Value = radioButton2.Text;

            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
