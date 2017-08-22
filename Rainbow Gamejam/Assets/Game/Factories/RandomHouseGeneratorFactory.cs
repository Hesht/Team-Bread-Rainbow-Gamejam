using Assets.Game.Interfaces;
using Assets.Game.Logic.Generators;
using Assets.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Factories {
  public class RandomHouseGeneratorFactory : IFactory<IRandomGenerator<House>> {
    public IRandomGenerator<House> Create() {
      return new RandomHouseGenerator();
    }

    public void Initialise() {
    }
  }
}
