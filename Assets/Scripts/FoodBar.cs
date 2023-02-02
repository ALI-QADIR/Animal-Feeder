using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
    public Slider hungerSlider;

    public void SetMaxHunger(int hunger)
    {
        hungerSlider.maxValue = hunger;
        hungerSlider.value = hunger;
    }

    public void SetHunger(int hunger)
    {
        hungerSlider.value = hunger;
    }
}
