using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public float health = 100;
    public float damage = 10;

    public void AcceptDamage(float incomingDamage)
    {
        health = incomingDamage;

        if (health > 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
