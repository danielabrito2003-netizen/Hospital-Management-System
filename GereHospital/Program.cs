using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;
using RegrasNegocio;

namespace GereHospital
{
    internal class Program
    {
        #region Métodos Principais

        /// <summary>
        /// Método principal do programa.
        /// </summary>
        /// <param name="args">Argumentos de linha de comando.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de Gerenciamento Hospitalar ---");

            // Criação de um paciente de exemplo
            /*Paciente paciente = new Paciente("Paciente Exemplo");

            // Chama o método para inserir o paciente no hospital
            bool insercaoPacienteBemSucedida = GereHospitalRN.InserePacienteHospital(paciente);

            // Verifica o resultado da inserção do paciente
            if (insercaoPacienteBemSucedida)
            {
                Console.WriteLine("Paciente inserido com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha ao inserir o paciente. Verifique os dados e tente novamente.");
            } */

            // Exibe o menu principal
            MostrarMenuPrincipal();
        }

        #endregion Métodos Principais

        #region Métodos Auxiliares

        /// <summary>
        /// Exibe o menu principal do sistema.
        /// </summary>
        private static void MostrarMenuPrincipal()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu Principal ---");
                Console.WriteLine("1. Adicionar Paciente");
                Console.WriteLine("2. Listar Pacientes");
                Console.WriteLine("3. Adicionar Médico");
                Console.WriteLine("4. Listar Médicos");
                Console.WriteLine("5. Adiconar Enfermeiro");
                Console.WriteLine("6. Listar Enfermeiro");
                Console.WriteLine("7. Adicionar Funcionario");
                Console.WriteLine("8. Listar Funcionario");
                Console.WriteLine("9. Agendar Consulta");
                Console.WriteLine("10. Listar Consultas");
                Console.WriteLine("11. Sair");

                Console.Write("Escolha uma opção (1-11): ");
                string escolha = Console.ReadLine();

                ProcessarEscolhaMenu(escolha);
            }
        }

        /// <summary>
        /// Processa a escolha do menu realizada pelo usuário.
        /// </summary>
        /// <param name="escolha">Opção escolhida pelo usuário.</param>
        private static void ProcessarEscolhaMenu(string escolha)
        {
            switch (escolha)
            {
                case "1":
                    AdicionarPaciente();
                    break;
                case "2":
                    ListarPacientes();
                    break;
                case "3":
                    AdicionarMedico();
                    break;
                case "4":
                    ListarMedicos();
                    break;
                case "5":
                    AdicionarEnfermeiro();
                    break;
                case "6":
                    ListarEnfermeiro();
                    break;
                case "7":
                    AdicionarFuncionario();
                    break;
                case "8":
                    ListarFuncionario();
                    break;
                case "9":
                    AgendarConsulta();
                    break;
                case "10":
                    ListarConsultas();
                    break;
                case "11":
                    Console.WriteLine("Saindo do programa. Até logo!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        /// <summary>
        /// Realiza a operação de adicionar um paciente.
        /// </summary>
        private static void AdicionarPaciente()
        {
            Console.Write("Digite o nome do paciente: ");
            string nomePaciente = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nomePaciente))
            {
                Paciente paciente = new Paciente(nomePaciente);
                if (GereHospitalRN.AdicionarPaciente(paciente))
                    Console.WriteLine($"Paciente {nomePaciente} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nome do paciente inválido.");
            }
        }

        /// <summary>
        /// Realiza a operação de listar pacientes.
        /// </summary>
        private static void ListarPacientes()
        {
            Console.WriteLine("PACIENTES: ");

            GereHospitalRN.ListarPacientes();
        }

        /// <summary>
        /// Realiza a operação de adicionar um médico.
        /// </summary>
        private static void AdicionarMedico()
        {
            Console.WriteLine("Digite o nome do médico: ");
            string nomeMedico = Console.ReadLine();

            Console.WriteLine("Digite a categoria do médico: ");
            string categoria = Console.ReadLine();

            Console.WriteLine("Digite a especialidade do médico: ");
            string especialidade = Console.ReadLine();

            Console.WriteLine("Digite a numero da ordem do médico: ");
            int numeroOrdem = Convert.ToInt32(Console.ReadLine());


            if (!string.IsNullOrWhiteSpace(nomeMedico) && !string.IsNullOrWhiteSpace(categoria) && !string.IsNullOrWhiteSpace(especialidade))
            {
                Medico medico = new Medico(nomeMedico, categoria, especialidade, numeroOrdem);
                GereHospitalRN.AdicionarStaff(medico);
                Console.WriteLine($"Médico {nomeMedico} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Informações do médico inválidas.");
            }
        }

        /// <summary>
        /// Realiza a operação de listar médicos.
        /// </summary>
        private static void ListarMedicos()
        {
            Console.WriteLine("MÉDICOS: ");
            GereHospitalRN.ListarMedicos();
        }

        /// <summary>
        /// Realiza a operação de adicionar um enfermeiro.
        /// </summary>
        private static void AdicionarEnfermeiro()
        {
            Console.WriteLine("Digite o nome do enfermeiro: ");
            string nomeEnfermeiro = Console.ReadLine();

            Console.WriteLine("Digite a categoria do enfermeiro: ");
            string categoria = Console.ReadLine();

            Console.WriteLine("Digite a especialidade do enfermeiro: ");
            string especialidade = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nomeEnfermeiro) && !string.IsNullOrWhiteSpace(categoria) && !string.IsNullOrWhiteSpace(especialidade))
            {
                Enfermeiro enfermeiro = new Enfermeiro(nomeEnfermeiro, categoria, especialidade);
                GereHospitalRN.AdicionarStaff(enfermeiro);
                Console.WriteLine($"Enfermeiro {nomeEnfermeiro} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Informações do enfermeiro inválidas.");
            }
        }

        /// <summary>
        /// Realiza a operação de listar enfermeiros.
        /// </summary>
        private static void ListarEnfermeiro()
        {
            Console.WriteLine("ENFERMEIROS: ");
            GereHospitalRN.ListarEnfermeiros();
        }

        /// <summary>
        /// Realiza a operação de adicionar um funcionário.
        /// </summary>
        private static void AdicionarFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Digite a categoria do funcionário: ");
            string categoria = Console.ReadLine();

            Console.WriteLine("Digite a especialidade do funcionário: ");
            string especialidade = Console.ReadLine();

            Console.WriteLine("Digite o setor do funcionário: ");
            string setor = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nomeFuncionario) && !string.IsNullOrWhiteSpace(categoria) && !string.IsNullOrWhiteSpace(especialidade) && !string.IsNullOrWhiteSpace(setor))
            {
                Funcionario funcionario = new Funcionario(nomeFuncionario, categoria, especialidade, setor);
                GereHospitalRN.AdicionarStaff(funcionario);
                Console.WriteLine($"Funcionário {nomeFuncionario} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Informações do funcionário inválidas.");
            }
        }

        /// <summary>
        /// Realiza a operação de listar funcionários.
        /// </summary>
        private static void ListarFuncionario()
        {
            Console.WriteLine("FUNCIONÁRIOS: ");
            GereHospitalRN.ListarFuncionarios();
        }

        /// <summary>
        /// Realiza a operação de agendar uma consulta.
        /// </summary>
        private static void AgendarConsulta()
        {
            Console.WriteLine("AGENDAR CONSULTA: ");

            Console.WriteLine("Insira o seu nome: ");
            string nomePaciente = Console.ReadLine();

            if (GereHospitalRN.VerificaPacienteNoSistema(nomePaciente))
            {
                Console.WriteLine("Digite o nome do médico: ");
                string nomeMedico = Console.ReadLine();

                if (GereHospitalRN.VerificaMedicoNoSistema(nomeMedico))
                {
                    Console.WriteLine("Qual é a data da consulta que pretende: ");
                    string data = Console.ReadLine();

                    GereHospitalRN.AdicionarConsulta(nomePaciente, nomeMedico, data);

                    Console.WriteLine("Consulta marcada com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Esse Médico não existe!!!");
                }
            }
            else
            {
                Console.WriteLine("Ainda não está registrado no sistema! Vamos criar um perfil para si!");
                Console.WriteLine("Perfil Criado!!!");
                Paciente paciente = new Paciente(nomePaciente);
                GereHospitalRN.AdicionarPaciente(paciente);

                Console.WriteLine("Digite o nome do médico: ");
                string nomeMedico = Console.ReadLine();

                if (GereHospitalRN.VerificaMedicoNoSistema(nomeMedico))
                {
                    Console.WriteLine("Qual é a data da consulta que pretende: ");
                    string data = Console.ReadLine();

                    if (GereHospitalRN.AdicionarConsulta(nomePaciente, nomeMedico, data))
                        Console.WriteLine("Consulta marcada com sucesso!!!");
                    else
                        Console.WriteLine("Erro a inserir consulta!!!");
                }
                else
                {
                    Console.WriteLine("Esse Médico não existe!!!");
                }
            }
        }

        /// <summary>
        /// Realiza a operação de listar consultas.
        /// </summary>
        private static void ListarConsultas()
        {
            Console.WriteLine("CONSULTAS: ");

            GereHospitalRN.ListarConsultas();
        }

        

        #endregion Métodos Auxiliares
    }
}
