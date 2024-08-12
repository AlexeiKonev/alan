using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShield : MonoBehaviour
{
    public float shieldHealth = 700;

    public GameObject LigthEffect;
    // Update is called once per frame
    public  void DamageShield(float damage)
    {
        LigthEffect.SetActive(true);
        if (shieldHealth > 0 )
        {
            shieldHealth -= damage;
          
        }
        else
        {
            Destroy(gameObject);
        }
       
    }

}
