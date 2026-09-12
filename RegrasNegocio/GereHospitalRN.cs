using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegrasNegocio;
using Dados;
using ObjetosNegocio;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections.Concurrent;



namespace RegrasNegocio
{
    /// <summary>
    /// Lógica de negócio relacionada ao Hospital.
    /// </summary>
    public class GereHospitalRN
    {
        #region Métodos Públicos

        /// <summary>
        /// Insere um paciente no hospital.
        /// </summary>
        /// <param name="paciente">Objeto Paciente a ser inserido.</param>
        /// <returns>True se a inserção for bem-sucedida, False caso contrário.</returns>
        public static bool InserePacienteHospital(Paciente p)
        {
            // Verifica se o nome do paciente não está vazio ou composto apenas por espaços em branco.
            if (string.IsNullOrWhiteSpace(p.Nome))
            {
                //Console.WriteLine("O nome do paciente não pode estar vazio.");
                return false;
            }

            // Chama o método de inserção da classe Pacientes.
            bool insercaoBemSucedida = Pacientes.InserePaciente(p);

            // Retorna o resultado da inserção.
            return insercaoBemSucedida;
        }

        public static bool InsereMedicoHospital(Medico m)
        {
            // Verifica se o nome do medico não está vazio ou composto apenas por espaços em branco. 
            if (string.IsNullOrWhiteSpace(m.Nome))
            {
                Console.WriteLine("O nome do medico não pode estar vazio.");
                return false;
            }

            // Chama o método de inserção da classe Medicos. 
            bool insercaoBemSucedida = Medicos.InsereMedico(m);

            // Retorna o resultado da inserção. 
            return insercaoBemSucedida;
        }

        public static bool InsereEnfermeiroHospital(Enfermeiro e)
        {
            // Verfica se o nome do enfermeiro não está vazio ou composto apenas por espaços em branco. 
            if (string.IsNullOrWhiteSpace(e.Nome))
            {
                Console.WriteLine("O nome do enfermeiro não pode estar vazio."); 
                return false;
            }

            // Chama o método de inserção da classe Enfermeiro.
            bool insercaoBemSucedida = Enfermeiros.InsereEnfermeiro(e);

            //Retorna o resultado da inserção. 
            return insercaoBemSucedida;
        }

        public static bool InsereStaffHospital(Staff s)
        {
            // Verfica se o nome do staff não está vazio ou composto apenas por espaços em branco. 
            if (string.IsNullOrWhiteSpace(s.Nome))
            {
                Console.WriteLine("O nome do staff não pode estar vazio.");
                return false;
            }

            // Chama o método de inserção da classe Staff.
            bool insercaoBemSucedida = Staffs.InsereStaff(s);

            //Retorna o resultado da inserção. 
            return insercaoBemSucedida;
        }

        public static bool AdicionarPaciente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nome))
            {
                Console.WriteLine("O nome do paciente não pode estar vazio.");
                return false;
            }

            // Chama o método de inserção da classe Staff.
            bool insercaoBemSucedida = Pacientes.InserePaciente(paciente);

            //Retorna o resultado da inserção. 
            return insercaoBemSucedida;
        }

        public static bool VerificaMedicoNoSistema(string nomeMedico)
        {
            if (string.IsNullOrWhiteSpace(nomeMedico))
            {
                Console.WriteLine("O nome do medico não pode estar vazio.");
                return false;
            }

            // Chama o método de verificacao de medico
            bool verificacaoBemSucedida = Staffs.VerificaMedicoNoSistema(nomeMedico);

            //Retorna o resultado da verificacao. 
            return verificacaoBemSucedida;
        }

        public static void ListarConsultas()
        {
            Consultas.ListarConsultas();
        }

        public static bool VerificaPacienteNoSistema(string nomePaciente)
        {
            if (string.IsNullOrWhiteSpace(nomePaciente))
            {
                Console.WriteLine("O nome do paciente não pode estar vazio.");
                return false;
            }

            // Chama o método de verificacao de medico
            bool verificacaoBemSucedida = Pacientes.VerificaPacienteNoSistema(nomePaciente);

            //Retorna o resultado da verificacao. 
            return verificacaoBemSucedida;
        }

        public static bool AdicionarConsulta(string nomePaciente, string nomeMedico, string data)
        {
            if (string.IsNullOrWhiteSpace(nomePaciente))
            {
                Console.WriteLine("O nome do paciente não pode estar vazio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(nomeMedico))
            {
                Console.WriteLine("O nome do medico não pode estar vazio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("A data não pode estar vazio.");
                return false;
            }

            Medico m = Medicos.GetMedico(nomeMedico);
            if (m == null) {
                Console.WriteLine("Não existe medico com esse nome");
                return false;
            }

            Paciente p = Pacientes.GetPaciente(nomePaciente);
            if (p == null)
            {
                Console.WriteLine("Nao existe paciente com esse nome");
                return false;
            }

            Consulta c = new Consulta(m, p, data);

            // Chama o método de inserção da classe Staff.
            bool insercaoBemSucedida = Consultas.InsereConsulta(c);

            //Retorna o resultado da inserção. 
            return insercaoBemSucedida;
        }

        public static void ListarFuncionarios()
        {
            Staffs.ListarFuncionarios();
        }

        public static void ListarEnfermeiros()
        {
            Staffs.ListarEnfermeiros();
        }

        public static void ListarMedicos()
        {
            Staffs.ListarMedicos();
        }

        public static bool AdicionarStaff(Staff staff)
        {
            // Verfica se o nome do staff não está vazio ou composto apenas por espaços em branco. 
            if (string.IsNullOrWhiteSpace(staff.Nome))
            {
                Console.WriteLine("O nome do medico não pode estar vazio.");
                return false;
            }

            // Chama o método de inserção da classe Staff.
            bool insercaoBemSucedida = Staffs.InsereStaff(staff);

            //Retorna o resultado da inserção. 
            return insercaoBemSucedida;
        }

        public static void ListarPacientes()
        {
            Pacientes.ListarPacientes();
        }




        #endregion Métodos Públicos
    }
}
