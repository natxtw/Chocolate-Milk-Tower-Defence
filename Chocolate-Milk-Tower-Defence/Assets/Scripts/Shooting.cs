using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] public float AmmoDamage = 10.0f;
    [SerializeField] public float AmmoRange = 200.0f;
    [SerializeField] public float AmmoSpeed = 100.0f;

    public GameObject AmmoPrefab;
    public Transform BarrelEnd;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject BulletInstance = Instantiate(AmmoPrefab, BarrelEnd.position, Quaternion.identity);
            Rigidbody BulletRigidbodyInstance = BulletInstance.GetComponent<Rigidbody>();
            BulletRigidbodyInstance.AddForce(BarrelEnd.forward * AmmoSpeed);
            //Debug.Log("i shoudve worked");
        }
    }

}

//GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
//shot.GetComponent<Rigidbody>().AddForce(transform.forward* shootForce);
