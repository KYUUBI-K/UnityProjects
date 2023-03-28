
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Vector3 moveVector;
    private CharacterController ch_controller;
    void Start()
    {
        ch_controller= GetComponent<CharacterController>();
    }

    void Update()
    { 
        CharacterMove();
    }
   
    private void CharacterMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal")* -moveSpeed;
        moveVector.z = Input.GetAxis("Vertical")* -moveSpeed;

        ch_controller.Move(moveVector * Time.deltaTime);

    }
   



}
