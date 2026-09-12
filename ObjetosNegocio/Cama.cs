using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjetosNegocio
{
    /// <summary>
    /// Representa uma cama em uma instalação médica.
    /// </summary>
    [Serializable]
    public class Cama
    {
        #region Campos
        private int numero;
        private bool ocupada;
        private Paciente paciente;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o número da cama.
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Obtém ou define um valor que indica se a cama está ocupada.
        /// </summary>
        public bool Ocupada
        {
            get { return ocupada; }
            set { ocupada = value; }
        }

        /// <summary>
        /// Obtém ou define o paciente associado à cama, caso esteja ocupada.
        /// </summary>
        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Cama com o número especificado.
        /// </summary>
        /// <param name="numero">Número da cama.</param>
        public Cama(int numero)
        {
            Numero = numero;
            Ocupada = false;
            Paciente = null;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Ocupa a cama com um paciente.
        /// </summary>
        /// <param name="paciente">Paciente a ser associado à cama.</param>
        public void OcuparCama(Paciente paciente)
        {
            Ocupada = true;
            Paciente = paciente;
        }

        /// <summary>
        /// Libera a cama, tornando-a disponível.
        /// </summary>
        public void LiberarCama()
        {
            Ocupada = false;
            Paciente = null;
        }

        /// <summary>
        /// Retorna uma representação em string da cama.
        /// </summary>
        /// <returns>String que representa a cama.</returns>
        public override string ToString()
        {
            return $"Cama - Número: {Numero}, Ocupada: {Ocupada}, Paciente: {Paciente?.Nome ?? "Nenhum"}";
        }
        #endregion
    }
}



