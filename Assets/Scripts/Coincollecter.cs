using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class Coincollecter : MonoBehaviour
{
    private float coin=0;
    // private float time=0;
    public TextMeshProUGUI textCoins;
   // public Image pp;

    public AudioClip coinSound;
    public GameObject CoinPrefab;
    private float location;

    void Start(){
        for(int i = 0; i < 2;i++){
            location=transform.position.x;
            var position= new Vector3(Random.Range(-10f,100f),Random.Range(-6f,-3f),0);
            Instantiate(CoinPrefab,position,Quaternion.identity);
            // Debug.Log("generated");
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag=="coin"){
                coin++;
                AudioSource.PlayClipAtPoint(coinSound, transform.position);
                textCoins.text = coin.ToString();
               
                Destroy(other.gameObject);
       
            }
        // if(other.transform.tag=="Time"){
        //         Debug.Log(time.ToString());
        //         time+=1f;
        //         AudioSource.PlayClipAtPoint(timeSound, transform.position);
        //         barImage = transform.Find("bar").GetComponent<Image>();
        //         barImage.fillAmount = time; 
               
        //         Destroy(other.gameObject);
                
        //     }
        }

    void Update(){
        
       
        if(transform.position.x>10f+location){

        var position= new Vector3(Random.Range(location+30f,location+70f),Random.Range(-6f,1f),0);
        Instantiate(CoinPrefab,position,Quaternion.identity);
        
        location = transform.position.x;
     
    }
    }
       
}




