using System.ComponentModel;

namespace Controle_de_Gastos.Models.ENUMs;

public enum CategoriaGasto
{
    Casamento,
    Moradia,
    Alimentação,
    Transporte,
    Saúde,
    
    [Description("Educação / cursos")]
    EducaçãoCursos,

    [Description("Assinaturas e serviços")]
    AssinaturasEserviços,

    [Description("Lazer e Entretenimento")]
    LazerEentretenimento,

    [Description("Vestuário e cuidados pessoais")]
    VestuárioEcuidadosPessoais,
    
    [Description("Reserva de emergência")]
    ReservaDeEmergência,
    
    Investimentos,

    [Description("Outros / imprevistos")]
    OutrosImprevistos,

    [Description("Eventos / Relac. Igreja")]
    EventosErelacAIgreja,
    Faculdade,
    Dizimo
}