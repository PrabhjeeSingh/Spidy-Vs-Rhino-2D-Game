using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
public Camera mycam;
public float ShakeAmouunt=0;

void Awake(){
    if(mycam==null){
        mycam = Camera.main;        
    }
}

public void Shake(float amt, float length){
    ShakeAmouunt= amt;
    InvokeRepeating("DoShake",0,0.1f);
    Invoke("StopShake",length);

}

void DoShake(){
    if(ShakeAmouunt>0){
    Vector3 camPos=mycam.transform.position;
    float offsetX = Random.value *ShakeAmouunt*2-ShakeAmouunt;
    float offsetY = Random.value *ShakeAmouunt*2-ShakeAmouunt;
    camPos.x += offsetX;
    camPos.y += offsetY;
    mycam.transform.position = camPos;
    // Debug.Log("Felt it");
    }
}

void StopShake(){
    CancelInvoke("DoShake");
    mycam.transform.localPosition = new Vector3(-1.2f,-1.3f,21.5f);
}





}
