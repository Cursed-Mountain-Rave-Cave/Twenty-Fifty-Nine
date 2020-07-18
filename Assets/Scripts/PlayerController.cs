using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float normalSpeed;
    public float cameraSpeed;
    public Camera not_camera;
    public CharacterController charController;
    public float gravity;
    float y = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

        if (Math.Abs(not_camera.transform.rotation.eulerAngles.x - Time.deltaTime * cameraSpeed * Input.GetAxis("Mouse Y") - 180) > 90)
        {
            not_camera.transform.Rotate(-Time.deltaTime * cameraSpeed * Input.GetAxis("Mouse Y"), 0, 0);
        }
        transform.Rotate(0, Time.deltaTime * cameraSpeed * Input.GetAxis("Mouse X"), 0);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float speed = normalSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed *= 2;
        }

        Vector3 move = transform.right * x + transform.forward * z;
        charController.Move(move * speed * Time.deltaTime);

        y += gravity * Time.deltaTime;
        charController.Move(new Vector3(0,y,0) * Time.deltaTime);
    }
}
