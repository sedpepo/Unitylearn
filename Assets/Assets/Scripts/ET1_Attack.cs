using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ET1_Attack : MonoBehaviour

{
    EnemyBase baseEnemyScript;
    // Start is called before the first frame update
    private void Awake()
    {
        baseEnemyScript = GetComponent<EnemyBase>();
    }
    
    void Update()
    {
       // if (baseEnemyScript.distanceToPlayer < 0.3f)
      //  {
      //      baseEnemyScript.targetPlayer.GetComponent<HealthAndDamage>().AcceptDamage();
      //  }
    }
}
