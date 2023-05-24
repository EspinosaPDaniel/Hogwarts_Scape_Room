using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button[] button;
    [Header("Color Order")]
    [SerializeField] List<int> colorOrder;
    [SerializeField] float pickDelay = .4f;
    [SerializeField] int pickNumber = 0;
    [SerializeField] Score score;
    
    void Start()
    {
        ResetGame();
        SetButtonIndex();
    }

    void SetButtonIndex()
    {
        for(int cnt = 0; cnt < button.Length; cnt++)
            button[cnt].ButtonIndex = cnt;
    }

    public void StartGame(){
        StartCoroutine("PlayGame");
    }

    IEnumerator PlayGame()
    {
        pickNumber =0;
        yield return new WaitForSeconds(pickDelay);

            foreach(int colorIndex in colorOrder)
            {
                button[colorIndex].PressButton();
                yield return new WaitForSeconds(pickDelay);
            }

            PickRandomColor();
    }

    void PickRandomColor()
    {
        int rnd = Random.Range(0, button.Length);
        button[rnd].PressButton();
        colorOrder.Add(rnd);
    }

    public void PlayersPick(int pick)
    {
        Debug.Log("Player Clicked A Button" + pick);
        
        if(pick == colorOrder[pickNumber])
        {
            Debug.Log("Correct");

            pickNumber++;
            if(pickNumber == colorOrder.Count)
            {
                if(pickNumber == 7){
                    score.Finish();
                }
                else{
                    score.Set(pickNumber);
                    StartCoroutine("PlayGame");
                }
            }
        }
        else
        {
            Debug.Log("Fail");
            ResetGame();

            StartCoroutine("PlayGame");
        }
    }

    void ResetGame()
    {
        Debug.Log("Resetting");
        score.Set();
        colorOrder.Clear();
    }
}
