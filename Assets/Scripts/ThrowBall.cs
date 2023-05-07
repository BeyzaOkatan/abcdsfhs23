using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] GameObject PlayerGameObject;

    public void ThroWball()
    {
        print("at bi tane");
        GameObject ball = Instantiate(ballPrefab, PlayerGameObject.transform.position + PlayerGameObject.transform.forward, Quaternion.identity);
        ball.GetComponent<Rigidbody>().AddForce(transform.forward);
    }
}
