using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject WarriorPrefab;
    //public GameObject SamuraiPrefab;
    

    private float t = 0;

    void Update()
    {

        t += Time.deltaTime;
        if (t > 5f)
        {
            GameObject g = Instantiate(WarriorPrefab);
            //GameObject s = Instantiate(SamuraiPrefab);

            g.GetComponent<NavMeshAgent>().Warp(new Vector3(Random.Range(0, 100), 1, Random.Range(0, 100)));
                //new Vector3(Random.Range(0, 100), 1, Random.Range(0, 100));
            /*s.transform.position =
                new Vector3(Random.Range(-150, 150), 300, Random.Range(-150, 150));*/
            t = 0;
        }

    }

}
