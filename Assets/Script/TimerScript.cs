using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] float _timer = 100f;
    [SerializeField] Text _timerText = default;
    [SerializeField] float _timerChangeInterval;

    void Start()
    {
        CountDownTimer(_timer);
    }

    void Update()
    {
        _timer -= Time.deltaTime;
    }

    public void CountDownTimer(float timer)
    {
        DOTween.To(() => _timer, newValue =>
       _timerText.text = "Time:" + newValue.ToString("00000000"), _timer - timer, _timerChangeInterval).OnComplete(() => _timer += timer);
    }
}
