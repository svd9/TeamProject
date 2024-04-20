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
    //    rb.velocity = transform.right * speed; //��������� ��������
    //}

    //void Update()
    //{
    //    life++;

    //    if (life >= lifeMax)
    //    {
    //        Explode(); //���� ������ �������� ������������ ���������� � �� � ��� �� ����������, ��� ����� �������, ����� �� �� ���������� �������
    //    }
    //}

    //void OnTriggerEnter2D(Collider2D hitInfo) //�����, ������� ����������� ��� ���������
    //{
    //    Explode();
    //}

    //void Explode()
    //{
    //    Destroy(gameObject); //����������� �������
    //}
    private Rigidbody2D rb;

    [SerializeField] float speed = 15f;
    [SerializeField] int damage = 20;

    private int life = 0;

    [SerializeField] int lifeMax = 500;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; //��������� ��������
    }

    void Update()
    {
        life++;

        if (life >= lifeMax)
        {
            Explode(); //���� ������ �������� ������������ ���������� � �� � ��� �� ����������, ��� ����� �������, ����� �� �� ���������� �������
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

        Destroy(gameObject); //����������� �������
    }
}
