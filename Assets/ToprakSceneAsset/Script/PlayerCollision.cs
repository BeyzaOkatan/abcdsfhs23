using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    GameObject destroyedTree;
    public GameObject Tree1, Tree2, Tree3, Tree4;
    Vector3 destroyedTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Tree1")
        {
            StartCoroutine("Tree1_2");
            //destroyedTree = other.gameObject;
            destroyedTransform = other.gameObject.transform.position;
            Debug.Log("asuýdgbla");
        }

        if (other.gameObject.tag == "Tree2")
        {
            destroyedTransform = other.gameObject.transform.position;
            StartCoroutine("Tree2_3");
        }

        if (other.gameObject.tag == "Tree3")
        {
            destroyedTransform = other.gameObject.transform.position;
            StartCoroutine("Tree3_4");
        }

        if (other.gameObject.tag == "Tree4")
        {
            StartCoroutine("DestroyTree4");
            InsTree();
        }
    }


    IEnumerator Tree1_2()
    {
        //Kesme Anim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);

        destroyedTree = GameObject.FindWithTag("Tree1");
        Destroy(destroyedTree);
        //KesmeParticle

        yield return new WaitForSeconds(0.5f);
        Instantiate(Tree2, destroyedTransform, Quaternion.identity);
    }

    IEnumerator Tree2_3()
    {
        //Kesme Anim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);

        destroyedTree = GameObject.FindWithTag("Tree2");
        Destroy(destroyedTree);
        //KesmeParticle

        yield return new WaitForSeconds(0.5f);
        Instantiate(Tree3, destroyedTransform, Quaternion.identity);
    }

    IEnumerator Tree3_4()
    {
        //Kesme Anim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);

        destroyedTree = GameObject.FindWithTag("Tree3");
        Destroy(destroyedTree);
        //KesmeParticle

        yield return new WaitForSeconds(0.5f);
        Instantiate(Tree4, destroyedTransform, Quaternion.identity);
    }

    IEnumerator DestroyTree4()
    {
        //KesmeAnim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);
        destroyedTree = GameObject.FindWithTag("Tree4");
        Destroy(destroyedTree);
        //KesmeParticle
    }

    void InsTree()
    {
        float randomx = Random.Range(-12, 12);
        float randomz = Random.Range(-15.9f, 11);

        Vector3 InsTransform = new Vector3(randomx, 5.26f, randomz);

        Instantiate(Tree1, InsTransform, Quaternion.identity);
    }

}
