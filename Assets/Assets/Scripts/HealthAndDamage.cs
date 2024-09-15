using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public float health = 100f;
    public float maxHealth = 100f;
    public float damage = 10f;

    public delegate void DamageTaken(float Damagetaken);

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
