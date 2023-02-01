using TMPro;
using UnityEngine;

namespace BallTest.UI
{
    public class NumberUpdater : MonoBehaviour, INumberUpdater
    {
        private string numberText;

        private int oldNumber;

        public void UpdateNumber(int number, TextMeshProUGUI numberBoardDisplay)
        {
            if (number != oldNumber)
            {
                numberText = number.ToString();
                numberBoardDisplay.text = numberText;
                oldNumber = number;
            }
        }
    }
}