using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parralax : MonoBehaviour
{
    private float length,startpos;
    public GameObject cam;
    public  float parrallaxEffect;
    // Start is called before the first frame update
    private void Start(){
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update(){
        // Debug.Log("Length = "+length+"startpos= "+startpos);
        // Debug.Log("Cam x = "+cam.transform.position.x);
        
        float temp = (cam.transform.position.x * (1-parrallaxEffect));
        float dist = (cam.transform.position.x * parrallaxEffect);

        transform.position=new Vector3(startpos+dist,transform.position.y,transform.position.z);
        // Debug.Log(temp > startpos+length);
        if(temp > startpos+length){
            startpos += length;
        }
        else if(temp < startpos-length){
            startpos -= length;
            
        
        }        
        

    }
}
