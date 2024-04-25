using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloorScript : MonoBehaviour
{
    [SerializeField] GameObject[] obj;
    [SerializeField] float[] MovingRange;
    private float time = 0.0f;
    [SerializeField] float adjust = 0.01f;
    private void Update()
    {

        time += Time.deltaTime;
        transform.Translate(
            new Vector3(MovingRange[0] * Mathf.Cos(time * Mathf.PI * adjust), MovingRange[1] * Mathf.Sin(time * Mathf.PI * adjust), 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SetParent(null);
        }
    }
}
