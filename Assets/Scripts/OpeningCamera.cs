using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpeningCamera : MonoBehaviour
{
    Camera cam;
    [SerializeField] float camx;
    [SerializeField] float camy = 0.5f;
    [SerializeField] float camz = 3;
    [SerializeField] float transitionTime = 1f;
    public Transform heroTransform;
    public bool ok;

    private void Start()
    {
        cam = Camera.main;
        Vector3 targetPosition = heroTransform.position + new Vector3(camx, camy, camz);
        StartCoroutine(CameraMovement(targetPosition, transitionTime));
    }
    public void PlayClick()
    {
        cam = Camera.main;
        Vector3 targetPosition = cam.transform.position + new Vector3(camx, camy, camz);
        StartCoroutine(CameraMovement(targetPosition, transitionTime));
    }

    

    IEnumerator CameraMovement(Vector3 targetPosition, float transitionTime)
    {

        cam = Camera.main;
        Vector3 startingPosition = cam.transform.position;
        for (float t = 0f; t < transitionTime; t += Time.deltaTime)
        {
            cam.transform.position = Vector3.Lerp(startingPosition, targetPosition, t / transitionTime);
            yield return null;
        }

        cam.transform.position = targetPosition;
        ok = true;

    }


}