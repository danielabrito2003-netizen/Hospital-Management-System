using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;


namespace Dados
{
    public class Funcionarios
    {
        #region Campos Privados
        private static List<Funcionario> funcionarios;
        #endregion

        #region Construtor Estático
        static Funcionarios()
        {
            funcionarios = new List<Funcionario>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um funcionário pelo nome.
        /// </summary>
        /// <param name="nome">Nome do funcionário a ser procurado.</param>
        /// <returns>O funcionário encontrado ou null se não encontrado.</returns>
        public static Funcionario GetFuncionario(string nome)
        {
            return funcionarios.FirstOrDefault(f => f.Nome == nome);
        }

        /// <summary>
        /// Insere um funcionário na lista.
        /// </summary>
        /// <param name="f">O funcionário a ser inserido.</param>
        /// <returns>True se o funcionário foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereFuncionario(Funcionario f)
        {
            if (f == null || funcionarios.Contains(f)) return false;

            funcionarios.Add(f);
            return true;
        }

        public static bool GravaFuncionariosFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, funcionarios);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Funcionario> LerFuncionariosDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Funcionario> funcionariosLidas = (List<Funcionario>)bf.Deserialize(s);
                    return funcionariosLidas;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion
        }
    }
}


