using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            StartCoroutine(DanceMove());
        }
    }
    IEnumerator DanceMove()
    {
        FindObjectOfType<PlayMove>().anim.SetBool("isDance", true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
