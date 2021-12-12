using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EunumAndFor : MonoBehaviour
{
    public enum Player{
        PlayerOne,PlayerTwo,PlayerNoneSelected
    }
    public Player player;
    public int[] scores;
    private int avarage=0;
    void Start() {
        for(int i=0;i<10;i++){
            Debug.Log("Hello World!");
            continue;
            //Code will never reach here
            Debug.Log("Again Hello World!");
        }

        /*for(int j=0;j<10;j--){//sonsuz dongu
            Debug.Log("Infinity");
        }
        //Code will never reach here */  
        /*for(int i=0;i<scores.Length;i++){//Same 
            avarage+=scores[i];
        }
        foreach(int score in scores){//Same
            avarage+=score;
        }
        Debug.Log("Avarage is "+avarage/scores.Length);*/
    }
    
    void OnDisable(){
    switch (player) {
        case Player.PlayerOne:
        Debug.Log("Player One Selected"); break;
        case Player.PlayerTwo:
        Debug.Log("Player Two Selected"); break;
        case Player.PlayerNoneSelected:
        Debug.Log("Please Select a Player"); break;
        default:
        Debug.Log("Error"); break;
    }
    }
}
