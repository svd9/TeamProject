using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FirstEnemyTrap : MonoBehaviour
{
    [SerializeField] Rigidbody2D iRig;
    [SerializeField] Transform iTra;
    private GameObject player;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject weapon;
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePoint1;
    [SerializeField] float attachTime;
    [SerializeField] float attachDistanse;
    private float reloadSpeed=0.05f;
    private bool isAttach = false;

    private float reloadTime;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        Instantiate(bullet, firePoint1.position, firePoint1.rotation);
        
    }
    float dist(Transform a, Transform b)
    {
        float dx, dy;
        dx = a.position.x - b.position.x;
        dy = a.position.y - b.position.y;
        return (math.sqrt(dx * dx + dy * dy));
    }


    // Update is called once per frame
    void Update()
    {
        if (attachDistanse >= dist(player.transform, iTra)) { isAttach = true; Destroy(gameObject, attachTime); }
        if (isAttach) { if (reloadSpeed <= reloadTime) { reloadTime = 0; shoot(); } }
        reloadTime += Time.deltaTime;
        //print(reloadTime);
        weapon.transform.Rotate(0, 0, 1.25f);
    }
    //void Update()
    //{  // Rotate the camera every frame so it keeps looking at the target  transform.LookAt(target);

    //    // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side

    //}
}
