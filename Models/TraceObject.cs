namespace SQLServerControlVersion.Models
{
    public class TraceObject
    {
        public int Id { get; set; }
        public string Tp_Evento { get; set; }
        public DateTime Dt_Alteracao { get; set; }
        public string Nm_Servidor { get; set; }
        public string Nm_Login { get; set; }
        public string Nm_Database { get; set; }
        public string Nm_Objeto { get; set; }
        public string Ds_Evento { get; set; }

    }
}
