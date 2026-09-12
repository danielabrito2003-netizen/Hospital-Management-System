using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    public class Medicos
    {
        #region Campos Privados
        private static List<Medico> medicos;
        #endregion

        #region Construtor Estático
        static Medicos()
        {
            medicos = new List<Medico>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um médico pelo nome.
        /// </summary>
        /// <param name="nome">Nome do médico a ser procurado.</param>
        /// <returns>O médico encontrado ou null se não encontrado.</returns>
        public static Medico GetMedico(string nome)
        {
            return medicos.FirstOrDefault(m => m.Nome == nome);
        }


        /// <summary>
        /// Lista todos os médicos na equipe.
        /// </summary>
        public static void ListarMedicos()
        {
            foreach (Staff s in medicos)
            {
                if (s is Medico)
                {
                    Console.WriteLine(s);
                }
            }
        }

        /// <summary>
        /// Insere um médico na lista.
        /// </summary>
        /// <param name="m">O médico a ser inserido.</param>
        /// <returns>True se o médico foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereMedico(Medico m)
        {
            if (m == null || medicos.Contains(m)) return false;

            medicos.Add(m);
            return true;
        }

        public static bool GravaMedicosFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, medicos);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Medico> LerMedicosDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Medico> medicosLidas = (List<Medico>)bf.Deserialize(s);
                    return medicosLidas;
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









