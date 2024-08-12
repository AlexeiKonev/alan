using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLigthRay : MonoBehaviour
{
    public float LigthDamage = 9f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton  (1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    //Instantiate(LigthEffect,hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                    if (hit.collider.gameObject.TryGetComponent<EnemyShield>(out EnemyShield eS)){
                        eS.DamageShield (LigthDamage);
                    }
                    
                    //hit.collider.gameObject.SetActive(false);
                    //hit.collider.enabled = false;
                }
            }
        }
    }
}

 