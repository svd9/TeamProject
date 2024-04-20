using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRig;
    [SerializeField] float speed;
    [SerializeField] GameObject weapon;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float reloadSpeed;
    private float reloadTime;
    private int horizontal;
    private int vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
    void weaponRotate()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
    }
    // Update is called once per frame
    void Update()
    {
        weaponRotate();
        if (Input.GetKey(KeyCode.W)) { vertical += 1;}
        if (Input.GetKey(KeyCode.S)) { vertical -= 1; }
        if (Input.GetKey(KeyCode.D)) { horizontal += 1; }
        if (Input.GetKey(KeyCode.A)) { horizontal -= 1; }
        playerRig.velocity = new Vector2(horizontal * speed, vertical * speed);
        horizontal = 0;
        vertical = 0;
        if (Input.GetKey(KeyCode.Mouse0)) { if (reloadSpeed <= reloadTime) { reloadTime = 0; shoot(); } }
        reloadTime += Time.deltaTime;
    }
}
