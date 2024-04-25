using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamWaterScript : MonoBehaviour
{
    public GameObject explosion;
    private GameObject BeamPoint;
    [SerializeField] float delete_time;
    float elapsed_time = 0;
    bool wave = false;

    private void Start()
    {
        BeamPoint = GameObject.FindWithTag("BeamPoint");
        elapsed_time = 0;
    }

    private void Update()
    {
        //transform.rotation = Quaternion.LookRotation(transform.position - BeamPoint.transform.position);
        //transform.Rotate(0, -180, 0);

        if (wave)
        {
            elapsed_time -= Time.deltaTime;
            transform.Translate(VectorAlpha.RandomVector3() * elapsed_time * 3.0f);
        }
        if (elapsed_time < 0 && wave)
        {
            Destroy(gameObject);
            wave = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Vector3 position = other.transform.position;
            position.y += 0.5f;
            other.transform.position = position;
            Destroy(gameObject);
            Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            elapsed_time = delete_time;
            //Destroy(other.gameObject);
        }

        if (other.tag == "Boss")
        {
            Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity);
            //BossHp.Damage(100);
            //Destroy(gameObject);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            elapsed_time = delete_time;
            wave = true;
            Debug.Log("HitBoss");
            BossScript.wave_set();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //if (other.tag == "Enemy")
        //{
        //    
        //    other.transform.Translate(VectorAlpha.RandomVector3() * Mathf.Pow(elapsed_time,3.0f));
        //    if (elapsed_time < 0)
        //    {
        //        Destroy(other.gameObject);
        //    }
        //}
        
        if (other.tag == "Boss")
        {
        }
    }
}
