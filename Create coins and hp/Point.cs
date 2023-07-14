 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int value;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log($"Collide, {col.tag}, {col.tag == "Player"}, {value}");
        if (col.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddGold(value);
            Destroy(gameObject);
        }
    }
}
