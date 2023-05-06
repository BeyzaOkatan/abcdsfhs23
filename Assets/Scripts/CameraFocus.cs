using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public GameObject playerGameObject;
    [SerializeField] float camx, camy, camz;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerposition = playerGameObject.transform.position;
        transform.position = playerposition + new Vector3(camx, camy, camz);
    }
}
