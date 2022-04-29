using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed=5f;
    public bool isGrounded=false;
    public float jump=20f;
    bool isRight;
    bool isLeft;
    public AudioClip bounce;
     public float shakeAmt=0.5f;
      public float duration=0.2f;
    CameraShake camShake;

    void Awake(){
        camShake= gameObject.GetComponent<CameraShake>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isRight=true;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.LeftArrow) && isLeft==false){
            isRight=false;
            isLeft=true;
            camShake.Shake(shakeAmt,duration);
            transform.eulerAngles = new Vector3(0,180,0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && isRight==false){
            isRight=true;
            isLeft=false;
            transform.eulerAngles = new Vector3(0,0,0);
        }

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += movement * Time.deltaTime*moveSpeed;
         Jump(); 



    }

    void Jump(){
        
        if(Input.GetButtonDown("Jump") && isGrounded==true){
            // Debug.Log("In jump is grounded = true");
            AudioSource.PlayClipAtPoint(bounce, transform.position);
            camShake.Shake(shakeAmt,duration);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jump),ForceMode2D.Impulse);
        }
    }
  

}
