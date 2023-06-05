using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Burnable : MonoBehaviour
{
   public GameObject fireObject;
   public ParticleSystem particleSystemToChangeColor;
   public ParticleSystem particleSystemToChangeColorSmoke;
   public Color newColor;
   
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        ParticleSystem.MinMaxCurve newStartSize = new ParticleSystem.MinMaxCurve(5);
        ParticleSystem.MinMaxCurve newStartSizeSmoke = new ParticleSystem.MinMaxCurve(4);
        if (col.gameObject == fireObject)
        {
            Destroy(gameObject);
            var mainModule = particleSystemToChangeColor.main;
            var mainModuleSmoke = particleSystemToChangeColorSmoke.main;
            mainModule.startColor = newColor;
            mainModule.startSize=newStartSize;
            mainModuleSmoke.startColor = newColor;
            mainModuleSmoke.startSize=newStartSizeSmoke;
            Debug.Log("eeee");
            StartCoroutine(DelayedAction());
            Debug.Log("iiii");
            SceneManager.LoadScene("Sala Slitheryn");
            

        }
    }
     private IEnumerator DelayedAction()
    {
        yield return new WaitForSecondsRealtime(2f);

        // Acción a realizar después del retraso
        Debug.Log("Delayed action executed!");
    }
    
}
