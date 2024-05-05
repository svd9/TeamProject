using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.Mathematics;

public class EnemyRocketController : MonoBehaviour
{
    [SerializeField] Rigidbody2D iRig;
    [SerializeField] Transform iTra;
    [SerializeField] float damage;
    private GameObject player;
    private Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //health health1 = hitInfo.GetComponent<health>();
        hitInfo.GetComponent<health>().damage(damage);


        Explode();

    }

    void Explode()
    {

        Destroy(gameObject); //Уничтожение объекта
    }
    // Update is called once per frame
    void Update()
    {
        target = player.transform;
        agent.SetDestination(target.position);

    }
}
