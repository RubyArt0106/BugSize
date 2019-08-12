using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Life : MonoBehaviour
{
    public int health = 100;

    public GameObject effectMuerte;

    public void TakeDamage(int damage)
    {
        health -= health;
        if(health <= 0)
        {
            Muere();
        }
    }

    void Muere()
    {
        Instantiate(effectMuerte, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }
}
