using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemaningAlev : MonoBehaviour
{
    private GameObject alev;
    private TextMeshProUGUI alevtext;

    // Update is called once per frame
    void Update()
    {
        alev = transform.GetChild(0).gameObject;
        alevtext = alev.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        alevtext.text = Envanter.yerdekialevsayisi.ToString();
    }
}
