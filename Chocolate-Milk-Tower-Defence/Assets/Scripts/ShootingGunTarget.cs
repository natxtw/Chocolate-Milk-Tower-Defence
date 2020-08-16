using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGunTarget : MonoBehaviour
{
    [SerializeField] private float Health = 50.0f;

    public Rigidbody Loot;
    public Transform LootSpawnLocation;


     public void DamageTaken(float AmountOfDamageTaken)
    {
        Health -= AmountOfDamageTaken;
        if (Health <= 0)
        {
            HasDied();
            //Instantiate(Loot,LootSpawnLocation.position, LootSpawnLocation.rotation);
        }   
    }   

    public void HasDied()
    {
        Destroy(gameObject);      
    }


}

//add damage to guns[SerializeField] private float Damage = 10.0f;
//Debug.Log(HitInfo.transform.name); // Displays the object it hits in the console.
