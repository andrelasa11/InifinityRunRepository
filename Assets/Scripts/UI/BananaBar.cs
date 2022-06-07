using UnityEngine;
using UnityEngine.UI;

public class BananaBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxScore(float maxScore)
    {
        slider.maxValue = maxScore;
        slider.value = 0;
    }

    public void SetScore(int score)
    {
        slider.value = score;
    }
}
