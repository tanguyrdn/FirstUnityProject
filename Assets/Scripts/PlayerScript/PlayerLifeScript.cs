using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeScript : LifeScript
{
    [SerializeField]
    public Image HealthBar;

    public override void UpdateLife(int nb)
    {
        base.UpdateLife(nb);
        HealthBar.transform.localScale = new Vector3(CurrentLife / MaxLife, 1, 1);
    }



    public override void Death()
    {
        //TODO DEATH
    }

    public override void End()
    {
        Destroy(gameObject);
    }
}
