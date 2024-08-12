using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] HealthInfo healthInfo;

    void Start()
    {


        playerHealth = GetComponent<PlayerHealth>();
        healthInfo = playerHealth.healthInfo;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pick")
        {

            playerHealth.health += 10;
            healthInfo.HealthUpdate(playerHealth.health);
            Destroy(other.gameObject);




        }
    }
}
