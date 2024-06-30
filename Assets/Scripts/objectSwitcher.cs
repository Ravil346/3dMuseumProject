using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSwitcher : MonoBehaviour
{
    public GameObject[] objectsToSwitch; // Массив объектов, между которыми будем переключаться
  
    public float rotateSpeed = 50f;  // Скорость вращения
    private int d = 0;
  

    public GameObject currentIndex;         // Текущий индекс объекта в массиве

    void Start()
    {
        currentIndex = objectsToSwitch[0];
        objectsToSwitch[0].SetActive(true);
        objectsToSwitch[1].SetActive(false);
        objectsToSwitch[2].SetActive(false);
    }
    
    public void SwitchObject()
   {
        currentIndex.SetActive(false);  // Скрываем текущий объект
        currentIndex = (currentIndex == objectsToSwitch[0]) ? objectsToSwitch[1] : (currentIndex == objectsToSwitch[1]) ? objectsToSwitch[2] : objectsToSwitch[0];  // Меняем объект
        currentIndex.SetActive(true);  // Показываем новый объект
        Debug.Log(d);
        d = (d == 0) ? 1 : (d == 1) ? 2 : 0;
     Debug.Log(d);
   }

   public void SwitchBackObject()
   {
        
        currentIndex.SetActive(false);  // Скрываем текущий объект
        currentIndex = (currentIndex == objectsToSwitch[2]) ? objectsToSwitch[1] : (currentIndex == objectsToSwitch[1]) ? objectsToSwitch[0] : objectsToSwitch[2];  // Меняем объект CКОРЕЕ ВСЕГО ТУТ ОШИБКА
        currentIndex.SetActive(true);  // Показываем новый объект
        Debug.Log(d);
        d = (d == 2) ? 1 : (d == 1) ? 0 : 2;
        Debug.Log(d);
   }



   
}
