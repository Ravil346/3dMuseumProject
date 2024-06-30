using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed = 5f;
    private bool isHoldingRigth = false;
    private bool isHoldingLeft = false;
    void Start()
    {
        // Находим UI кнопку в сцене
        Button rotateButton = GameObject.Find("Right").GetComponent<Button>();
        Button rotateLeftButton = GameObject.Find("Left").GetComponent<Button>();

        // Добавляем обработчик события на нажатие кнопки
        // rotateButton.onClick.AddListener(RotateObject);
        
        // rotateLeftButton.onClick.AddListener(RotateLeftObject);
    }

    void Update()
    {
        if (isHoldingRigth)
        {
            // Вращаем объект вокруг оси Y
            
            transform.Rotate(0, -rotateSpeed  *  Time.deltaTime, 0);
        }
        if (isHoldingLeft)
        {
            // Вращаем объект вокруг оси Y
            
            transform.Rotate(0, rotateSpeed  *  Time.deltaTime, 0);
        }
    }
    
    public void OnMouseDown()
    {
        isHoldingRigth = true;
    }

    public void OnMouseUp()
    {
        isHoldingRigth = false;
    }

    public void LeftOnMouseDown()
    {
        isHoldingLeft = true;
    }

    public void LeftOnMouseUp()
    {
        isHoldingLeft = false;
    }

    // void RotateObject()
    // {
    //     // Поворачиваем объект вокруг оси Y
    //     transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
    // }

    // void RotateLeftObject()
    // {
    //     // Поворачиваем объект вокруг оси Y
    //     transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    // }
    
    
}
