using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    void OnDisable() {
        int[] numbers={Random.Range(1,100),Random.Range(1,100),Random.Range(1,100)};//random sayı atama
        string numberText;


        for(int i=0;i<numbers.Length;i++){//for dongusu ornek
            numberText=(numbers[i]%2==0) ? "even" : "odd";//if kullanmadan degisken degistirme . Icerideki ifade true donduruse even false dondururse odd olarak tanimla
            Debug.Log(numbers[i]+" is "+numberText);
        }
    }
    
}
