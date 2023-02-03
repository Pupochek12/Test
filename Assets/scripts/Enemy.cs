using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //��� ����������� ������ �����, ���� �������� �� ����� �� �������� ���� �� ���������
    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private EnemyData data;

    private GameObject player; //������� ������ ����, ����� ��������� ���������� � �������� �� �������
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    void Update()
    {
        Solders();
    }

    private void Solders()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    //private void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.CompareTag('soldat1'))
    //    {
    //        if(collider.GetComponent<Health>() !- null)
    //        {
    //            collider.GetComponent<heal>
    //        }
    //    }
    //}
}
