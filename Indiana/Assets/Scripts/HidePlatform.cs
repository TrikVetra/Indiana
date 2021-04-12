using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlatform : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Player")
        {
            //print(gameObject.name);
            Invoke("GravityON", 1.5f); //Задержка выполнения
        }
    }
    void GravityON()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); //Включение гравитации
        rb.isKinematic = false;
    }

    void Update()
    {
        if (transform.position.y < 50)
        {
            Destroy(this.gameObject);
        }
    }

}
