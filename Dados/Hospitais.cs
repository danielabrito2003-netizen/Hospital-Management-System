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
    public class Hospitais
    {
        #region Campos Privados
        private static Hospital hospital;
        #endregion

        #region Construtor Estático
        static Hospitais()
        {
            hospital = new Hospital("Hospital", "Endereço");
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um hospital pelo nome.
        /// </summary>
        /// <param name="nome">Nome do hospital a ser procurado.</param>
        /// <returns>O hospital encontrado ou null se não encontrado.</returns>
        public static Hospital GetHospital(string nome)
        {
            return hospital;
        }

        /// <summary>
        /// Insere um hospital na lista.
        /// </summary>
        /// <param name="h">O hospital a ser inserido.</param>
        /// <returns>True se o hospital foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereHospital(Hospital h)
        {
            if (h == null) return false;

            hospital = h;
            return true;
        }

        public static bool GravaHospitaisFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, hospital);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Hospital> LerHospitaisDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Hospital> hospitaisLidas = (List<Hospital>)bf.Deserialize(s);
                    return hospitaisLidas;
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

