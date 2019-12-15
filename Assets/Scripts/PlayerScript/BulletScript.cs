using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    private int Damage;
    [SerializeField]
    private float Lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Lifetime);

        if (Lifetime <= 0)
            Debug.Log("Balle Inutile");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
        }
    }
}
