using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Life : MonoBehaviour
{
    public int health;
    //public GameObject effctMuerte;   <_Para el sprite de muerte
    public void TakeDamage(int damageGiven)
    {
        health -= damageGiven;
        if(health <= 0)
        {
            Debug.LogWarning("Muerte");
            //Muere();
        }
    }
    /*void Muere()
    {
        Instantiate(effectMuerte, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }*/
}
