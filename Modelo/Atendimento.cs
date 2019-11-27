using System;

namespace Modelo
{
    public class AtendimentoModelo
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Data { get; set; }
        public string Anamnese { get; set; }
        public string ExameFisico { get; set; }
        public string CIDPrincipal { get; set; }

        public virtual PacienteModelo Paciente { get; set; }
    }
}
