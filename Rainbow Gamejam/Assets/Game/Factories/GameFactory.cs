using Assets.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Game.Logic;

namespace Assets.Game.Factories {
  public class GameFactory : IFactory<IGame> {
    public IGame Create() {
      return new Logic.Game();
    }

    public void Initialise() {
    }
  }
}
