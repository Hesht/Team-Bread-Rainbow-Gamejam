using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Game.Models {
  /// <summary>
  /// Model to store data for the current player
  /// </summary>
  public class Player {
    public float Anxiety { get; private set; }
    private bool _addAnxiety = true;

    public Player() {
      Anxiety = 0.0f;
    }

    /// <summary>
    /// Increases the anxiety of the player by the given value (maximum of 1)
    /// </summary>
    /// <param name="value"></param>
    public void AddAnxiety(float value) {
      Anxiety += value;

      if(Anxiety > 0.9f) {
        Anxiety = 0.9f;
      }
    }

    /// <summary>
    /// Decreases the anxiety of the player by the value given (minimum of 0) (
    /// </summary>
    /// <param name="value"></param>
    public void CalmAnxiety(float value) {
      Anxiety -= value;

      if(Anxiety < 0.1f) {
        Anxiety = 0.1f;
      }
    }

    public void TestAnxiety() {
      if(_addAnxiety) {
        Anxiety += 0.01f;
      } else {
        Anxiety -= 0.01f;
      }

      if(Anxiety >= 1.0f) {
        Anxiety = 1.0f;
        _addAnxiety = false;
      }
      if(Anxiety <= 0.0f) {
        Anxiety = 0.0f;
        _addAnxiety = true;
      }
    }
  }
}
