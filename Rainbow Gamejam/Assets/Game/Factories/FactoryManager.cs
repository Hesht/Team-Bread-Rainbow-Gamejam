using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Factories {
  public static class FactoryManager {
    public static RandomNPCGeneratorFactory RandomNPCGeneratorFactory { get; private set; }
    public static RandomHouseGeneratorFactory RandomHouseGeneratorFactory { get; private set; }
    public static GameFactory GameFactory { get; private set; }

    static FactoryManager() {
      RandomNPCGeneratorFactory = new RandomNPCGeneratorFactory();
      RandomNPCGeneratorFactory.Initialise();

      RandomHouseGeneratorFactory = new RandomHouseGeneratorFactory();
      RandomHouseGeneratorFactory.Initialise();

      GameFactory = new GameFactory();
      GameFactory.Initialise();
    }
  }
}
