using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Gate1")
        {
            Debug.Log("1");
            StartCoroutine(TeleportRoutine("1"));
        }
        if (other.gameObject.name == "Gate2")
        {
            Debug.Log("2");

            StartCoroutine(TeleportRoutine("2"));

        }
        if (other.gameObject.name == "Gate3")
        {
            Debug.Log("3");

            StartCoroutine(TeleportRoutine("3"));

        }
        if (other.gameObject.name == "Gate4")
        {
            Debug.Log("4");

            StartCoroutine(TeleportRoutine("4"));

        }
    }

    IEnumerator TeleportRoutine(string sceneName)
    {
        yield return new WaitForSeconds(1f); 
        SceneManager.LoadScene(sceneName);
    }
}
