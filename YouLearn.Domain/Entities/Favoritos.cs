﻿using YouLearn.Domain.Entities.Base;

namespace YouLearn.Domain.Entities
{
  public class Favoritos : EntityBase
  {

    public Video Video { get; set; }
    public Usuario Usuario { get; set; }

  }
}
