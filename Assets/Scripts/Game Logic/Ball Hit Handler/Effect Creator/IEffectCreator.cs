using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public interface IEffectCreator
    {
        public void SetEffect(ParticleSystem workedOutPS, GameObject hitBall);
        public void InstantiateEffect(List<ParticleSystem> workedOutEffects, GameObject hitBall);
    }
}
