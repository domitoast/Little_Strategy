using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP = 100;
    public int Damage = 5;
    public float speed=5f;
    public float movespeed = 5f;
    public Animator animator;

    public AudioSource audioSource;

    public Transform attackpoint;
    public LayerMask enemylayer;
    public float attackrange = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        // if (Input.GetKeyDown(KeyCode.Space)){
        //     takeDamage(20);
        // }
    }


    void takeDamage(int damage){
        HP-=damage;
        if (HP<=0){
            HP = 0;
            animator.SetTrigger("die"); 
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="knight"){
            speed = 0;
            animator.SetTrigger("attack");
            
        }
    }

    void Death(){
        Destroy(gameObject);
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "knight"){
            speed = movespeed;
            animator.SetTrigger("run");
        }
        else{
            
        }
    }

    void heatsound(){
        gameObject.GetComponent<AudioSource>().Play();
    }

    void Attack(){
        Collider2D[] all_enemy = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayer);
        if (all_enemy != null){
            foreach(Collider2D enemy in all_enemy){
                Debug.Log(enemy.gameObject.name);
                // enemy.transform.GetComponent<Monster>().takeDamage(this.Damage);
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
}
