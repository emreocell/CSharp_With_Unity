using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    //Degisken tanimlama
    public string ad="Emre";//public olanlar unity hub'dan degisilebilinir.
    public int yas=19;//-2milyar... - 2milyar...
    uint positive=48;//sadece pozitif sayıları tutan degisken 0 - 4milyar...
    private float fav=3.1f;//private ya da diger degiskenler sadece script uzerinden degisebilir.
    bool dogruMu = true;
    bool yanlisMi = 0;
    
    
    void Start(){//basladıgında
        Debug.Log("My name is "+ad+" ."+" My age is "+yas+" and my fav num is "+fav);//javadaki gibi
    }
    void Update() {
        if(dogruMu){
        Debug.LogFormat("Benim adim {0} ve yasim {1}",ad,yas);    
        }
        else if(yanlisMi){
            Debug.Log("Some say u will love me one day.");
        }
        else;
    }
    void OnEnable(){//aktif oldugunda calisir
        Debug.Log("I'm enabled.");
    }
    void OnDisable(){//deaktif oldugunda calisir
        Debug.Log("I'm disabled.");
    }
    
}
