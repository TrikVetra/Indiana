using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - player.transform.position;

    }


    


    void LateUpdate()
    {
        
        if (player.transform.position.y > 1.9) { //1.9 минимальная высота сферы
            transform.position = player.transform.position + offset;
        }

    }

    

}
