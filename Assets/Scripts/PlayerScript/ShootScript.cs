using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform[] StartPosBullets;
    
    [SerializeField]
    private float ShootPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(PrefabBullet);
            bullet.transform.position = StartPosBullets[0].position;
            bullet.GetComponent<Rigidbody>().AddForce(StartPosBullets[0].forward * ShootPower);
        }
    }

}
