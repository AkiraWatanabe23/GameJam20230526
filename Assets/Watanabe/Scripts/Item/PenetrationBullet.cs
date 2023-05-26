using UnityEngine;

public class PenetrationBullet : ItemBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerAttack player))
        {
            player.Type = BulletType.Penetration;
            Destroy(gameObject);
        }
    }
}
