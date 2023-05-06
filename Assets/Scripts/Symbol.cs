using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(symbolRoutine());
    }

    IEnumerator symbolRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
    }
}
