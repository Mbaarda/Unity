using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;

    public GunController theGun;
    public GunController theGan;

    public bool useController;

	// Use this for initialization
	void Start ()
    {
        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();

      
	}
	
	// Update is called once per frame
	void Update ()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;


        //rotate with mouse
        if (!useController)
        {
            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;

            if (groundPlane.Raycast(cameraRay, out rayLength))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            }

            if (Input.GetMouseButtonDown(0))

                theGun.isFiring = true;

            if (Input.GetMouseButtonUp(0))

                theGun.isFiring = false;

            if (Input.GetMouseButtonDown(0))

                theGan.isFiring = true;

            if (Input.GetMouseButtonUp(0))

                theGan.isFiring = false;

        }

        // rotate with controller
        if (useController)
        {
            Vector3 playerDirection = Vector3.right * Input.GetAxis("RHorizontal") + Vector3.forward * -Input.GetAxis("RVertical");
            if(playerDirection.sqrMagnitude > 0.0f)
            {
                transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
            }

            if (Input.GetKeyDown(KeyCode.Joystick1Button5))
            {
                theGun.isFiring = true;
                Debug.Log("dfsjoefyiuseyf");
            }
            if (Input.GetKeyUp(KeyCode.Joystick1Button5))
                theGun.isFiring = false;
            if (Input.GetKeyDown(KeyCode.Joystick1Button5))
                theGan.isFiring = true;
            if (Input.GetKeyUp(KeyCode.Joystick1Button5))
                theGan.isFiring = false;

        }
    }

    void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }

}
