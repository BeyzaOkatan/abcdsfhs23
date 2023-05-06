using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDirt : MonoBehaviour
{
    public GameObject Dirt, ColectableDirt;
    float insx, insz;
    int SuHakk� =3;
    bool isCollis=false;
    bool isWater=false;
    Vector3 destroyedDirtTransform;
    public ParticleSystem waterParticle;
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        isWaters();
        isWaterParticle();

        if (isWater == true && isCollis == true)
        {

        }
        else if (isWater == false && isCollis == true)
        {
            isCollis = false;
            Debug.Log("su bitti");
        }

        else if (isWater == false && isCollis == true)
        {
            InsDrt();
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dirt" && isWater == true)
        {
            isCollis = true;
            destroyedDirtTransform = other.gameObject.transform.position;
            InsCollectDirt();
            Destroy(other.gameObject);
            SuHakk� -= 1;
            InsDrt();
            Debug.Log("Su Hakk�" + SuHakk�);
        }
        else if(other.gameObject.tag == "Dirt" && isWater ==false)
        {
            needWater();
        }

        if (other.gameObject.tag == "WaterPlane")
        {
            SuHakk� = 3;
            Debug.Log("Su Hakk�" + SuHakk�);
            isWater = true;
            waterParticle.Play();
        }
    }


    void InsDrt()
    {
        insx = Random.Range(-13, 13);
        insz = Random.Range(-27, -3);
        Vector3 InsTransform = new Vector3(insx, 25.6f, insz);

        Instantiate(Dirt, InsTransform, Quaternion.identity);
    }

    void InsCollectDirt()
    {
        Instantiate(ColectableDirt, destroyedDirtTransform, Quaternion.identity);
    }

    



    void isWaters()
    {
        if (SuHakk� > 0)
        {
            isWater = true;
        }

        else
        {
            isWater = false;
        }
    }

    void needWater()
    {
        Debug.Log("su topla");
    }

    void isWaterParticle()
    {
        if(isWater == false)
        {
            waterParticle.Stop();
        }
    }
}
