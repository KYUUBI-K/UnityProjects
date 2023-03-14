
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool stayGround = false;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        stayGround = true;
    }
    void OnTriggerExit(Collider collider)
    {
        stayGround = false;
    }
}
