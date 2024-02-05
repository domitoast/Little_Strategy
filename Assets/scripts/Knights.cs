using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knights : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP = 100;
    public int attack;
    public float movespeed = 2f;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movespeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space)){
            takeDamage(20);
        }
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
        if (other.gameObject.tag=="enemy"){
            animator.SetTrigger("attack");
        }
        else if (other.gameObject.tag == gameObject.tag){
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), other.collider);
        }
    }

    void Death(){
        Destroy(gameObject);
    }

    void fixdiePosition(){
        transform.Translate(0, -1f, 0);
    }
    
    void SetPivot(SpriteRenderer spriteRenderer, Vector2 pivot)
    {
        Vector3 offset = spriteRenderer.bounds.center - spriteRenderer.transform.position;
        spriteRenderer.transform.position += new Vector3((pivot.x - 0.5f) * offset.x, (pivot.y - 0.5f) * offset.y, 0f);
    }
}
