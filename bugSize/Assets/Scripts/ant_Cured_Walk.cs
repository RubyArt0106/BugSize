﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ant_Cured_Walk : MonoBehaviour
{
    public float speed;
    bool der = true;
    private Transform target;
    /*__________Start___________*/
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();

    }/*__________Start___________*/
    /*__________Update___________*/
    void Update()
    {    //Sigue al jugador
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //
        //Mira al Jugador
        var delta = target.position - transform.position;
        if (delta.x >= 0 && !der)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            der = true;
        }
        else if (delta.x < 0 && der)
        {
            transform.localScale = new Vector3(1, 1, 1);
            der = false;
        }
    }
}
