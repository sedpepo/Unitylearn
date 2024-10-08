using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public GameObject BulletPrefab;

    Vector2 movementValues = Vector2.zero;
    Vector2 lookingValues = Vector2.zero;
    //public float forceAmount = 1f;
    public float frameDistance = 5f;
    //public float _mass = 20;
    //public Rigidbody rbBody;
    public float lookspeed = 2f;
    public static PlayerMovement instance;
    public int xp;
    
    public void IAAccelerate(InputAction.CallbackContext context)
    {
        movementValues = context.ReadValue<Vector2>();
        
    }
    public void IALookArround(InputAction.CallbackContext context)
    {
        lookingValues = context.ReadValue<Vector2>();
        Debug.Log(lookingValues);

        transform.Rotate(transform.up, lookingValues.x * Time.deltaTime * lookspeed);
    }
    public void IAShoot(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            Shoot();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(movementValues.x * frameDistance * Time.deltaTime, 0, movementValues.y * frameDistance * Time.deltaTime);
      //rbBody.AddForce(movementValues.x * frameDistance * Time.deltaTime, 0, movementValues.y * frameDistance * Time.deltaTime);
       // rbBody.mass= _mass;
    }
    public void Shoot()
    {
        GameObject spawnedBullet;
        Vector3 direction = (transform.forward * 100f) - transform.position;
        spawnedBullet = Instantiate(BulletPrefab, transform.position + transform.forward, Quaternion.identity);
        spawnedBullet.GetComponent<BaseBullet>().SetBulletDirection(direction);
    }
   
}
    