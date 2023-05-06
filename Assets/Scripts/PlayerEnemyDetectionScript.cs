using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyDetectionScript : MonoBehaviour
{
    private SphereCollider sphereCollider;
    private GameObject enemyObject;
    private float timee;
    private EnemyScript enemyScript;
    private bool isBeesy;
    private void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        enemyScript = enemyObject.GetComponent<EnemyScript>();  
        isBeesy = false;
    }
   

    private void OnTriggerStay(Collider other)
    {
        if (!isBeesy && other.tag == "Enemy")
        {
            StartCoroutine(wait(other));
            isBeesy = true;
        }
    }
    IEnumerator wait(Collider other)
    {
        enemyScript.EnemyDamage(other);
        yield return new WaitForSeconds(1f);
        isBeesy = false;
    }
}
