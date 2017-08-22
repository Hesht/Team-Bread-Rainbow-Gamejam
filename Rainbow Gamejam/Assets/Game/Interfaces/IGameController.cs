using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Interfaces {
  public interface IGameController {
    void Initialise();
    /// <summary>
    /// To be called whenever the game needs to update
    /// </summary>
    void Update();
  }
}
