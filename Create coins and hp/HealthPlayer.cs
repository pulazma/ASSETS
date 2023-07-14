using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public int health;
    public Slider slider;
    void Update()
    {
        slider.value = health;

        if(health < 10)
        {
            SceneManager.LoadScene(3);
        }
    }
}
