using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoving : MonoBehaviour
{
    Rigidbody rb; //Создаём переменную для управления физикой
    public float range = 8f; //Создание переменной для управления скоростью перемещения
    private GameObject MainCamera; //Переменная хранящая объект камеры
    private Vector3 CameraOffset; //Переменная, определяющая сдвиг камеры
    private Vector3 StartPosition; //Установка стартовой позиции
    private Vector3 ControlPointPosition; //Позиция последней контрольной точки


    void Start()
    {
        
        rb = GetComponent<Rigidbody>(); //Получаем доступ к управлению физикой
        
        StartPosition = transform.position; 
        MainCamera = GameObject.Find("Main Camera"); //Получаем объект камеры
        CameraOffset = MainCamera.transform.position - transform.position; //Получаем сдвиг между координатами камеры и позицией игрока
    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal") * range; //Проверка нажатия клавиш. Если влево передаётся -1*range. Вправо: 1*range
        float v = Input.GetAxis("Vertical") * range; //Проверка нажатия клавиш. Если вниз передаётся -1*range. Вверх: 1*range

        rb.velocity = new Vector3(h, 0, v); //Перемещение объекта в зависимости от нажатой клавиши     
    }


<<<<<<< HEAD
    public void PlayerFalled()
    {
        print("wtf");
        RestartAnim.SetBool("BoxOpen", true);
    }

    public void LevelRestart()
    {
        transform.position = StartPosition;
        RestartAnim.SetBool("BoxOpen",  false);
=======
    public void LevelRestart()
    {
        transform.position = StartPosition;
>>>>>>> parent of 6a5b9bb (Сделана анимация окна рестарта)
    }

    public void LevelContinue()
    {
        transform.position = ControlPointPosition;
    }
<<<<<<< HEAD


   void OnTriggerExit(Collider col)
    {
        
        if (col.transform.tag == "FallCollaider")
        {
            
            PlayerFalled();
        }
    }



    /*
    void OnTriggerStay(Collider cal) //Шарик всё ещё не упал
    {
         if (cal.transform.tag == "FallCollaider")
         {
             MainCamera.transform.position = transform.position + CameraOffset;  //Если контакт с коллаидером есть, прибавлять сдвиг шара камере         
         }
    }
    */


    private void OnTriggerEnter(Collider col) //Шарик прошел через контрольную плоскость
    {
        
        if (col.transform.tag == "ControlPoint")
=======
    
    void OnTriggerStay(Collider cal) //Проверка на столкновение с коллаидером отслеживающим падение
        {

            if (cal.transform.tag == "FallCollaider")
            {
                MainCamera.transform.position = transform.position + CameraOffset;  //Если контакт с коллаидером есть, прибавлять сдвиг            
            }
        }

    private void OnTriggerEnter(Collider cal)
    {
        if (cal.transform.tag == "ControlPoint")
>>>>>>> parent of 6a5b9bb (Сделана анимация окна рестарта)
        {
            ControlPointPosition = col.gameObject.transform.position;
            
        }
     

    }

}
