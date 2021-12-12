using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public int times;
    private int healt=100;
    private int enemyHealt=100;
    void Start()
    {
        while(times>0){
            Debug.Log("Hello World");
            times--;
        }
        while(true){
            Debug.Log("infinity");
            break;//not today man
        }
        do{
            enemyHealt--;
            if(enemyHealt<=0){
                Debug.Log("Winner!"); break;
            }
        }while(healt>0);
    }
    }


