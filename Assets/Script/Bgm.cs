using Saito.SoundManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlayBgm(SoundManager.BgmSoundData.BGM.Play);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
