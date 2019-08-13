using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Attack : MonoBehaviour
{

    public GameObject aCheck;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Attack_true");
            anim.SetBool("isAttack", true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Attack_false");
            anim.SetBool("isAttack", false);
        }
    }
}
