using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyControllerArcherWeapon : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float ReloadSpeed;
    private float ReloadTime;
    // Start is called before the first frame update
    void Start()
    {
        ReloadTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ReloadTime+= Time.deltaTime;
    }
    public void shoot()
    {
        transform.Rotate(0, 0, 5);
        //transform.position = .MoveTowards(transform.rotation, player.transform.rotation, 1);
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
