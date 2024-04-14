using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyControllerArcher : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform enemy;
    [SerializeField] Rigidbody2D enemyRig;
    [SerializeField] float speed;
    [SerializeField] EnemyControllerArcherWeapon archerWeaponscript;
    [SerializeField] float distanseAttach;
    [SerializeField] float distanseRemove;
    //float a;
    //a = math.rsqrt(9);
    // Start is called before the first frame update
    float dist(Transform a, Transform b)
    {
        print(a.position.y+' '+a.position.x);
        print(b.position.y+ ' '+b.position.x);//math.rsqrt(math.abs(a.position.y - b.position.y) * math.abs(a.position.y - b.position.y) + math.abs(a.position.y - b.position.y) * math.abs(a.position.y - b.position.y))
        float dx, dy, outp;
        dx = a.position.x - b.position.x;
        dy = a.position.y - b.position.y;
        outp = (float)Mathf.Sqrt(dx*dx + dy*dy);
        print(outp);
        return (outp);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (distanseAttach >= dist(player, enemy)){ archerWeaponscript.shoot(); }
    }

}
