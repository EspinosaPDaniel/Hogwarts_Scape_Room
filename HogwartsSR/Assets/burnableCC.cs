using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnableCC : MonoBehaviour
{
   public GameObject fireObject;
   public ParticleSystem particleSystemToChangeColor;
   public ParticleSystem particleSystemToChangeColorSmoke;
   public Color newColor;
   public AudioSource audio;
   
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
            audio.volume=1;
            

        }
    }
}
