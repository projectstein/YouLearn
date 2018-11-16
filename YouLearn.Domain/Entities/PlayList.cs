using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enum;

namespace YouLearn.Domain.Entities
{
  public class PlayList : EntityBase
  {
    public Usuario Usuario { get; set; }
    //Em analise, Aprovado, ou Recusado
    public EnumStatus Status { get; set; }
  }


}
