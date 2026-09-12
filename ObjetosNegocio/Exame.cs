using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa um exame médico.
    /// </summary>
  
    public class Exame
    {
        #region Campos
        private string tipo;
        private decimal custo;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o tipo de exame.
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtém ou define o custo do exame.
        /// </summary>
        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Exame com o tipo e custo especificados.
        /// </summary>
        /// <param name="tipo">Tipo de exame.</param>
        /// <param name="custo">Custo do exame.</param>
        public Exame(string tipo, decimal custo)
        {
            Tipo = tipo;
            Custo = custo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retorna uma representação em string do exame.
        /// </summary>
        /// <returns>String que representa o exame.</returns>
        public override string ToString()
        {
            return $"Exame - Tipo: {Tipo}, Custo: {Custo:C}";
        }
        #endregion
    }
}

