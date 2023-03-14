
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        GetInput();  
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * moveSpeed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

}
