using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyArcherController : MonoBehaviour
{
    [SerializeField] Rigidbody2D iRig;
    [SerializeField] Transform iTra;
    private GameObject player;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject weapon;
    [SerializeField] Transform firePoint;
    [SerializeField] float attachDistanse;
    [SerializeField] float reloadSpeed;
    [SerializeField] float removeDistanse;

    private float reloadTime;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
        if (attachDistanse>=dist(player.transform, iTra)) { if (reloadSpeed <= reloadTime) { reloadTime = 0; shoot(); } }
        if (removeDistanse>=dist(player.transform, iTra)) { }
        reloadTime += Time.deltaTime;
        //print(reloadTime);
        weapon.transform.LookAt(player.transform, Vector3.left);
    }
    //void Update()
    //{  // Rotate the camera every frame so it keeps looking at the target  transform.LookAt(target);

    //    // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        
    //}
}
