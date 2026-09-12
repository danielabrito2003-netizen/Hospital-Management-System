using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um hospital.
    /// </summary>
  
    public class Hospital
    {
        #region Campos
        private string nome;
        private string endereco;
        private Staff[] equipa;
        private Paciente[] pacientes;
        private Consulta[] consultas;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o nome do hospital.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o endereço do hospital.
        /// </summary>
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Hospital com o nome e endereço especificados.
        /// </summary>
        /// <param name="nome">Nome do hospital.</param>
        /// <param name="endereco">Endereço do hospital.</param>
        public Hospital(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            equipa = new Staff[100]; // Tamanho arbitrário
            pacientes = new Paciente[100]; // Tamanho arbitrário
            consultas = new Consulta[100]; // Tamanho arbitrário
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Retorna uma representação em string do hospital.
        /// </summary>
        /// <returns>String que representa o hospital.</returns>
        public override string ToString()
        {
            return $"Hospital: {Nome}, Endereço: {Endereco}";
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Obtem um paciente pelo nome.
        /// </summary>
        /// <param name="nome">Nome do paciente.</param>
        /// <returns>O paciente correspondente ou null se não encontrado.</returns>
        private Paciente GetPaciente(string nome)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i]?.Nome == nome)
                {
                    return pacientes[i];
                }
            }

            return null;
        }

        /// <summary>
        /// Obtem um médico pelo nome.
        /// </summary>
        /// <param name="nome">Nome do médico.</param>
        /// <returns>O médico correspondente ou null se não encontrado.</returns>
        private Staff GetMedico(string nome)
        {
            for (int i = 0; i < equipa.Length; i++)
            {
                if (equipa[i] is Medico && equipa[i].Nome.Equals(nome))
                {
                    return equipa[i];
                }
            }

            return null;
        }

        /// <summary>
        /// Obtém um enfermeiro pelo nome.
        /// </summary>
        /// <param name="nome">Nome do enfermeiro.</param>
        /// <returns>O enfermeiro correspondente ou null se não encontrado.</returns>
        private Staff GetEnfermeiro(string nome)
        {
            for (int i = 0; i < equipa.Length; i++)
            {
                if (equipa[i] is Enfermeiro && equipa[i].Nome.Equals(nome))
                {
                    return equipa[i];
                }
            }

            return null;
        }

        /// <summary>
        /// Obtém um funcionário pelo nome.
        /// </summary>
        /// <param name="nome">Nome do funcionário.</param>
        /// <returns>O funcionário correspondente ou null se não encontrado.</returns>
        private Staff GetFuncionario(string nome)
        {
            for (int i = 0; i < equipa.Length; i++)
            {
                if (equipa[i] is Funcionario && equipa[i].Nome.Equals(nome))
                {
                    return equipa[i];
                }
            }

            return null;
        }

        #endregion
    }
}
