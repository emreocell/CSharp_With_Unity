using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structs : MonoBehaviour
{
    Character figheter,archer,wizard;
    Weapons claymore,bow,wand;
    void Start()
    {
        Character fighter=new Character();
        fighter.Strenght=30;
        fighter.Ability=4;
        fighter.Speed=24;
        fighter.Charisma=19;
        fighter.Luck=15;
        Character archer=new Character();
        archer.Strenght=15;
        archer.Ability=15;
        archer.Speed=29;
        archer.Charisma=27;
        archer.Luck=25;
        Character wizard=new Character();
        wizard.Strenght=7;
        wizard.Ability=30;
        wizard.Speed=12;
        wizard.Charisma=30;
        wizard.Luck=30;

        Weapons claymore=new Weapons();
        claymore.Power=25;
        claymore.Weight=15;
        claymore.Durability=25;
        claymore.IsHave=true;
        Weapons bow=new Weapons();
        bow.Power=25;
        bow.Weight=5;
        bow.Durability=20;
        bow.IsHave=true;
        Weapons wand=new Weapons();
        wand.Power=30;
        wand.Weight=5;
        wand.Durability=10;
        wand.IsHave=false;

        if(claymore.IsHave){
            fighter.Strenght+=claymore.Power;
            fighter.Speed-=claymore.Weight;
        }
        else;
        if(bow.IsHave){
            archer.Strenght+=bow.Power;
            archer.Speed-=bow.Weight;
        }
        else;
        if(wand.IsHave){
            wizard.Strenght+=wand.Power;
            wizard.Speed-=wand.Weight;
        }

    }

    // Update is called once per frame
    void OnDisable() {
        
    }
}
