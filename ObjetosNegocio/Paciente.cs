using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um paciente.
    /// </summary>
    
    public class Paciente: Pessoa
    {
        #region Campos
        private int numeroProcesso;
        private static int conta = 0;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém o número de processo único do paciente.
        /// </summary>
        public int NumeroProcesso
        {
            get { return numeroProcesso; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Paciente com o nome, categoria, especialidade e número de processo especificados.
        /// </summary>
        /// <param name="nome">Nome do paciente.</param>
        /// <param name="numeroProcesso">Número de processo do paciente.</param>
        public Paciente(string nome)
            : base(nome)
        {
            this.numeroProcesso = ++conta;
        }
        #endregion

        #region Métodos adicionais
        /// <summary>
        /// Realiza um exame no paciente.
        /// </summary>
        /// <param name="exame">Exame a ser realizado.</param>
        public void RealizarExame(Exame exame)
        {
            // Lógica para realizar um exame no paciente
        }

        /// <summary>
        /// Recebe um diagnóstico para o paciente.
        /// </summary>
        /// <param name="diagnostico">Diagnóstico recebido.</param>
        public void ReceberDiagnostico(Diagnostico diagnostico)
        {
            // Lógica para receber um diagnóstico
        }

        /// <summary>
        /// Retorna uma representação em string do paciente.
        /// </summary>
        /// <returns>String que representa o paciente.</returns>
        public override string ToString()
        {
            return $"Paciente - {Nome}, Número de Processo: {NumeroProcesso}";
        }
        #endregion
    }
}
