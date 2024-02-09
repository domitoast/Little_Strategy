using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(int num){
        HP-=num;
        if(HP<0){
            HP = 0;
        }
    }

    
    public GameObject[] monsters;
    void createmonster1(){
        GameObject g = Instantiate(monsters[0], transform);
        g.transform.position = new Vector3(21f, -2.27f, 1.5f);
         
    }
    void createmonster2(){
        GameObject g = Instantiate(monsters[1], transform);
        g.transform.position = new Vector3(21f, -2.14f, 1.5f);
        
    }
    void createmonster3(){
        GameObject g = Instantiate(monsters[2], transform);
        g.transform.position = new Vector3(21f, -1.88f, 1.5f);
    }
    void createmonster4(){
        GameObject g = Instantiate(monsters[3], transform);
        g.transform.position = new Vector3(21f, -1.5f, 1.5f);
    }

    void createmonster5(){
        GameObject g = Instantiate(monsters[4], transform);
        g.transform.position = new Vector3(21f, -0.65f, 1.5f);
    }

}
