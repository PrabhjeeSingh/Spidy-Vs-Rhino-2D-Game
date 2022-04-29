using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeGen : MonoBehaviour
{
   
    public float time=0.0f;
    public TextMeshProUGUI textTime;
    public Image TimeImage;
   // public Image pp;

    public AudioClip TimeSound;
    public GameObject TimePrefab;
    public AudioClip TimeComplete;
    public GameObject Enemy;
    private float location;

    void Start(){
        TimeImage.fillAmount=0;
        for(int i = 0; i < 1;i++){
            location=transform.position.x;
            var position= new Vector3(Random.Range(-10f,100f),Random.Range(-10f,-3f),0);
            Instantiate(TimePrefab,position,Quaternion.identity);
            // Debug.Log("generated");
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag=="Time"){
                if(time==0.0f){
                    UpdateTimeBar(time);
                }
                time+=0.1f; 
                AudioSource.PlayClipAtPoint(TimeSound, transform.position);
                // textTime.text = time.ToString();

                UpdateTimeBar(time);

                    if(time>=1.0f){time=0.0f;}
                Destroy(other.gameObject);
       
            }
  
        }

    void Update(){
        
       
        if(transform.position.x>80f+location){

        var position= new Vector3(Random.Range(location+80f,location+160f),Random.Range(-10f,-3f),0);
        Instantiate(TimePrefab,position,Quaternion.identity);
        
        location = transform.position.x;
     
    }
    }

    
    // Start is called before the first frame update
    public void UpdateTimeBar(float Time ){
        if(Time>=1.0f){
        TimeImage.fillAmount = Time;
        // Particlef();    
        AudioSource.PlayClipAtPoint(TimeComplete, transform.position,100f);
        Vector3 place=Enemy.transform.position;

        Enemy.transform.position = new Vector3(place.x-20f, place.y, place.z);
        TimeImage.fillAmount = 0;
        // Debug.Log("Done");
        time=0.0f;
        }
       else {TimeImage.fillAmount = Time;}
    }
}
