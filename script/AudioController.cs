using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource candyCollectedAudioSource;
   void Start(){
    candy.OnCandyCollector += OnCandyCollector;
   }

   void OnCandyCollector()
   {
candyCollectedAudioSource.Play();
   }
}
