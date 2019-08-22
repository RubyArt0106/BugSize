using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Life : MonoBehaviour
{
    public int health;
    public int infection;

    public GameObject effecCured;
    public GameObject effectMuerte;
    public void GitGud(int med)
    {
        infection -= med;
        if (infection <= 0)
        {
            Curado();
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Muere();
        }
    }

    void Curado()
    {
        Instantiate(effecCured, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }
    void Muere()
    {
        Instantiate(effectMuerte, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }
}
