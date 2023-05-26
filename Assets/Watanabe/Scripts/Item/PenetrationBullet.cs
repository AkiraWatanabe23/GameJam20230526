using Constants;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrationBullet : ItemBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerMove player))
        {
            if (player.LifeCount < Consts.MaxLife)
            {
                player.LifeCount++;
                Destroy(gameObject);
            }
        }
    }
}
