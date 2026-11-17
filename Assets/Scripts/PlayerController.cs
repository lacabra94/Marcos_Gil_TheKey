using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    private float horizontalMove;
    private float verticalMove;
    public float verticalSpeed;
    public float gravity = -9.81f;
    private CharacterController characterController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        verticalSpeed += gravity * Time.deltaTime;
        Vector3 direccion = new Vector3 (horizontalMove, verticalSpeed, verticalMove);
        characterController.Move(direccion * velocidad * Time.deltaTime);

        if (characterController.isGrounded == true)
        {
            verticalSpeed = 0f;
            if (Input.GetKeyDown (KeyCode.Space))
            {
                verticalSpeed = 3f;
            }

        }
        
    }
}
