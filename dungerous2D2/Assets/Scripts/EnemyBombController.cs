using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.Mathematics;

public class EnemyBombController : MonoBehaviour
{
    [SerializeField] Rigidbody2D iRig;
    [SerializeField] Transform iTra;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject weapon;
    [SerializeField] Transform firePoint;
    [SerializeField] float attachDistanse;
    private float reloadTime;
    private GameObject player;
    private Transform target;
    private bool isAttach;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent= GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    void shoot()
    {
        for (int i = 0; i <=40; i++) { Instantiate(bullet, firePoint.position, firePoint.rotation); weapon.transform.Rotate(0, 0, 9); }
        Destroy(gameObject);
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
        target=player.transform;
        agent.SetDestination(target.position);
        if (!isAttach) {  if (attachDistanse >= dist(player.transform, iTra)) { isAttach = true; reloadTime = 0; shoot(); }   }
        reloadTime += Time.deltaTime;
        //print(reloadTime);
        weapon.transform.LookAt(player.transform, Vector3.left);
    }
}
