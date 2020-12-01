﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider slider;

    public void SetMana(int mana)
    {
        slider.value = mana;
    }

    public void SetMaxMana(int mana)
    {
        slider.maxValue = mana;
        //TODO: always fill mana on max increase?
        slider.value = mana;
    }
}
