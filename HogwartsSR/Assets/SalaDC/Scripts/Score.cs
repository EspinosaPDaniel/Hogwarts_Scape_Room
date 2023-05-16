using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] Button[] button;
    public GameObject Cuadro;

    void Start()
    {
        Set();
    }

    public void Add(int amt = 1)
    {
        score += amt;
    }

    public void Set(int amt = 0)
    {
        score = amt;
    }

    public void Finish()
    {
        transform.position += new Vector3(0,100,0) * Time.deltaTime;
    }
}

