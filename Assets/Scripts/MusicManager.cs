using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MusicManager : MonoBehaviour
{
    public Timer time;
    public AudioClip[] Music;
    public AudioClip[] Add;
    private AudioClip[] PlayOnLvl;
    public AudioSource MusicPlayer;
    private int numPlay;
    void Start()
    {
        int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

        UnityEngine.Random.InitState(unixTimestamp);

        PlayOnLvl = new AudioClip[3];
        int num = UnityEngine.Random.Range(0, Music.Length);
        PlayOnLvl[0] = Music[num];
        Debug.Log(num);

        num = UnityEngine.Random.Range(0, Add.Length);
        PlayOnLvl[1] = Add[num];
        Debug.Log(num);

        num = UnityEngine.Random.Range(0, Music.Length);
        PlayOnLvl[2] = Music[num];
        Debug.Log(num);

        numPlay = 0;
        MusicPlayer.clip = PlayOnLvl[numPlay];
        MusicPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(((time.GetTime() > 20 && numPlay == 0) || !MusicPlayer.isPlaying) && numPlay < 2)
        {
            numPlay++;
            MusicPlayer.clip = PlayOnLvl[numPlay];
            MusicPlayer.Play();
        }
    }
}
