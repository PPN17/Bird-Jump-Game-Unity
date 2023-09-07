using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class candy : MonoBehaviour
{
    public static event Action OnCandyCollector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name.Contains("bird"))
        {
        OnCandyCollector.Invoke();
        gameObject.SetActive(false);
        }
    }
}
