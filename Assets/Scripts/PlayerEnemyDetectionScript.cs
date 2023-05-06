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
            CharacterMovement.isEnemyHere = true;
            StartCoroutine(wait(other));
            isBeesy = true;
            EnemyScript.isWaited = true;
        }
    }
    IEnumerator wait(Collider other)
    {
        enemyScript.EnemyDamage(other);
        yield return new WaitForSeconds(1f);
        isBeesy = false;
    }
}
