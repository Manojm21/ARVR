using UnityEngine;

public class ObjectMover : MonoBehaviour
{

public GameObject cube;
    public float moveSpeedX = 5f;
    public float moveSpeedZ = 3f;
    public float rotationSpeedY = 45f;
    public float scaleFactorX = 1.1f;

    void Update()
    {
        // Move object in different directions
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cube.transform.position += Vector3.forward * moveSpeedZ * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cube.transform.position += Vector3.back * moveSpeedZ * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cube.transform.position += Vector3.left * moveSpeedX * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            cube.transform.position += Vector3.right * moveSpeedX * Time.deltaTime;
        }

        // Rotate object along Y-axis
        if (Input.GetKey(KeyCode.R))
        {
            cube.transform.Rotate(0, rotationSpeedY * Time.deltaTime, 0);
        }

        // Scale object along X-axis
        if (Input.GetKeyDown(KeyCode.X))
        {
            cube.transform.localScale = new Vector3(transform.localScale.x * scaleFactorX,
                                               transform.localScale.y,
                                               transform.localScale.z);
        }
    }
}
