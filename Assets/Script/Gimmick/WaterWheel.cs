using UnityEngine;

public class WaterWheel : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] float rotation_time;
    float now_speed;
    float elapsed_time = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beam")
        {
            elapsed_time = rotation_time;
            RotateWheel();
        }
    }

    private void FixedUpdate()
    {
        RotateWheel();
    }

    private void RotateWheel()
    {
        // ���Ԃ���]������
        elapsed_time -= Time.fixedDeltaTime;

        if (elapsed_time > 0)
            now_speed = Mathf.Pow(elapsed_time , 3.0f);

        else
        {
            now_speed = 0;
        }
        transform.Rotate(Vector3.up * now_speed * rotationSpeed);
        Debug.Log("hitWaterWheel");
    }
}

