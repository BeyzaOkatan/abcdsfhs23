using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    GameObject destroyedTree;
    public GameObject Tree1, Tree2, Tree3, Tree4;
    Vector3 destroyedTransform;
    public ParticleSystem partical;
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
        partical.Play();
        Debug.Log("AAAAAAAAAAAAAAAAA");
        Instantiate(Tree2, destroyedTransform, Quaternion.identity);
    }

    IEnumerator Tree2_3()
    {
        //Kesme Anim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);

        destroyedTree = GameObject.FindWithTag("Tree2");
        Destroy(destroyedTree);
        partical.Play();

        Instantiate(Tree3, destroyedTransform, Quaternion.identity);
    }

    IEnumerator Tree3_4()
    {
        //Kesme Anim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);

        destroyedTree = GameObject.FindWithTag("Tree3");
        Destroy(destroyedTree);
        partical.Play();

        Instantiate(Tree4, destroyedTransform, Quaternion.identity);
    }

    IEnumerator DestroyTree4()
    {
        //KesmeAnim
        //PuanKazanma

        yield return new WaitForSeconds(0.5f);
        destroyedTree = GameObject.FindWithTag("Tree4");
        Destroy(destroyedTree);
        partical.Play();
    }

    void InsTree()
    {
        int random = Random.Range(1, 7);
        Vector3 InsTransform = new Vector3(-10.85f, 6.81f, -2.91f);
        Vector3 InsTransform2 = new Vector3(9.24f, 6.81f, -2.91f);
        Vector3 InsTransform3 = new Vector3(4.19f, 6.81f, -11.7f);
        Vector3 InsTransform4 = new Vector3(-5.53f, 6.81f, -11.7f);
        Vector3 InsTransform5 = new Vector3(-5.53f, 6.81f, 6.9f);
        Vector3 InsTransform6 = new Vector3(4.24f, 6.81f, 6.9f);

        switch (random)
        {
            case 1:
                Instantiate(Tree1, InsTransform, Quaternion.identity);
                break;
            case 2:
                Instantiate(Tree1, InsTransform2, Quaternion.identity);
                break;
            case 3:
                Instantiate(Tree1, InsTransform3, Quaternion.identity); 
                break;
            case 4:
                Instantiate(Tree1, InsTransform4, Quaternion.identity); 
                break;
            case 5:
                Instantiate(Tree1, InsTransform5, Quaternion.identity); 
                break;
            case 6:
                Instantiate(Tree1, InsTransform6, Quaternion.identity); 
                break;


                //Instantiate(Tree1, InsTransform, Quaternion.identity);
                
        }
    }
}
