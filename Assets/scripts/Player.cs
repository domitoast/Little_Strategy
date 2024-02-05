using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP = 100;
    public HPbar hpbar;
    
    public int coins = 0;

    public Text cointext;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            takeDamage(20);
            changecoin(10);
        }

    }

    public void takeDamage(int num){
        HP-=num;
        if(HP<0){
            HP = 0;
        }
        hpbar.setValue(HP);
    }


    void changecoin(int c){
        coins += c;
        cointext.text = "COINS: " + coins.ToString();

    }
}
