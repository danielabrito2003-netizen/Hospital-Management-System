using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um membro da equipe médica.
    /// </summary>
   
    public abstract class Staff
    {
        #region Campos
        private string categoria;
        private string especialidade;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define a categoria do membro da equipe médica.
        /// </summary>
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        /// <summary>
        /// Obtém ou define a especialidade do membro da equipe médica.
        /// </summary>
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Staff com o nome, categoria e especialidade especificados.
        /// </summary>
        /// <param name="nome">Nome do membro da equipe médica.</param>
        /// <param name="categoria">Categoria do membro da equipe médica.</param>
        /// <param name="especialidade">Especialidade do membro da equipe médica.</param>
        public Staff(string nome, string categoria, string especialidade) : base(nome)
        {
            Categoria = categoria;
            Especialidade = especialidade;
        }
        #endregion

        #region Métodos adicionais
        /// <summary>
        /// Realiza um exame em um paciente.
        /// </summary>
        /// <param name="paciente">Paciente a ser examinado.</param>
        /// <param name="exame">Exame a ser realizado.</param>
        public virtual void RealizarExame(Paciente paciente, Exame exame)
        {
            // Lógica padrão para realizar um exame
        }

        /// <summary>
        /// Retorna uma representação em string do membro da equipe médica.
        /// </summary>
        /// <returns>Uma string que representa o membro da equipe médica.</returns>
        public override string ToString()
        {
            return $"Nome: {Nome}, Categoria: {Categoria}, Especialidade: {Especialidade}";
        }
        #endregion
    }
}


