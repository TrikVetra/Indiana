using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CollectSeed : MonoBehaviour
{
    public int score;
    public UnityEvent OnEat; 

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Seed")
        {
            if (OnEat != null) //Инициализация события OnEat
            {
                OnEat.Invoke();
            }
            AddScore(); //Вызов метода добавления очков
            Destroy (col.gameObject); //Уничтожение объекта
        }
    }

    
    void AddScore() //Метод добавления очков
    {
        score++;
        GameObject Score = GameObject.Find("Score"); //Получение объекта-счетчика
        Text scoreText = Score.GetComponent<Text>(); //Получение компонента-счётчика
        scoreText.text = "" + score; //Изменение счётчика        
    }
    
}
