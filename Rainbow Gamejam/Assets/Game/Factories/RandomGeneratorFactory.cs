using Assets.Game.Interfaces;
using Assets.Game.Logic.Generators;
using Assets.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Factories {
  public class RandomNPCGeneratorFactory : IFactory<IRandomGenerator<List<NPC>>> {

    public void Initialise() {
    }

    public IRandomGenerator<List<NPC>> Create() {
      return new RandomNPCGenerator();
    }
  }
}
