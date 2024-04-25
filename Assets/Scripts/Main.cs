using System;
using System.Collections;
using System.Collections.Generic;
using Saito.SoundManager;
using UnityEngine;

public class Main : MonoBehaviour
{
    public void PushButton_Bgm()
    {
        SoundManager.Instance.PlayBgm(SoundManager.BgmSoundData.BGM.Play);
    }

    public void PushButton_Se()
    {
        SoundManager.Instance.PlaySe(SoundManager.SeSoundData.SE.Lose);
    }

    public void Se_2()
    {
        SoundManager.Instance.PlaySe(SoundManager.SeSoundData.SE.Win);
    }

    private void Start()
    {
        PushButton_Bgm();
        StartCoroutine(DelayMethod(0.5f));
    }

    int slow;
    private void Update()
    {
        
    }

    private IEnumerator DelayMethod(float waitTime)
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(waitTime);
            PushButton_Se();
            Debug.Log("StartCoroutine");
        }

        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(waitTime);
            Se_2();
            Debug.Log("StartCoroutine");
        }
    }
}
