using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Dados
{
    public class Staffs
    {
        #region Campos Privados
        private static List<Staff> staffs;
        #endregion

        #region Construtor Estático
        static Staffs()
        {
            staffs = new List<Staff>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um membro da equipe pelo nome.
        /// </summary>
        /// <param name="nome">Nome do membro da equipe a ser procurado.</param>
        /// <returns>O membro da equipe encontrado ou null se não encontrado.</returns>
        public static Staff GetStaff(string nome)
        {
            return staffs.FirstOrDefault(s => s.Nome == nome);      //LINQ
        }

        /// <summary>
        /// Lista todos os membros da equipe.
        /// </summary>
        public static void ListarStaff()
        {
            foreach (Staff s in staffs)
                Console.WriteLine(s);
        }


        /// <summary>
        /// Lista todos os médicos na equipe.
        /// </summary>
        public static void ListarMedicos()
        {
            foreach (Staff s in staffs)
            {
                if (s is Medico)
                {
                    Console.WriteLine(s);
                }
            }
        }


        /// <summary>
        /// Lista todos os enfermeiros na equipe.
        /// </summary>
        public static void ListarEnfermeiros()
        {
            foreach (Staff s in staffs)
            {
                if (s is Enfermeiro)
                {
                    Console.WriteLine(s);
                }
            }
        }

        /// <summary>
        /// Lista todos os funcionários na equipe.
        /// </summary>
        public static void ListarFuncionarios()
        {
            foreach (Staff s in staffs)
            {
                if (s is Funcionario)
                {
                    Console.WriteLine(s);
                }
            }
        }

        /// <summary>
        /// Insere um membro da equipe na lista.
        /// </summary>
        /// <param name="s">O membro da equipe a ser inserido.</param>
        /// <returns>True se o membro da equipe foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereStaff(Staff s)
        {
            if (s == null || staffs.Contains(s)) return false;

            staffs.Add(s);
            return true;
        }
        #endregion

        /// <summary>
        /// Verifica se um médico está no sistema.
        /// </summary>
        /// <param name="nome">Nome do médico a ser verificado.</param>
        /// <returns>True se o médico estiver no sistema, False caso contrário.</returns>
        public static bool VerificaMedicoNoSistema(string nome)
        {
            for (int i = 0; i < staffs.Count; i++)
            {
                if (staffs[i] != null)
                {
                    if (staffs[i] is Medico)
                    {
                        if (staffs[i].Nome.Equals(nome))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica se um enfermeiro está no sistema.
        /// </summary>
        /// <param name="nome">Nome do enfermeiro a ser verificado.</param>
        /// <returns>True se o enfermeiro estiver no sistema, False caso contrário.</returns>
        public static bool VerificaEnfermeiroNoSistema(string nome)
        {
            for (int i = 0; i < staffs.Count; i++)
            {
                if (staffs[i] != null)
                {
                    if (staffs[i] is Enfermeiro)
                    {
                        if (staffs[i].Nome.Equals(nome))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica se um funcionário está no sistema.
        /// </summary>
        /// <param name="nome">Nome do funcionário a ser verificado.</param>
        /// <returns>True se o funcionário estiver no sistema, False caso contrário.</returns>
        public static bool VerificaFuncionarioNoSistema(string nome)
        {
            for (int i = 0; i < staffs.Count; i++)
            {
                if (staffs[i] != null)
                {
                    if (staffs[i] is Funcionario)
                    {
                        if (staffs[i].Nome.Equals(nome))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool GravaStaffsFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, staffs);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Staff> LerStaffsDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Staff> staffsLidas = (List<Staff>)bf.Deserialize(s);
                    return staffsLidas;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }




    }

}


