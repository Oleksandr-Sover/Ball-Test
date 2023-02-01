using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{ 
    public class ColorHitEffectCreator : MonoBehaviour, IEffectCreator
    {
        [SerializeField]
        private GameObject effectPrefab;
        private GameObject effect;

        private ParticleSystem ps;

        private ParticleSystem.MainModule psMainModule;

        public void SetEffect(ParticleSystem workedOutPS, GameObject hitBall)
        {
            workedOutPS.transform.position = hitBall.transform.position;
            SetEffectColor(workedOutPS, hitBall);
            workedOutPS.Play();
        }

        public void InstantiateEffect(List<ParticleSystem> workedOutEffects, GameObject hitBall)
        {
            effect = Instantiate(effectPrefab, hitBall.transform.position, Quaternion.identity);
            ps = effect.GetComponent<ParticleSystem>();
            workedOutEffects.Add(ps);
            SetEffectColor(ps, hitBall);
            ps.Play();
        }

        private void SetEffectColor(ParticleSystem effect, GameObject hitBall)
        {
            psMainModule = effect.main;
            psMainModule.startColor = hitBall.GetComponent<SpriteRenderer>().color;
        }
    }
}