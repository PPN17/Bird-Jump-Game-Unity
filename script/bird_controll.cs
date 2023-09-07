using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bird_controll : MonoBehaviour
{
    // Start is called before the first frame update

    public float rightMagnitude=2f;
    public float upMagnitude=3f;
    public Rigidbody2D mrigidbody2D;
    public int direction =1;
    public SpriteRenderer sp;
    bool IsBirdDied=false;
    public static event Action<int> OnCollideWithWall;
    public static event Action OnBirdDied;

    void Start()
    {
        
    }
    void onEnable(){

    }

    void onDisable(){

    }
    void onDestroy(){

    }
    void BirdJump(){
      if(!IsBirdDied){
        if(Input.GetMouseButton(0)){
            // Debug.Log("Mouse Clicked");
            Vector2 rightVelocity = direction*Vector2.right * rightMagnitude;
            Vector2 upVelocity=Vector2.up*upMagnitude;
            Vector2 res=rightVelocity+upVelocity;
            mrigidbody2D.velocity=res;
            mrigidbody2D.gravityScale=1f;

        }
      }
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name=="column1" || col.gameObject.name=="column2"){
            direction=-1*direction;
            sp.flipX=direction!=1f;
            OnCollideWithWall?.Invoke(direction);

        }
        if(col.gameObject.name=="spike"){
            OnBirdDied?.Invoke();
            sp.color=Color.black;
            IsBirdDied=true;
        }
    }
    void Update()
    {
        BirdJump();
    }
}
