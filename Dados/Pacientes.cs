using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;


namespace Dados
{
    public class Pacientes
    {
        #region Campos Privados
        private static List<Paciente> pacientes;
        #endregion

        #region Construtor Estático
        static Pacientes()
        {
            pacientes = new List<Paciente>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um paciente pelo nome.
        /// </summary>
        /// <param name="nome">Nome do paciente a ser procurado.</param>
        /// <returns>O paciente encontrado ou null se não encontrado.</returns>
        public static Paciente GetPaciente(string nome)
        {
            return pacientes.FirstOrDefault(p => p.Nome == nome);
        }

        /// <summary>
        /// Insere um paciente na lista.
        /// </summary>
        /// <param name="p">O paciente a ser inserido.</param>
        /// <returns>True se o paciente foi inserido com sucesso, False caso contrário.</returns>
        public static bool InserePaciente(Paciente p)
        {
            if (p == null || pacientes.Contains(p)) return false;

            pacientes.Add(p);
            return true;
        }

        /// <summary>
        /// Lista todos os pacientes no hospital.
        /// </summary>
        public static void ListarPacientes()
        {
            foreach (Paciente p in pacientes)
                if (p != null)
                    Console.WriteLine(p);
        }

        /// <summary>
        /// Verifica se um paciente está no sistema.
        /// </summary>
        /// <param name="nome">Nome do paciente a ser verificado.</param>
        /// <returns>True se o paciente estiver no sistema, False caso contrário.</returns>
        public static bool VerificaPacienteNoSistema(string nome)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i] != null)
                {
                    if (pacientes[i].Nome == nome)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool GravaPacientesFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, pacientes);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Paciente> LerPacientesDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Paciente> pacientesLidas = (List<Paciente>)bf.Deserialize(s);
                    return pacientesLidas;
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

