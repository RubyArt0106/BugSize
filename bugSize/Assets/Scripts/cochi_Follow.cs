using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cochi_Follow : MonoBehaviour
{
    public float speed;
    public float rollspeed;
    bool der = true;
    bool follow = false;
    bool rolls;

    public GameObject disCheck;
    private Transform target;
    private Animator anim;
    /*__________Start___________*/
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }/*__________Start___________*/
    
    /*__________Update___________*/
    void Update()
    {
        //Mira al Jugador
        var delta = target.position - transform.position;
        if (delta.x >= 0 && !der)
        {
            transform.localScale = new Vector3(1, 1, 1);
            der = true;
        }
        else if (delta.x < 0 && der)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            der = false;
        }
       
    }/*__________Update___________*/



    private void FixedUpdate()
    {
        if (follow == true && rolls == false)
        {//Camina
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if (follow == true && rolls == true)
        {//Pelotita
            
            transform.position = Vector2.MoveTowards(transform.position, target.position, (speed * rollspeed) * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            if (follow == false)
            {
                anim.SetBool("isMoving", true);
                follow = true;
                rolls = false;
            }
            else if(follow == true)
            {
                rolls = true;
                anim.SetBool("isRolling", true);
            }
        }
    }
    /**
    public void Rollstatus(bool )
    {
        isRolling ==
    }
    **/




}
