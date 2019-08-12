using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_disparar : MonoBehaviour
{
    public GameObject mirilla;
    public GameObject weapon;
    public GameObject bullet;
    public float bulletSpeed;
    private Vector3 target;

    public Transform bulletPoint;
    private float tempoEntreDisparo;
    public float iniTempoEntreDisparo;
    /*___________Start________*/
    void Start()
    {
        Cursor.visible = false;
    }/*___________Start________*/

    /*_______Update___________*/
    void Update()
    {
        //Mirilla
        target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        mirilla.transform.position = new Vector2(target.x, target.y);
        //Rotacion
        Vector3 difference = target - weapon.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        //Dispara
        if (tempoEntreDisparo <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;
                direction.Normalize();
                fireBullet(direction, rotationZ);
                tempoEntreDisparo = iniTempoEntreDisparo;
            }
        }
        else
        {
            tempoEntreDisparo -= Time.deltaTime;
        }
    }/*_______Update___________*/

    /*________Disparar_________*/
    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bullet) as GameObject;
        b.transform.position = bulletPoint.transform.position;
        b.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }/*________Disparar_________*/
}
