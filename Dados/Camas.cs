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
    public class Camas
    {
        #region Campos Privados
        private static List<Cama> camas;
        #endregion

        #region Construtor Estático
        static Camas()
        {
            camas = new List<Cama>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém uma cama pelo número.
        /// </summary>
        /// <param name="numero">Número da cama a ser procurado.</param>
        /// <returns>A cama encontrada ou null se não encontrada.</returns>
        public static Cama GetCama(int numero)
        {

            if (numero < 0)
            {
                //throw new CamasException("Numero negativo!!!!");
                return null;
            }

            //foreach(Cama c in camas)
            //{
            //    if (c.Numero==numero) return c;
            //}

            return camas.FirstOrDefault(c => c.Numero == numero);
        }

        /// <summary>
        /// Insere uma cama na lista.
        /// </summary>
        /// <param name="c">A cama a ser inserida.</param>
        /// <returns>True se a cama foi inserida com sucesso, False caso contrário.</returns>
        public static bool InsereCama(Cama c)
        {
            if (c == null || camas.Contains(c)) return false;

            //try
            //{
            //    GetCama(c.Numero);
            //}
            //catch (CamasException e)
            //{ 
            //    //qualquer coisa
            //    throw e;
            //}


            camas.Add(x);
            return true;
        }


        public static bool GravaCamasFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, camas);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
            
        }

        public static List<Cama> LerCamasDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Cama> camasLidas = (List<Cama>)bf.Deserialize(s);
                    return camasLidas;
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

