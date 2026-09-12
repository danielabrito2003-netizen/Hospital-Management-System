using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ObjetosNegocio
{
    /// <summary>
    /// Representa uma consulta médica.
    /// </summary>

    [Serializable]
    public class Consulta
    {
        #region Campos
        private Staff medico;
        private Paciente paciente;
        private string data;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o médico associado à consulta.
        /// </summary>
        public Staff Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        /// <summary>
        /// Obtém ou define o paciente associado à consulta.
        /// </summary>
        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        /// <summary>
        /// Obtém ou define a data da consulta.
        /// </summary>
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Inicializa uma nova instância da classe Consulta com o médico, paciente e data especificados.
        /// </summary>
        /// <param name="medico">Médico associado à consulta.</param>
        /// <param name="paciente">Paciente associado à consulta.</param>
        /// <param name="data">Data da consulta.</param>
        public Consulta(Staff medico, Paciente paciente, string data)
        {
            Medico = medico;
            Paciente = paciente;
            Data = data;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retorna uma representação em string da consulta.
        /// </summary>
        /// <returns>String que representa a consulta.</returns>
        public override string ToString()
        {
            return $"Consulta - Paciente: {Paciente.Nome}, Médico: {Medico.Nome}, Data: {Data}";
        }
        #endregion
    }
}

