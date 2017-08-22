using Assets.Game.Interfaces;
using Assets.Game.Logic.Generators;
using Assets.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Logic {
  /// <summary>
  /// Contains functions and methods to play the game, or generate objects needed at different stages of the game
  /// </summary>
  public class Game : IGame {
    private IRandomGenerator<House> _randomHouseGenerator;
    private IRandomGenerator<List<NPC>> _randomNPCGenerator;

    private List<NPC> _family;
    private House _house;

    public void GenerateGame() {
      _family = _randomNPCGenerator.GenerateRandom();
      _house = _randomHouseGenerator.GenerateRandom();
    }

    public void Initialise(IRandomGenerator<House> houseGenerator, IRandomGenerator<List<NPC>> nPCGenerator) {
      _randomHouseGenerator = houseGenerator;
      _randomNPCGenerator = nPCGenerator;
    }

    public void Update() {
      throw new NotImplementedException();
    }
  }
}
