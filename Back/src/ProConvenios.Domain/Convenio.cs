namespace ProConvenios.Domain
{
    public class Convenio
    {
        // public int id;

        public int Id { get; set; }
        public string DtInicio { get; set; }
        public string DtFim { get; set; }
        public string ProcessoTCE { get; set; }
        public string LinkRedmine { get; set; }
        public string ObjetoAcordo { get; set; } 
        public string Telefone { get; set; } 
        public string Email { get; set; } 
        
    }
}