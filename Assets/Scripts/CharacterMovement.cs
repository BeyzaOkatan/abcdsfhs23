using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speedh, speedv;
    private float controllerx, controllerz;

    // Update is called once per frame
    void Update()
    {
         controllerx = Input.GetAxis("Horizontal");
         controllerz = Input.GetAxis("Vertical");

        transform.position += new Vector3(controllerx * speedh * Time.deltaTime, 0, controllerz * speedv * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
