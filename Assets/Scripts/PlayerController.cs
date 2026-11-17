using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    private float horizontalMove;
    private float verticalMove;
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
        Vector3 direccion = new Vector3 (horizontalMove, 0, verticalMove);
        characterController.Move(direccion * velocidad * Time.deltaTime);
    }
}
