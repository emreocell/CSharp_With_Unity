using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    //Degisken tanimlama
    public string ad="Emre";
    public int yas=19;
    private float yetenek=3.1f;
    
    
    void Start(){//basladıgında
        Debug.Log(yetenek);
    }
    void Update(){//her yenilenen karade
        Debug.LogFormat("Benim adim {0} ve yasim {1}"ad,yas);//birden fazla degiskenli cikti
    }
    void OnEnable(){//aktif oldugunda calisir
        Debug.Log("I'm enabled.");
    }
    void OnDisable(){//deaktif oldugunda calisir
        Debug.Log("I'm disabled.");
    }
    
}
