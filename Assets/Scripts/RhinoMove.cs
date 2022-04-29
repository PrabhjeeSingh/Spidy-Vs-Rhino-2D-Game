using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RhinoMove : MonoBehaviour
{   
    public GameObject target;
    public float moveSpeed=0.5f;
    private Vector3 pos;
    public AudioClip lost;
    
    // Start is called before the first frame update
    void Start()
    {
        
       // Vector3 pos = new Vector3(transform.position.x,-3.5f,0f);
       
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 movement = transform.position;
        // transform.position += movement * Time.deltaTime*moveSpeed;
        transform.position = Vector3.MoveTowards(movement,target.transform.position, Time.deltaTime*moveSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        // Debug.Log("Entered");
        // Debug.Log("Grounded == triggered");
        if(collision.collider.tag=="Player"){
            
            SceneManager.LoadScene("RestartMenu");
    
        }
    }
}
