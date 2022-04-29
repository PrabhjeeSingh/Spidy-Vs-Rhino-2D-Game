using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    public AudioClip hit;
      public AudioClip lost; 
      public float shakeAmt=0.5f;
      public float duration=0.2f;

      
      CameraShake camShakes;
    // Start is called before the first frame update
    void Awake(){
        camShakes = gameObject.GetComponent<CameraShake>();
        if(camShakes == null){
            Debug.LogError("Not Referenced");
        }
    }
    void Start()
    {
    Player=gameObject.transform.parent.gameObject;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        // Debug.Log("Grounded == triggered");
        if(collision.collider.tag=="Ground"){
            Player.GetComponent<Movement1>().isGrounded=true;
            // Debug.Log("Grounded == true");
        }
        else if(collision.collider.tag=="Rock"){
            AudioSource.PlayClipAtPoint(hit,transform.position,100f);

            
            camShakes.Shake(shakeAmt,duration);
            // Debug.Log("Grounded == true");
        }
      
    }
    private void OnCollisionExit2D(Collision2D collision){
        if(collision.collider.tag=="Ground"){
            //   Debug.Log("Grounded == false");
            Player.GetComponent<Movement1>().isGrounded=false;
        }
    }


}
