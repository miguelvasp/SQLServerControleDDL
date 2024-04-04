using Dapper;
using Microsoft.Data.SqlClient;
using SQLServerControlVersion.Models;
using System.Data;

namespace SQLServerControlVersion.Repository
{
    public class TraceRepository
    {
        public IEnumerable<TraceObject> CarregarObjetos(string cnn)
        {
            using (var _connection = new SqlConnection(cnn))
            {
                try
                {
                    string cmd = "SELECT DISTINCT REPLACE(REPLACE(TP_EVENTO, 'ALTER_', ''), 'CREATE_', '') Tp_Evento, NM_OBJETO FROM Trace_Alteracao_Objeto WHERE TP_EVENTO NOT LIKE '%DROP%'";
                    return _connection.Query<TraceObject>(cmd, null, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível conectar com o banco de dados!");
                    return new List<TraceObject>();
                }
            }
        }

        public IEnumerable<TraceObject> CarregarHistorico(string cnn, string Tipo, string NomeObjeto)
        {
            using (var _connection = new SqlConnection(cnn))
            {
                try
                {
                    string cmd = $"SELECT * FROM Trace_Alteracao_Objeto WHERE TP_EVENTO LIKE '%{Tipo}%' AND NM_OBJETO = '{NomeObjeto}' ORDER BY Dt_Alteracao DESC";
                    return _connection.Query<TraceObject>(cmd, null, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível conectar com o banco de dados!");
                    return new List<TraceObject>();
                }
            }
        }
    }
}