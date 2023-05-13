using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
//[RequireComponent(typeof(AudioSource))]
public class Button : MonoBehaviour
{
    public int ButtonIndex {get; set;}
    [SerializeField] GameManager gm;
    [SerializeField] Color defaultColor;
    [SerializeField] Color highlightColor;
    [SerializeField] float resetDelay = .25f;

    //AudioSource sound;

    //void Awake()
    //{
    //    sound = GetComponent<AudioSource>();
    //}

    void Start()
    {
        ResetButton();
    }

    void OnMouseDown()
    {
        gm.PlayersPick(ButtonIndex);
        PressButton();
    }

    public void PressButton()
    {
        //sound.Play();
        GetComponent<MeshRenderer>().material.color = highlightColor;
        Invoke("ResetButton", resetDelay);
    }

    public void ResetButton()
    {
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }
}
