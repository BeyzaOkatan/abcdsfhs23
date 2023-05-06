using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private float controllerx, controllerz;
    private Animator animator;
    [SerializeField] Transform transform;
    private Vector3 moveDirection;
    private Rigidbody rb;
    public static bool isEnemyHere;
    private GameObject enemyObject;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        //print(animator.GetBool("isRunning"));
        controllerx = Input.GetAxis("Horizontal");
        controllerz = Input.GetAxis("Vertical");

        moveDirection = transform.forward * controllerz + transform.right * controllerx;

        rb.AddForce(moveDirection.normalized * speed * Time.deltaTime * 10000, ForceMode.Force);
        
        if(moveDirection.normalized != Vector3.zero)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        if (isEnemyHere)
        {
            print("looking enemy");
            LookEnemy();
        }
        else
        {
            transform.rotation *= Quaternion.Euler(0, controllerx, 0);
        }
    }
    void LookEnemy()
    {
        Vector3 lookDirection = enemyObject.transform.position - transform.position;
        lookDirection.y = 0;
        lookDirection.Normalize();
        Quaternion rotation = Quaternion.LookRotation(lookDirection);
        transform.rotation = rotation;
        isEnemyHere = false;
        animator.SetBool("attackset", true);
        Invoke("FinishAttack", 1f);
    }
    void FinishAttack()
    {
        animator.SetBool("attackset", false);
    }
}
  // transform.rotation *= Quaternion.Euler(0, controllerx, 0);