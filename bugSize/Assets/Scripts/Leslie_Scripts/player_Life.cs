using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Life : MonoBehaviour
{
    float timer = 0.5f;
    public int health;
    private Animator anim;
    //public GameObject effctMuerte;   <_Para el sprite de muerte
    public void TakeDamage(int damageGiven)
    {
        health -= damageGiven;
        Debug.LogWarning("Daño");
        anim.SetBool("isDamage", true);
        if(timer >= 0)
        {
            timer -= Time.deltaTime;
            anim.SetBool("isDamage", false);
            timer = 0.5f;
        }
        if (health <= 0)
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

    void Start()
    {
        anim = GetComponent<Animator>();
    }
}
