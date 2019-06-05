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
    public partial class CadastroPresenca : Form
    {
        public CadastroPresenca()
        {
            InitializeComponent();

            textBox1.GotFocus += new EventHandler(this.TextGotFocustb1);
            textBox1.LostFocus += new EventHandler(this.TextLostFocustb1);

            textBox2.GotFocus += new EventHandler(this.TextGotFocustb2);
            textBox2.LostFocus += new EventHandler(this.TextLostFocustb2);

            
            dataGridView1.Visible = false;

            


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

        public void TextGotFocustb2(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (textBox2.Text == "Conteúdo")
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
                textBox2.Text = "Conteúdo";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

        private void CadastroPresenca_Load(object sender, EventArgs e)
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
                comando.CommandText = "SELECT tb_aluno.id_aluno ID, tb_aluno.nome_aluno Nome, tb_curso.nome_curso Curso, tb_curso.id_curso IDCurso FROM tb_aluno INNER JOIN tb_aux_aluno_turma ON tb_aluno.id_aluno = tb_aux_aluno_turma.id_aluno INNER JOIN tb_turma ON tb_aux_aluno_turma.id_turma = tb_turma.id_turma INNER JOIN tb_curso ON tb_curso.id_curso = tb_turma.id_curso WHERE tb_turma.id_turma = @id; ";

                //VARIAVEIS
                comando.Parameters.AddWithValue("@id", textBox1.Text);

                MySqlDataReader leitor = comando.ExecuteReader();
                tabela.Load(leitor);

                if (tabela.Rows.Count > 0)
                {

                    dataGridView1.DataSource = tabela;
                    dataGridView1.Visible = true;


                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    dataGridView1.Columns.Add(chk);
                    chk.HeaderText = "Presenca";
                    chk.Name = "Presenca";
                    chk.FalseValue = "False";

                    dataGridView1.Columns["ID"].Width = 58;
                    dataGridView1.Columns["ID"].ReadOnly = true;
                    dataGridView1.Columns["Nome"].Width = 150;
                    dataGridView1.Columns["Nome"].ReadOnly = true;
                    dataGridView1.Columns["Curso"].ReadOnly = true;
                    dataGridView1.Columns["IDCurso"].ReadOnly = true;
                    dataGridView1.Columns["Curso"].Width = 125;
                    dataGridView1.Columns["ID"].DisplayIndex = 0;
                    dataGridView1.Columns["Nome"].DisplayIndex = 1;
                    dataGridView1.Columns["Curso"].DisplayIndex = 2;
                    dataGridView1.Columns["IDCurso"].DisplayIndex = 3;
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ClearSelection();
                    dataGridView1.ScrollBars = ScrollBars.Vertical;

                    dataGridView1.Refresh();
                    dataGridView1.Update();


                }

            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            //MODELO SELECT
        
    }




        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int ID;
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Refresh();
            dataGridView1.Update();
            
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
                comando.CommandText = "insert into tb_aula (conteudo, data_aula) values (@conteudo, @dataaula);" +
                    "select LAST_INSERT_ID() as ID from tb_aula";


                comando.Parameters.AddWithValue("@conteudo", textBox2.Text);
                comando.Parameters.AddWithValue("@dataaula", data);


                MySqlDataReader leitor = comando.ExecuteReader();
                leitor.Read();
                if (leitor.HasRows)
                {
                        ID = Int32.Parse(leitor["ID"].ToString());
                }

                //VARIAVEIS

                leitor.Close();

                comando.Prepare();
                comando.ExecuteNonQuery();
                conexao.Close();






                conexao = new MySqlConnection(conexaostr);
                conexao.Open();
                MySqlCommand comando1 = new MySqlCommand();
                comando1.Connection = conexao;
                

                //COMANDO SQL
                comando1.CommandText = "insert into tb_presenca (id_aula,id_aluno,id_curso,presenca,id_turma) values (@ID,@idaluno, @idcurso,@presenca,@id_turma);";
                


                int idaluno;
                int idcurso;
                int id_turma;
                string presenca;
                int i=0;

                

                while (i<=dataGridView1.Rows.Count-1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["Presenca"];
                    dataGridView1.Update();
                    comando1.Parameters.Clear();
                    

                    //if (bool.Parse(cell.FormattedValue.ToString())==true)
                    if (bool.Parse(dataGridView1.Rows[i].Cells["Presenca"].FormattedValue.ToString()) == true)
                    {
                        idaluno = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value);
                        idcurso = Convert.ToInt32(dataGridView1.Rows[i].Cells["IDCurso"].Value);
                        presenca = "Presente";
                        id_turma = Convert.ToInt32(textBox1.Text);


                        comando1.Parameters.AddWithValue("@idaluno", idaluno);
                        comando1.Parameters.AddWithValue("@ID", ID);
                        comando1.Parameters.AddWithValue("@idcurso", idcurso);
                        comando1.Parameters.AddWithValue("@presenca", presenca);
                        comando1.Parameters.AddWithValue("@id_turma", id_turma);
                        comando1.Prepare();
                        comando1.ExecuteNonQuery();
                 
                        i++;
                        
                    }
                    else
                    {

                        idaluno = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value);
                        idcurso = Convert.ToInt32(dataGridView1.Rows[i].Cells["IDCurso"].Value);
                        presenca = "Ausente";
                        id_turma = Convert.ToInt32(textBox1.Text);


                        comando1.Parameters.AddWithValue("@idaluno", idaluno);
                        comando1.Parameters.AddWithValue("@idcurso", idcurso);
                        comando1.Parameters.AddWithValue("@ID", ID);
                        comando1.Parameters.AddWithValue("@presenca", presenca);
                        comando1.Parameters.AddWithValue("@id_turma", id_turma);
                        comando1.Prepare();
                        comando1.ExecuteNonQuery();

                        i++;
                        
                    }

                }
                MessageBox.Show("Presenças adicionadas com sucesso!");
                dataGridView1.Refresh();
                dataGridView1.Update();
                dataGridView1.ClearSelection();


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
