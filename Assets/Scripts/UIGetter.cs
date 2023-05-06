using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGetter : MonoBehaviour
{
    private GameObject alev;
    private TextMeshProUGUI alevtext;

    // Update is called once per frame
    void Update()
    {
        alev = transform.GetChild(0).gameObject;
        alevtext = alev.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        alevtext.text = Envanter.ReturnAlev();
    }
}
