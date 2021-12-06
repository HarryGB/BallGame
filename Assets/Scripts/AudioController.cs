using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    //controls playback of the song, updates volume whenever braziers are lit/level transition

    //0 is ambient loop, gets quieter as other tracks are added
    public AudioSource[] tracks;
    //speed of volume change
    public int duration; 
    public void AddTrack(int index)
    {
        StartCoroutine(LerpVolume(tracks[0], tracks[0].volume - 0.25f));
        StartCoroutine(LerpVolume(tracks[index], 1));
    }

    public void ResetTracks()
    {
        StartCoroutine(LerpVolume(tracks[0], 1));
        for (int i = 1; i < tracks.Length; i++)
        {
            StartCoroutine(LerpVolume(tracks[i], 0));
        }
    }

    IEnumerator LerpVolume(AudioSource track, float target)
    {
        float time = 0;
        float startVolume = track.volume;

        while (time < duration)
        {
            track.volume = Mathf.Lerp(startVolume, target, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        
    }
}
