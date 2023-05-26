using UnityEngine;

public class SweepAwayItem : ItemBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerAttack player))
        {
            player.IsSweepAway = true;
            Destroy(gameObject);
        }
    }
}
