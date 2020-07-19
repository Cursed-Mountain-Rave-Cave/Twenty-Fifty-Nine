using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        PlayOnLvl = new AudioClip[3];
        int num = Random.Range(0, Music.Length - 1);
        PlayOnLvl[0] = Music[num];

        num = Random.Range(0, Add.Length - 1);
        PlayOnLvl[1] = Add[num];

        num = Random.Range(0, Music.Length - 1);
        PlayOnLvl[2] = Music[num];
        
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
