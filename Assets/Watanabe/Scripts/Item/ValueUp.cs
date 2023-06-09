﻿using UnityEngine;

public class ValueUp : ItemBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerAttack player))
        {
            player.IsPowerUp = true;
            Destroy(gameObject);
        }
    }
}
