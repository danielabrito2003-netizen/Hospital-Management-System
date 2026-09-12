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
    public class Exames
    {
        #region Campos Privados
        private static List<Exame> exames;
        #endregion

        #region Construtor Estático
        static Exames()
        {
            exames = new List<Exame>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um exame pelo tipo.
        /// </summary>
        /// <param name="tipo">Tipo do exame a ser procurado.</param>
        /// <returns>O exame encontrado ou null se não encontrado.</returns>
        public static Exame GetExame(string tipo)
        {
       
            return exames.FirstOrDefault(e => e.Tipo == tipo);
        }

        /// <summary>
        /// Insere um exame na lista.
        /// </summary>
        /// <param name="e">O exame a ser inserido.</param>
        /// <returns>True se o exame foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereExame(Exame e)
        {
            if (e == null || exames.Contains(e)) return false;

            exames.Add(e);
            return true;
        }

        public static bool GravaExamesFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, exames);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Exame> LerExamesDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Exame> examesLidas = (List<Exame>)bf.Deserialize(s);
                    return examesLidas;
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


