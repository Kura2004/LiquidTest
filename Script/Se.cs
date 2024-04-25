using Saito.SoundManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Se : MonoBehaviour
{
    public static void Accel()
    {
        SoundManager.Instance.PlaySe(SoundManager.SeSoundData.SE.Accel);
    }

    public static void Shoot()
    {
        SoundManager.Instance.PlaySe(SoundManager.SeSoundData.SE.Shoot);
    }
}
