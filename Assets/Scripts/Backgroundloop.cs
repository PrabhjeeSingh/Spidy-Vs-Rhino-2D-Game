using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundloop : MonoBehaviour
{
    private Material mat;
    // Vector2 offest;
    public int xVelocity, yVelocity;

    // Start is called before the first frame update
    void Awake(){
        // mat = GetComponent<Renderer>().material;
    
    }
    void Start()
    {
        // offset = new Vector2(xVelocity, yVelocity);

    }

    // Update is called once per frame
    void Update()
    {       
        // mat.mainTextureOffset += offset * Time.deltaTime;
    }

    

}
