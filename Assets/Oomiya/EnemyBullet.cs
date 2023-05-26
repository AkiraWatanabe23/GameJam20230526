using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;
    Enemy _enemyScript;

    void Start()
    {
        _enemyScript = GetComponent<Enemy>();
    }
    void Update()
    {
        transform.position = new Vector2(transform.position.x,
                                         transform.position.y - (_bulletSpeed * Time.deltaTime));
    }
}
