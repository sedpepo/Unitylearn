using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    
    Vector2 movementValues = Vector2.zero;
    public float forceAmount = 1f;
    public float frameDistance = 5f;
    public float _mass = 20;
    public Rigidbody rbBody;
    public void IAAccelerate(InputAction.CallbackContext context)
    {
        movementValues = context.ReadValue<Vector2>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
      //transform.Translate(movementValues.x * frameDistance * Time.deltaTime, 0, movementValues.y * frameDistance * Time.deltaTime);
      rbBody.AddForce(movementValues.x * frameDistance * Time.deltaTime, 0, movementValues.y * frameDistance * Time.deltaTime);
        rbBody.mass= _mass;
    }
   
}
    