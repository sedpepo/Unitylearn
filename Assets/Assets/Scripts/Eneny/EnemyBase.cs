using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed;
    public float enemyCurrentHealth;
    public float enemyDamage;
    public float enemySize;
    public float rotationSpeed;
    public Transform enemyTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculate the direction from the chr to the target
        Vector3 direction = enemyTarget.position - transform.position;
        // cal the rotation needed to look in the direcion
        Quaternion targetRotaion = Quaternion.LookRotation(direction);
        // apply the rotation to the chr
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotaion, rotationSpeed * Time.deltaTime);

        transform.position = transform.position + (transform.forward * enemySpeed * Time.deltaTime);     

    }
}
