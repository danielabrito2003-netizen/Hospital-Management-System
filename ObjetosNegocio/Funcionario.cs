using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um funcionário em uma instalação médica.
    /// </summary>
   
    public class Funcionario
    {
        #region Campos
        private string setor;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o setor ao qual o funcionário está associado.
        /// </summary>
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Funcionario com o nome, categoria, especialidade e setor especificados.
        /// </summary>
        /// <param name="nome">Nome do funcionário.</param>
        /// <param name="categoria">Categoria do funcionário.</param>
        /// <param name="especialidade">Especialidade do funcionário.</param>
        /// <param name="setor">Setor ao qual o funcionário está associado.</param>
        public Funcionario(string nome, string categoria, string especialidade, string setor)
            : base(nome, categoria, especialidade)
        {
            Setor = setor;
        }
        #endregion

        #region Métodos adicionais
        /// <summary>
        /// Realiza uma tarefa específica.
        /// </summary>
        /// <param name="tarefa">Tarefa a ser realizada.</param>
        public void RealizarTarefa(string tarefa)
        {
            // Lógica para realizar uma tarefa específica
        }

        /// <summary>
        /// Retorna uma representação em string do funcionário.
        /// </summary>
        /// <returns>String que representa o funcionário.</returns>
        public override string ToString()
        {
            return $"Funcionário - {base.ToString()}, Setor: {Setor}";
        }
        #endregion
    }
}






