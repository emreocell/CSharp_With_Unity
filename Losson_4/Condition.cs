using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    void OnDisable() {
        int[] numbers={Random.Range(1,100),Random.Range(1,100),Random.Range(1,100)};
        string numberText;


        for(int i=0;i<numbers.Length;i++){
            numberText=(numbers[i]%2==0) ? "even" : "odd";
            Debug.Log(numbers[i]+" is "+numberText);
        }
    }
    
}
