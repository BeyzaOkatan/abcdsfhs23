using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDirt : MonoBehaviour
{
    public new List<GameObject> CollectDirtList;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
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
