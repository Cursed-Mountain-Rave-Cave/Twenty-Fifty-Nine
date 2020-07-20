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
    bool Shifted;
    public AudioSource walkSound;
    public AudioClip[] typeWalk; // 0-нормально 1 - быстро
    void Start()
    {
        Shifted = false;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Math.Abs(not_camera.transform.rotation.eulerAngles.x - Time.deltaTime * cameraSpeed * Input.GetAxis("Mouse Y") - 180) > 90)
        {
            not_camera.transform.Rotate(-Time.deltaTime * cameraSpeed * Input.GetAxis("Mouse Y"), 0, 0);
        }
        transform.Rotate(0, Time.deltaTime * cameraSpeed * Input.GetAxis("Mouse X"), 0);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if ((x * x + z * z) != 0)
        {
            if(!Shifted) 
                walkSound.clip = typeWalk[0];
            else
                walkSound.clip = typeWalk[1];

            if (!walkSound.isPlaying)
            {
                walkSound.Play();
            }
            
        }
        else
        {
            Shifted = false;
            walkSound.Stop();
        }

        float speed = normalSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed *= 2;
            Shifted = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Shifted = false;
        }

        Vector3 move = transform.right * x + transform.forward * z;

        charController.Move(move.normalized * speed * Time.deltaTime);

        charController.Move(new Vector3(0,gravity,0) * Time.deltaTime);
    }
}
