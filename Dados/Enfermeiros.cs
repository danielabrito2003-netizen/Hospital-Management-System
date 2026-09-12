using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Enfermeiros
    {
        #region Campos Privados
        private static List<Enfermeiro> enfermeiros;
        #endregion

        #region Construtor Estático
        static Enfermeiros()
        {
            enfermeiros = new List<Enfermeiro>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um enfermeiro pelo nome.
        /// </summary>
        /// <param name="nome">Nome do enfermeiro a ser procurado.</param>
        /// <returns>O enfermeiro encontrado ou null se não encontrado.</returns>
        public static Enfermeiro GetEnfermeiro(string nome)
        {
            return enfermeiros.FirstOrDefault(e => e.Nome == nome);
        }

        /// <summary>
        /// Insere um enfermeiro na lista.
        /// </summary>
        /// <param name="e">O enfermeiro a ser inserido.</param>
        /// <returns>True se o enfermeiro foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereEnfermeiro(Enfermeiro e)
        {
            if (e == null || enfermeiros.Contains(e)) return false;

            enfermeiros.Add(e);
            return true;
        }

        public static bool GravaEnfermeirosFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, enfermeiros);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Enfermeiro> LerEnfermeirosDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Enfermeiro> enfermeirosLidas = (List<Enfermeiro>)bf.Deserialize(s);
                    return enfermeirosLidas;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}





