using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public class HitEffectHandler : MonoBehaviour, IHitEffectHandler
    {
        private IEffectCreator EffectCreator;

        private List<ParticleSystem> workedOutHitEffects = new List<ParticleSystem>();

        private int count;

        private bool effectSelected;

        void Awake()
        {
            EffectCreator = GetComponent<IEffectCreator>();
        }

        public void playHitEffect(GameObject hitBall)
        {
            count = workedOutHitEffects.Count;
            effectSelected = false;

            if (count > 0)
            {
                foreach (var workedOutHitEffect in workedOutHitEffects)
                {
                    if (workedOutHitEffect.isStopped)
                    {
                        EffectCreator.SetEffect(workedOutHitEffect, hitBall);
                        effectSelected = true;
                        break;
                    }
                }
                if (!effectSelected)
                    EffectCreator.InstantiateEffect(workedOutHitEffects, hitBall);
            }
            else
                EffectCreator.InstantiateEffect(workedOutHitEffects, hitBall);
        }
    }
}