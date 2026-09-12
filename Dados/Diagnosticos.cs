using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Diagnosticos
    {
        #region Campos Privados
        private static List<Diagnostico> diagnosticos;
        #endregion

        #region Construtor Estático
        static Diagnosticos()
        {
            diagnosticos = new List<Diagnostico>();
        }
        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Obtém um diagnóstico pela descrição.
        /// </summary>
        /// <param name="descricao">Descrição do diagnóstico a ser procurado.</param>
        /// <returns>O diagnóstico encontrado ou null se não encontrado.</returns>
        public static Diagnostico GetDiagnostico(string descricao)
        {
            throw new DiagnosticosException("Numero negativo!!!!");   
        }

        /// <summary>
        /// Insere um diagnóstico na lista.
        /// </summary>
        /// <param name="d">O diagnóstico a ser inserido.</param>
        /// <returns>True se o diagnóstico foi inserido com sucesso, False caso contrário.</returns>
        public static bool InsereDiagnostico(Diagnostico d)
        {
            if (d == null || diagnosticos.Contains(d)) return false;

            diagnosticos.Add(d);
            return true;
        }
        public static bool GravaDiagnosticosFicheiro(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, diagnosticos);
                s.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;

        }

        public static List<Diagnostico> LerDiagnosticosDoFicheiro(string fileName)
        {
            try
            {
                using (Stream s = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Diagnostico> diagnosticosLidas = (List<Diagnostico>)bf.Deserialize(s);
                    return diagnosticosLidas;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}


