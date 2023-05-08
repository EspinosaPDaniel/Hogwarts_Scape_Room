using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public ParticleSystem particleSystemToChangeColor;
    public Color newColor;
    public GameObject objetoQueActiva;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == objetoQueActiva)
        {
            var mainModule = particleSystemToChangeColor.main;
            mainModule.startColor = newColor;
        }
    }
}
