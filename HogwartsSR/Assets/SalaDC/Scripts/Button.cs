using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Button : MonoBehaviour
{
    public int ButtonIndex {get; set;}
    [SerializeField] GameManager gm;
    [SerializeField] Color defaultColor;
    [SerializeField] Color highlightColor;
    [SerializeField] float resetDelay = .25f;
    [SerializeField] bool Press;
    [SerializeField] GameObject hammer;

    AudioSource sound;

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void Start()
    {
        ResetButton();
        Press = false;
    }

    //void OnMouseDown()
    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.name == "Martillo")
        {
            if (Press){
            gm.PlayersPick(ButtonIndex);
            PressButton();
            }
            else{
            gm.StartGame();
            Press = true;
            PressButton();
            }
        }
    }

    public void PressButton()
    {
        sound.Play();
        GetComponent<MeshRenderer>().material.color = highlightColor;
        Invoke("ResetButton", resetDelay);
    }

    public void ResetButton()
    {
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }
}
