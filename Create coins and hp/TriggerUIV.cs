using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUIV : MonoBehaviour
{
    public int valueDown;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<HealthPlayer>().health -= valueDown;
        }
    }
}