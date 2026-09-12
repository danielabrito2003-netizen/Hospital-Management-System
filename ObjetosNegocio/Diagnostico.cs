using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um diagnóstico médico.
    /// </summary>
    
    public class Diagnostico
    {
        #region Campos
        private string descricao;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define a descrição do diagnóstico.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Diagnostico com a descrição especificada.
        /// </summary>
        /// <param name="descricao">Descrição do diagnóstico.</param>
        public Diagnostico(string descricao)
        {
            Descricao = descricao;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retorna uma representação em string do diagnóstico.
        /// </summary>
        /// <returns>String que representa o diagnóstico.</returns>
        public override string ToString()
        {
            return $"Diagnóstico - Descrição: {Descricao}";
        }
        #endregion
    }
}


