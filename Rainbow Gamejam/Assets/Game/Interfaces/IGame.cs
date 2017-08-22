using Assets.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Interfaces {
  public interface IGame {
    void Initialise(IRandomGenerator<House> family, IRandomGenerator<List<NPC>> house);
    void Update();
    void GenerateGame();
  }
}
