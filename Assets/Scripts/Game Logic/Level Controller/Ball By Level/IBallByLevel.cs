using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public interface IBallByLevel
    {
        public IBallMaker BallMaker { get; set; }
        public GameObject ChooseBall(List<GameObject> prefabs, int score);
    }
}