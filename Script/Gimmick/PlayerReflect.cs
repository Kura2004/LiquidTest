using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReflect : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.rigidbody.velocity = new Vector3(0, 0, 0);
            collision.transform.position = new Vector3(transform.position.x, 0.75f, transform.position.z);
        }
    }
}
