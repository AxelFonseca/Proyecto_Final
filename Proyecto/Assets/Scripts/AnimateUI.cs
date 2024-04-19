using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUI : MonoBehaviour
{
    public GameObject logo;
    public GameObject fondoLogo;
    public GameObject botones;

    void Start()
    {
        LeanTween.moveY(rectTrans: logo.GetComponent<RectTransform>(), to: 0, time: 1.5f)
            .setEase(LeanTweenType.easeOutSine)
            .setDelay(0.5f);

        LeanTween.alphaCanvas(fondoLogo.GetComponent<CanvasGroup>(), to: 0, time: 1f).setDelay(3f);
    }

    public void ActivarBotones()
    {
        LeanTween.moveY(rectTrans: botones.GetComponent<RectTransform>(), to: -241f, time: 1.2f)
            .setEase(LeanTweenType.easeOutBounce);
    }
}