using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGetter : MonoBehaviour
{
    private GameObject alev;
    private TextMeshProUGUI alevtext;
    private GameObject su;
    private TextMeshProUGUI sutext;

    // Update is called once per frame
    void Update()
    {
        alev = transform.GetChild(0).gameObject;
        alevtext = alev.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        su = transform.GetChild(1).gameObject;
        sutext = su.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        alevtext.text = Envanter.ReturnAlev();
        sutext.text = Envanter.ReturnSu();
    }
}
