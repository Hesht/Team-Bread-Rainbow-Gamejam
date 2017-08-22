using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Interfaces {
  public interface IRandomGenerator<T> {
    /// <summary>
    /// Initialises the variables in the class
    /// </summary>
    void Initialise();

    /// <summary>
    /// To be called whenever the class needs to update
    /// </summary>
    void Update();

    /// <summary>
    /// Generates a random type T
    /// </summary>
    /// <returns>The randomly generated class</returns>
    T GenerateRandom(); 
  }
}
