using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    public GameObject[] Lspike;
    public GameObject[] Rspike;
    // Start is called before the first frame update
     void Start()
    {
        bird_controll.OnCollideWithWall += BirdCollidedWithWall;
        HideSpikes();
    }

    void HideSpikes(){
        for(int i=0; i<Lspike.Length; i++){
            Lspike[i].gameObject.SetActive(false);
        }
         for(int i=0; i<Rspike.Length; i++){
            Rspike[i].gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    
    void BirdCollidedWithWall (int dir)
    {
        HideSpikes();
        GameObject[] spikes=dir==-1 ? Lspike:Rspike;

        int randomIndex=UnityEngine.Random.Range(0, spikes.Length);
        spikes[randomIndex].SetActive(true);
    } 
}
