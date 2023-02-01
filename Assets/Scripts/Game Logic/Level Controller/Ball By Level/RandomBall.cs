using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public class RandomBall : MonoBehaviour, IBallByLevel
    {
        public IBallMaker BallMaker { get; set; }

        private int count;
        private int randomIndex;

        void Awake()
        {
            BallMaker = GetComponent<IBallMaker>();
        }

        public GameObject ChooseBall(List<GameObject> prefabs, int score)
        {
            count = prefabs.Count;
            randomIndex = Random.Range(0, count);
            return BallMaker.GetBall(prefabs[randomIndex]);
        }
    }
}