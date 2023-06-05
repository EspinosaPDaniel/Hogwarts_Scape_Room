using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class burnableCC : MonoBehaviour
{
   public GameObject fireObject;
   public ParticleSystem particleSystemToChangeColor;
   public ParticleSystem particleSystemToChangeColorSmoke;
   public Color newColor;
   public AudioSource audio;
   public AudioSource sound;
   private bool enter=true;
    // Start is called before the first frame update

    IEnumerator your_timer() {
    enter = true;
    Debug.Log("Your enter Coroutine at" + Time.time);
    SceneManager.LoadScene("SalaDC");
    yield return new WaitForSeconds(2);
    Debug.Log("ooooooooo"); 
    SceneManager.LoadScene("SalaDC");
    enter = false;
    }
    void OnCollisionEnter(Collision col)
    {
        ParticleSystem.MinMaxCurve newStartSize = new ParticleSystem.MinMaxCurve(5);
        ParticleSystem.MinMaxCurve newStartSizeSmoke = new ParticleSystem.MinMaxCurve(4);
        if (col.gameObject == fireObject)
        {
            
            var mainModule = particleSystemToChangeColor.main;
            var mainModuleSmoke = particleSystemToChangeColorSmoke.main;
            mainModule.startColor = newColor;
            mainModule.startSize=newStartSize;
            mainModuleSmoke.startColor = newColor;
            mainModuleSmoke.startSize=newStartSizeSmoke;
            audio.volume=1;
			sound.mute=false;
		    sound.Play();
            enter=false;
                 
            if (enter == false)
            {
            Debug.Log("oooo");
            StartCoroutine(your_timer());
            }   
            Destroy(gameObject);
            

        }
    }
    void change(){
        
        SceneManager.LoadScene("SalaDC");

    }
    
}
