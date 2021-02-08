using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik
{
    /// <summary>
    /// Used to store game data. Change it the way you want.
    /// </summary>
    public class GameData
    {
        // Example (I use public fields for data, but u free to use properties\methods etc)
        // public float LevelProgress;
        // public Enemy[] Enemies;

        public Transform player;
        public GameObject level;

        /// <summary>
        /// 0 - никуда, 1 - вправо, -1 -влево
        /// </summary>
        public int swipeDirection;
        public int coinsCollected;

        public Dictionary<int, float> linesPositions;
    }
}