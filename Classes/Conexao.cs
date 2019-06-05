using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Conexao
    {

        string conecta = "DATABASE=id9330728_database_sistema; SERVER=http://self-sown-shovels.000webhostapp.com; UID=id9330728_lucas;PWD=123456";
        protected SqlConnection conexao = null;

        public void AbrirConexao()
        {

            try
            {

                conexao = new SqlConnection(conecta);
                conexao.Open();

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }

        public void FecharConexao()
        {
            try
            {
                conexao = new SqlConnection(conecta);
                conexao.Close();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
