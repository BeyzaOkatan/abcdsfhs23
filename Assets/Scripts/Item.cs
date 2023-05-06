using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    public List<GameObject> fireCoin;
    public List<GameObject> airCoin;
    public List<GameObject> soilCoin;
    public List<GameObject> waterCoin;

    public TextMeshProUGUI fireText;
    public TextMeshProUGUI airText;
    public TextMeshProUGUI soilText;
    public TextMeshProUGUI waterText;

    private void Update()
    {
        fireText.text = fireCoin.Count.ToString();
        airText.text = airCoin.Count.ToString();
        soilText.text = soilCoin.Count.ToString();
        waterText.text = waterCoin.Count.ToString();



    }


}
