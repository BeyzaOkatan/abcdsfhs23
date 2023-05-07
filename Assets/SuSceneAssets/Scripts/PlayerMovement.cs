using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody Rb;
    float vertical, horizontal;
    public float speed;
    [SerializeField] Animator animator;
    public bool isMove;
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isMove);
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        
        if(vertical != 0 || horizontal != 0)
        {
            isMove = true;
            animator.SetBool("isRunning", true);

            Vector3 direction = new Vector3(horizontal, 0, vertical);
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10);
        }
        else
        {
            isMove = false;
            animator.SetBool("isRunning", false);
        }
    }

    private void FixedUpdate()
    {
        Rb.velocity = new Vector3(horizontal * speed * Time.deltaTime, Rb.velocity.y, vertical * speed * Time.deltaTime);
    }

}
