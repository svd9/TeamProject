using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    //[SerializeField] Rigidbody2D rb;

    //[SerializeField] float speed = 15f;
    //[SerializeField] int damage = 20;

    //private int life = 0;

    //[SerializeField] int lifeMax = 500;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    rb.velocity = transform.right * speed; //Изменение скорости
    //}

    //void Update()
    //{
    //    life++;

    //    if (life >= lifeMax)
    //    {
    //        Explode(); //Если снаряд пролетел определенное расстояние и ни с чем не столкнулся, его нужно удалить, чтобы он не расходовал ресурсы
    //    }
    //}

    //void OnTriggerEnter2D(Collider2D hitInfo) //Метод, который срабатывает при попадании
    //{
    //    Explode();
    //}

    //void Explode()
    //{
    //    Destroy(gameObject); //Уничтожение объекта
    //}
    private Rigidbody2D rb;

    [SerializeField] float speed = 15f;
    [SerializeField] int damage = 20;

    private int life = 0;

    [SerializeField] int lifeMax = 500;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; //Изменение скорости
    }

    void Update()
    {
        life++;

        if (life >= lifeMax)
        {
            Explode(); //Если снаряд пролетел определенное расстояние и ни с чем не столкнулся, его нужно удалить, чтобы он не расходовал ресурсы
        }
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
}
