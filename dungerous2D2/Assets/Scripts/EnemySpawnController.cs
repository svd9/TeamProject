using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float reloadSpeed;
    private float reloadTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (reloadSpeed <= reloadTime) { reloadTime = 0; shoot(); }
        reloadTime += Time.deltaTime;
    }
}
