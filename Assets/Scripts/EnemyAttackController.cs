﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyAttackController : MonoBehaviour
{
    [SerializeField] private float reloadTime;
    private float _reloadTime;
    [SerializeField] GameObject Bullet;
    public Vector3 shootVector = new Vector3(0, -1, 0);
    private void Shoot()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
        ChangeShootDirection();
    }
    private void ChangeShootDirection()//change vector of shoot point
    {
        if (shootVector == new Vector3(0, -1, 0))
        {
            shootVector = new Vector3(-1, -1, 0);
        }
        else 
        {
            shootVector = new Vector3(0, -1, 0);
        }
    }
    void Update()
    {
        if (_reloadTime <= 0)//Cheak relaod time
        {
            _reloadTime = reloadTime;
            Shoot();
        }
        else
        {
            _reloadTime -= Time.deltaTime;
        }
    }
}
