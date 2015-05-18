﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("MyGame/EnemySpawn")]
public class enemySpawn : MonoBehaviour {

    public Transform m_enemy;

    protected float m_timer = 5;
    protected Transform m_transform;
	// Use this for initialization
	void Start () {
        m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        m_timer -= Time.deltaTime;
        if (m_timer <= 0)
        {
            m_timer = Random.value * 15.0f;
            if (m_timer < 5)
            {
                m_timer = 5;
            }
            Instantiate(m_enemy, m_transform.position, Quaternion.identity);
        }
	}
}