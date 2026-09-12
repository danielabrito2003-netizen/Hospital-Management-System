using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um enfermeiro.
    /// </summary>
   
    public class Enfermeiro
    {
        #region Campos
        private int numeroIdentificacaoEnf;
        private static int conta = 0;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém o número de identificação único do enfermeiro.
        /// </summary>
        public int NumeroIdentificacaoEnf
        {
            get { return numeroIdentificacaoEnf; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Enfermeiro com o nome, categoria, especialidade e setor especificados.
        /// </summary>
        /// <param name="nome">Nome do enfermeiro.</param>
        /// <param name="categoria">Categoria do enfermeiro.</param>
        /// <param name="especialidade">Especialidade do enfermeiro.</param>
        public Enfermeiro(string nome, string categoria, string especialidade)
            : base(nome, categoria, especialidade)
        {
            numeroIdentificacaoEnf = ++conta;
        }
        #endregion

        #region Métodos adicionais
        /// <summary>
        /// Realiza um exame em um paciente.
        /// </summary>
        /// <param name="paciente">Paciente a ser examinado.</param>
        /// <param name="exame">Exame a ser realizado.</param>
        public override void RealizarExame(Paciente paciente, Exame exame)
        {
            // Lógica específica para enfermeiros ao realizar um exame
        }

        /// <summary>
        /// Administra um medicamento a um paciente.
        /// </summary>
        /// <param name="paciente">Paciente a receber o medicamento.</param>
        /// <param name="medicamento">Nome do medicamento.</param>
        public void AdministrarMedicamento(Paciente paciente, string medicamento)
        {
            // Lógica para administrar um medicamento
        }

        /// <summary>
        /// Retorna uma representação em string do enfermeiro.
        /// </summary>
        /// <returns>String que representa o enfermeiro.</returns>
        public override string ToString()
        {
            return $"Enfermeiro - {base.ToString()}, Número Identificação do Enfermeiro: {NumeroIdentificacaoEnf}";
        }
        #endregion
    }
}


