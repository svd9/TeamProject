using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyArcherController : MonoBehaviour
{
    [SerializeField] Rigidbody2D iRig;
    [SerializeField] Transform iTra;
    [SerializeField] Transform player;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float attachDistanse;
    [SerializeField] float removeDistanse;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
    float dist(Transform a, Transform b)
    {
        float dx, dy;
        dx = a.position.x - b.position.x;
        dy = a.position.y - b.position.y;
        return(math.sqrt(dx * dx + dy * dy));
    }

    // Update is called once per frame
    void Update()
    {
        if (attachDistanse<=dist(player, iTra)) { }
    }
}
