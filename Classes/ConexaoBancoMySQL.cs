using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsFormsApp1
{
    public class ConexaoBancoMySQL
    {
        private static MySqlConnection objConexao = null;

        // string mysql acessa o banco do servidor de hospedagem
        public string stringconnection1 = "server=seusite.com.br;User Id = seuid; password=suasenha;database=seubanconoservidordehospedagem";
        //private String stringconnection1 = "den1.mysql2.gear.host; UserId = bdmyschool; password= 123456.;database=bdmyschool";
        public string stringconnection2 = "Server=den1.mysql2.gear.host; User Id=bdmyschool; password=123456.;database=bdmyschool";

        #region metodos que tentam abrir conexao com projeto rodando local ou hospedado

        public void tentarAbrirConexaoLocal()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection1;
            objConexao.Open();
        }

        public void tentarAbrirConexaoRemota()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection2;
            objConexao.Open();
        }
        public void fechaConexao()
            {
                objConexao.Close();
            }
    #endregion

    public ConexaoBancoMySQL()
        {
          
            try
            {
                tentarAbrirConexaoRemota();
                //Console.WriteLine("Conectado");
            }
            catch
            {
                try
                {
                    tentarAbrirConexaoLocal();
                }
                catch
                {
                    Console.WriteLine("Não foi possível validar seu acesso.Tente novamente.");

                    // Você pode substituir esta notificação por qualquer outra coisa que faça o mesmo que o metodo console.whiteline
                }
            }

        }

        public static MySqlConnection getConexao()
        {
            new ConexaoBancoMySQL();
            return objConexao;
        }
        public static void fecharConexao()
        {
            objConexao.Close();
        }
    }
}
