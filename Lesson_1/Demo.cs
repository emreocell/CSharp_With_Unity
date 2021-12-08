using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void OnEnable(){//aktif oldugunda calisir
        Debug.Log("I'm enabled.");
    }
    void OnDisable(){//deaktif oldugunda calisir
        Debug.Log("I'm disabled.");
    }
}
