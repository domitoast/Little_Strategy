using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, TakeDamage
{
    public int HP = 1000;
    float monsterchange = 0;
    float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monsterchange += Time.deltaTime;
        timer += Time.deltaTime;

        if (timer > 5){
            if (monsterchange < 30){
                createmonster1();
            }else if (monsterchange < 60){
                createmonster2();
            }else if (monsterchange < 100){
                createmonster3();
            }else if (monsterchange < 140){
                createmonster4();
            }else if (monsterchange < 180){
                createmonster5();
            }
            timer-=5;
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            createmonster1();
        }


        

    }
    public void takeDamage(int damage){
        HP -= damage;
        if(HP<0){
            HP = 0;
            Lose();
        }
    }

    
    public GameObject[] monsters;
    void createmonster1(){
        GameObject g = Instantiate(monsters[0], transform);
        g.SetActive(true);
        g.transform.position = new Vector3(21f, -2.27f, 1.5f);
         
    }
    void createmonster2(){
        GameObject g = Instantiate(monsters[1], transform);
        g.SetActive(true);
        g.transform.position = new Vector3(21f, -2.14f, 1.5f);
        
    }
    void createmonster3(){
        GameObject g = Instantiate(monsters[2], transform);
        g.SetActive(true);
        g.transform.position = new Vector3(21f, -1.88f, 1.5f);
    }
    void createmonster4(){
        GameObject g = Instantiate(monsters[3], transform);
        g.SetActive(true);
        g.transform.position = new Vector3(21f, -1.5f, 1.5f);
    }

    void createmonster5(){
        GameObject g = Instantiate(monsters[4], transform);
        g.SetActive(true);
        g.transform.position = new Vector3(21f, -0.65f, 1.5f);
    }

    public GameObject lose;
    void Lose(){
        Time.timeScale = 0;
        lose.SetActive(true);
    }

}
