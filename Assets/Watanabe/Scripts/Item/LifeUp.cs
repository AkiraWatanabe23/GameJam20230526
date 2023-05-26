using Constants;
using UnityEngine;

public class LifeUp : ItemBase
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
