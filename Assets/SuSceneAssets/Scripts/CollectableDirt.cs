using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectableDirt : MonoBehaviour
{
    public new List<GameObject> CollectDirtList;
    public TextMeshProUGUI waterText;

    
    void Update()
    {
      waterText.text = CollectDirtList.Count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CollectableDirt")
        {
            CollectDirtList.Add(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
