using Assets.Game.Factories;
using Assets.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Logic {
  /// <summary>
  /// Responsible for manipulating the Game or any other metadata required
  /// </summary>
  class GameController : IGameController {
    private IGame _game;

    public void Initialise() {
      _game = FactoryManager.GameFactory.Create();
      _game.Initialise(FactoryManager.RandomHouseGeneratorFactory.Create(), FactoryManager.RandomNPCGeneratorFactory.Create());
    }

    public void Update() {
      throw new NotImplementedException();
    }
  }
}
