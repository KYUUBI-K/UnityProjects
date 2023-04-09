
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameManager gm;
    [SerializeField] Transform playerCamera = null;
    float cameraPitch = 0.0f;
    CharacterController contr = null;
    float speed = 100f;

    void Start()
    {
        contr = GetComponent<CharacterController>();
    }

    void Update()
    {
        UpdateMouseLook();
        UpdateMove();
        if (Input.GetKey("r"))
        {
            gm.Reolad();
        }
    }
    void UpdateMouseLook()
    {

        Vector2 mouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        transform.Rotate(Vector3.up * mouse.x);
        cameraPitch -= mouse.y;
        cameraPitch = Mathf.Clamp(cameraPitch, -50.0f, 50.0f);
        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * mouse.x);

    }
    void UpdateMove()
    {
        Vector2 inp = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 
        inp.Normalize();
        Vector3 velocity = ((-transform.forward) * inp.y + (-transform.right) * inp.x)*speed;
        contr.Move(velocity * Time.deltaTime);
    }




}
