using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
  
   public float bulletSpeed = 50f;
    public Rigidbody bulletRigidbody;
    private Vector3 Direction;
    public float bulletDamage = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        transform.Translate(transform.forward * bulletSpeed * Time.deltaTime);
        

    }
    private void FixedUpdate()
    {
        bulletRigidbody.AddForce(Direction * 50f);

        RaycastHit rayHit;

        if (Physics.Raycast(transform.position, bulletRigidbody.velocity.normalized, out rayHit, bulletRigidbody.velocity.magnitude * 0.02f))
        {
            rayHit.transform.gameObject.GetComponent<HealthAndDamage>().AcceptDamage(bulletDamage);
        }
    }

    public void SetBulletDirection(Vector3 desiredDirection)
    {
        Direction = desiredDirection;
    }
}
