using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Classes
{
    public class AlunoDAO : Conexao
    {
        SqlCommand comando = null;

        public void inserir()
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("insert into tb_presenca (id_aula, id_aluno, id_curso, presenca) values (1, 1, 1, 'P');",conexao);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {

                FecharConexao();
            }


        }


    }
}
