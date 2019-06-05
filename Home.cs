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

    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro Geral";
        }

        private void PictureBox3_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Notas";
        }

        private void PictureBox4_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Presença";
        }

        private void PictureBox5_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Perguntas ao Quiz";
        }

        private void PictureBox7_OnMouseHover(object sender, EventArgs e)
        {
            label3.Text = "Cadastro de Eventos";
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            Form cadastroaluno = new CadastroAluno();
            cadastroaluno.Closed += (s, args) => this.Close();
            cadastroaluno.Show();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Form quiz = new Quiz();
            quiz.Closed += (s, args) => this.Close();
            quiz.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form cadastronota = new CadastroNota();
            cadastronota.Closed += (s, args) => this.Close();
            cadastronota.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Form cadastropresenca = new CadastroPresenca();
            cadastropresenca.Closed += (s, args) => this.Close();
            cadastropresenca.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Form agenda = new Agenda();
            agenda.Closed += (s, args) => this.Close();
            agenda.Show();
        }
    }
}

