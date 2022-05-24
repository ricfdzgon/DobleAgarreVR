using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleShot : MonoBehaviour
{
    public GameObject balaPrefab;
    float shotForce = 100;
    public Transform shotPoint;
    void Start()
    {

    }

    void Update()
    {

    }

    public void Shot()
    {
        GameObject bala = Instantiate(balaPrefab, shotPoint.position, shotPoint.rotation);
        bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * shotForce, ForceMode.Impulse);

        //Activamos el sistema de partículas
        foreach (ParticleSystem ps in GetComponentsInChildren<ParticleSystem>())
        {
            ps.Play();
        }

    }
}
