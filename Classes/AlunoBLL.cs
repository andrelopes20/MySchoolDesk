using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class AlunoBLL
    {

        AlunoDAO aluno = new AlunoDAO();

        public void salvar()
        {
            try
            {
                aluno.inserir();
            }
            catch (Exception erro)
            {
                throw erro;

            }
            finally
            {

            }
        }

    }
}
