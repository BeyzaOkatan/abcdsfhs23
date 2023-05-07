using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDirt : MonoBehaviour
{
    public GameObject Dirt, ColectableDirt, waterOnTank;
    float insx, insz;
    bool isCollis=false;
    bool isWater=false;
    Vector3 destroyedDirtTransform;
    public ParticleSystem waterParticle;
    public int suPuan;
    void Start()
    {
        waterParticle.Stop();

    }

    // Update is called once per frame
    void Update()
    {

    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dirt")
        {
            InsDrt();
            waterParticle.Play();
            suPuan += 1;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Dirt")
        {
            waterParticle.Stop();
        }
    }

    void InsDrt()
    {
        insx = Random.Range(-13, 13);
        insz = Random.Range(-27, -3);
        Vector3 InsTransform = new Vector3(insx, 25.6f, insz);

        Instantiate(Dirt, InsTransform, Quaternion.identity);
    }

/*    void InsCollectDirt()
    {
        Instantiate(ColectableDirt, destroyedDirtTransform, Quaternion.identity);
    }




    /*
    void isWaters()
    {
        if (SuHakký > 0)
        {
            isWater = true;
            waterOnTank.SetActive(true);
        }

        else
        {
            isWater = false;
            waterOnTank.SetActive(false);
        }
    }

    void needWater()
    {
        Debug.Log("su topla");
    }*/
    /*
    void isWaterParticle()
    {
        if(isWater == false)
        {
            waterParticle.Stop();
        }
    }*/
}
