using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSharp.Metods;

public class Main : MonoBehaviour
{
    Player playerOne;
   void Start() {
       Player playerOne=new Player();
       playerOne.Name="Emre";
       int randomScore=100;
       playerOne.SetScore(randomScore);
       playerOne.Lives=3;
       Debug.Log(playerOne.GetScore());
   }

   void OnDisable() {
       Debug.Log("Name : "+playerOne.Name+" Score : "+playerOne.GetScore()+" Lives : "+playerOne.Lives);
   }
}
