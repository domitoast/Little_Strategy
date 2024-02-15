using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, TakeDamage
{
    // Start is called before the first frame update
    public int HP = 1000;
    public HPbar hpbar;
    
    public int coins = 40;
    public float timechange;

    public Text cointext;

    // Update is called once per frame
    void Update()
    {
        
        timechange += Time.deltaTime ;
        if (timechange>1){
            coins+=1;
            timechange-=0.25f;
        }
        
        cointext.text = coins.ToString();

    }

    public void takeDamage(int damage){
        HP -= damage;
        if(HP<0){
            HP = 0;
        }
        hpbar.setValue(HP);
    }


    void changecoin(int c){
        coins += c;

        cointext.text = coins.ToString();
    }

    public GameObject[] knights;

    public void createKnight1(){
        if (coins>=40){
            GameObject g = Instantiate(knights[0], transform);
            g.transform.position = new Vector3(-18f, -1.55f, 1.5f);
            coins-=40;
        }
    }
    public void createKnight2(){
        if (coins>=60){
            GameObject g = Instantiate(knights[1], transform);
            g.transform.position = new Vector3(-18f, -1.28f, 1.5f);
            coins-=60;
        }  
    }
    public void createKnight3(){
        if (coins>=100){
            GameObject g = Instantiate(knights[2], transform);
            g.transform.position = new Vector3(-18f, -1.11f, 1.5f);
            coins-=100;
        }
    }
    public void createKnight4(){
        if (coins>=150){
            GameObject g = Instantiate(knights[3], transform);
            g.transform.position = new Vector3(-18f, -0.88f, 1.5f);
            coins-=150;
        }

    }


    

}
