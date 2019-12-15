﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject PrefabExplosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 dir = collision.gameObject.transform.position - gameObject.transform.position;

            Destroy(gameObject);
            GameObject explo = Instantiate(PrefabExplosion);
            explo.transform.position = gameObject.transform.position;
            Destroy(explo, 2);
        }
    }

}
