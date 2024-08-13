using System;
using System.Collections;
using System.Collections.Generic;
using CoD.Runtime.ViewAbstractions;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class NoBulletsVisualEffect : MonoBehaviour, NoBulletsFeedback
{
    public void Show()
    {
        GetComponent<TMP_Text>().DOColor(Color.red, 0.25f).SetLoops(2, LoopType.Yoyo);
    }
}
