using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public float inactivityTimer = 5.0f; // Время бездействия в секундах
    private float timer;

    private void Start()
    {
        timer = inactivityTimer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            StartCoroutine(LoadFirstScene());
        }
        else if (Input.anyKey || Input.GetMouseButton(0))
        {
            timer = inactivityTimer; // Сбросить таймер, если было активное действие
        }
    }

    private IEnumerator LoadFirstScene()
    {
        yield return new WaitForSeconds(1.0f); // Дополнительное ожидание перед переходом
        
        SceneManager.LoadScene(0); // Загрузить первую сцену (индекс 0)
    }
}
