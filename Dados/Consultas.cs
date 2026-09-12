using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// 
    /// </summary>
    public class Consultas
    {
        #region Campos Privados
        private static List<Consulta> consultas;
        #endregion

        #region Construtor Estático
        static Consultas()
        {
            consultas = new List<Consulta>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém uma consulta pelo médico e paciente.
        /// </summary>
        /// <param name="medico">Médico da consulta.</param>
        /// <param name="paciente">Paciente da consulta.</param>
        /// <returns>A consulta encontrada ou null se não encontrada.</returns>
        public static Consulta GetConsulta(Staff medico, Paciente paciente)
        {
            return consultas.FirstOrDefault(c => c.Medico == medico && c.Paciente == paciente);
        }

        /// <summary>
        /// Insere uma consulta na lista.
        /// </summary>
        /// <param name="c">A consulta a ser inserida.</param>
        /// <returns>True se a consulta foi inserida com sucesso, False caso contrário.</returns>
        public static bool InsereConsulta(Consulta c)
        {
            if (c == null || consultas.Contains(c)) return false;
            
            consultas.Add(c);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool GravarConsultasFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, consultas);
                s.Close();
            }
            catch (Exception e) 
            {
                throw e;
            
            }
            return false;


        }

        public static List<Consulta> LerConsultasDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Consulta> consultasLidas = (List<Consulta>)bf.Deserialize(s);
                    return consultasLidas; 
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
        /// <summary>
        /// Lista todas as consultas no hospital.
        /// </summary>
        public static void ListarConsultas()
        {
            foreach (Consulta c in consultas)
                if (c != null)
                    Console.WriteLine(c);
        }
    

        #endregion
    }
}


