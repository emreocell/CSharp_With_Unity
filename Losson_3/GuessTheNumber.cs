using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    public int guess=0;

    private int cannot=0;
    private int result;
    void Start()
    {
        result=Random.Range(1,10);

    }


    void Update()
    {
        if(guess!=cannot){
            Debug.Log("result: "+result);
            if(guess==result){
                Debug.Log("You win");
            }
            else if(guess>result){
                Debug.Log("Too high");
            }
            else if(guess<result){
                Debug.Log("Too low");
            }
            cannot=guess;
        }

    }
}
