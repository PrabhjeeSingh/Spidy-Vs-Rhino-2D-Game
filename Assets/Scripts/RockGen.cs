using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGen : MonoBehaviour
{
    public GameObject RockPrefab;
      private float location;
    void Awake(){
        for(int i = 0; i < 1;i++){
            location=transform.position.x;
            var position= new Vector3(Random.Range(-10f,100f),-11,0);
            Instantiate(RockPrefab,position,Quaternion.identity);
            // Debug.Log("generated");
        }
    }



    void Update(){
        
       
        if(transform.position.x>40f+location){

        var position= new Vector3(Random.Range(location+80f,location+160f),-11,0);
        Instantiate(RockPrefab,position,Quaternion.identity);
        
        location = transform.position.x;
     
    }
    }
}