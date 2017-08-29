using Assets.Game.Factories;
using Assets.Game.Interfaces;
using Assets.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Logic {
  /// <summary>
  /// Responsible for manipulating the Game or any other metadata required
  /// </summary>
  public static class GameController {
    private static IGame _game;
    public static Player Player;

    static GameController() {
      _game = FactoryManager.GameFactory.Create();
      _game.Initialise(FactoryManager.RandomHouseGeneratorFactory.Create(), FactoryManager.RandomNPCGeneratorFactory.Create());

      Player = new Player();
    }

    public static void Update() {
      _game.Update();
      Player.TestAnxiety();
    }
  }
}
