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

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

        if (moveDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            Rb.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);
            //animator.SetBool("isRunning", true);
        }
        else
        {
            //animator.SetBool("isRunning", false);
        }

        if(vertical != 0 || horizontal != 0)
        {
            isMove = true;
            animator.SetBool("isRunning", true);
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
