using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um médico.
    /// </summary>
    
    public class Medico
    {
        #region Campos
        private int numeroOrdemMedicos;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém o número de ordem único do médico.
        /// </summary>
        public int NumeroOrdemMedicos
        {
            get { return numeroOrdemMedicos; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Medico com o nome, categoria, especialidade e número de ordem especificados.
        /// </summary>
        /// <param name="nome">Nome do médico.</param>
        /// <param name="categoria">Categoria do médico.</param>
        /// <param name="especialidade">Especialidade do médico.</param>
        /// <param name="numeroOrdem">Número de ordem do médico.</param>
        public Medico(string nome, string categoria, string especialidade, int numeroOrdem)
            : base(nome, categoria, especialidade)
        {
            numeroOrdemMedicos = numeroOrdem;
        }
        #endregion

        #region Métodos adicionais
        /// <summary>
        /// Prescreve uma receita a um paciente.
        /// </summary>
        /// <param name="paciente">Paciente a receber a receita.</param>
        /// <param name="medicamento">Nome do medicamento prescrito.</param>
        public void PrescreverReceita(Paciente paciente, string medicamento)
        {
            // Lógica para prescrever uma receita
        }

        /// <summary>
        /// Realiza uma cirurgia em um paciente.
        /// </summary>
        /// <param name="paciente">Paciente a ser operado.</param>
        /// <param name="descricao">Descrição da cirurgia.</param>
        public void RealizarCirurgia(Paciente paciente, string descricao)
        {
            // Lógica para realizar uma cirurgia
        }

        /// <summary>
        /// Retorna uma representação em string do médico.
        /// </summary>
        /// <returns>String que representa o médico.</returns>
        public override string ToString()
        {
            return $"Médico - {base.ToString()}, Número Ordem dos Médicos: {NumeroOrdemMedicos}";
        }
        #endregion
    }
}
