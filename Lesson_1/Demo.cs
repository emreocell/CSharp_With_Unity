using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void OnEnable(){
        Debug.Log("I'm enabled.");
    }
    void OnDisable(){
        Debug.Log("I'm disabled.");
    }
}
