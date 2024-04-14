using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
        private Rigidbody2D rb;

        [SerializeField] float speed = 15f;
        [SerializeField] int damage = 20;

        [SerializeField] int life = 0;

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
                Destroy(this.gameObject); //���� ������ �������� ������������ ���������� � �� � ��� �� ����������, ��� ����� �������, ����� �� �� ���������� �������
            }
        }
    }
