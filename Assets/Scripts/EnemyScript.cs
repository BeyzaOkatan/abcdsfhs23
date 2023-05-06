using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private Transform location;
    private NavMeshAgent agent;
    private float maxHealth = 100;
    private float health;
    public Slider slider;
    public GameObject slidergameObject;
    private Rigidbody rb;
    public static float randomx, randomz;
    public static bool isWaited, isWaited2;
    public static int oluDusman = 0;
    private bool oneTime = true;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        print(health + "oluþt");
        agent = GetComponent<NavMeshAgent>();
        location = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = location.position;

        if(health < maxHealth)
        {
            slidergameObject.SetActive(true);
        }
        else if(health > maxHealth)
        {
            health = maxHealth;
        }
        float slidervalue = health / maxHealth;
        slider.value = slidervalue;
    }
    private void OnTriggerEnter(Collider other)
    {
        agent.isStopped = true;
    }
    private void OnTriggerExit(Collider other)
    {
        agent.isStopped = false;
    }
    public void EnemyDamage(Collider other)
    {
        print("bekle");
        StartCoroutine(Waitonesecond());
        print("beklendi");
        if(other.tag == "Enemy" && isWaited)
        {
            print("attacking");
            StartCoroutine(Waitonesecond());
            health = health - 50;
            if (health == 0)
            {
                if(oluDusman >= 1 && oneTime)
                {
                    health += 50;
                    oneTime = false;
                    
                }
                else
                {
                    oluDusman++;
                    RandomTransform();
                    health = 100;
                    print(health);
                }
            }
            isWaited = false;
            
        }
    }
    public void RandomTransform()
    {
        StopCoroutine(Waitonesecond());
        isWaited = false;
        oneTime = true;
        Vector3 vector3 = GameObject.FindGameObjectWithTag("Player").transform.position;
        RandomHesap();
        float distance = Vector3.Distance(transform.position + new Vector3(randomx, 0, randomz), vector3);
        while (distance <= 4.5f)
        {
            RandomHesap();
            distance = Vector3.Distance(transform.position + new Vector3(randomx, 0, randomz), vector3);
        }
        print(new Vector3(randomx, 0, randomz));
        transform.position = new Vector3(randomx, 0, randomz);
        CharacterMovement.isEnemyHere = false;
    }
    private void RandomHesap()
    {
        randomx = Random.Range(-10, 10);
        randomz = Random.Range(-10, 10);
    }
    IEnumerator Waitonesecond()
    {
        yield return new WaitForSeconds(1f);
        isWaited = true;
    }
}
