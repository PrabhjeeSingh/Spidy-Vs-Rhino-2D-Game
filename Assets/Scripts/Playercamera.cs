using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercamera : MonoBehaviour
{
    Vector3 targetposition;
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        targetposition = player.transform.position;
        offset = transform.position-player.transform.position;
    }

    // Update is called once per frame
    void Update()
    { 
         Vector3 targetposition=new Vector3(player.transform.position.x + offset.x,player.transform.position.y +(offset.y)*0.85f,player.transform.position.z + offset.z);
      
    //     if((player.transform.position.y +offset.y)>2.0f){

    //    targetposition=new Vector3(player.transform.position.x + offset.x,player.transform.position.y +(offset.y/2),player.transform.position.z + offset.z);
    //     Debug.Log(player.transform.position.y +offset.y);
        
    //     }   
        
        transform.position = targetposition;
        // Debug.Log(transform.position);
    }
}
