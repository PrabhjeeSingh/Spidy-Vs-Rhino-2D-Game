using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
public string level;
    // Start is called before the first frame update

    public bool music=true;
    public Button button;
    public Sprite musicOff, musicON;
    Image firstImage;
   
    void Start()
    {
        // AudioSource.PlayClipAtPoint(BgMusic,transform.position);
        // musicOff= Resources.Load<Sprite>("musicoff");
        // musicON= Resources.Load<Sprite>("musicon");
        firstImage = button.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Startgame(){
            SceneManager.LoadScene("Main");
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quitting");
    }

    public void PlayPauseMusic(){
        if(music==false){
            firstImage.sprite=musicON;
            AudioListener.volume = 40;
            music=true;
        }
        else if(music==true){
            firstImage.sprite=musicOff;
            AudioListener.volume =0;
            music=false;
        }
    }
    public void RestartGame(){
        SceneManager.LoadScene("Main");

    }



}
