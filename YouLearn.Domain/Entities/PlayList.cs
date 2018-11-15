using System;

namespace YouLearn.Domain.Entities
{
  public class PlayList
  {

    public Guid Id { get; set; }
    public Usuario Usuario { get; set; }
    //Em analise, Aprovado, ou Recusado
    public string Status{ get; set; }
  }

  
}
