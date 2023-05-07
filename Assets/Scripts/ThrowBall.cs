using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] GameObject PlayerGameObject;
    [SerializeField] GameObject kutus;

    public void ThroWball()
    {
        print("at bi tane");
        StartCoroutine(at());
        
    }
    IEnumerator at()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject ball = Instantiate(ballPrefab, PlayerGameObject.transform.position + PlayerGameObject.transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
        Vector3.MoveTowards(ball.transform.position, kutus.transform.position, 0.5f);
        yield return new WaitForSeconds(0.3f);
    }
}
