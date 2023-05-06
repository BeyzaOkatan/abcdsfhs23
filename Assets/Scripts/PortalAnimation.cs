using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAnimation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hero")
        {
            Debug.Log("asasdasdasd");
            transform.parent.GetChild(2).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Hero")
        {
            transform.parent.GetChild(2).gameObject.SetActive(false);

        }
    }
}
