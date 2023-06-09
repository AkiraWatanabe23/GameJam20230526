﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private int _lifeCount = 3;

    private Rigidbody2D _rb2d = default;

    public int LifeCount { get => _lifeCount; set => _lifeCount = value; }

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.gravityScale = 0f;
    }

    private void Update()
    {
        var ver = Input.GetAxisRaw("Vertical");
        var hol = Input.GetAxisRaw("Horizontal");

        _rb2d.velocity = new Vector2(hol * _moveSpeed, ver * _moveSpeed);

        if (transform.position.x > 8f)
        {
            transform.position = new Vector3(7.9f, transform.position.y);
        }

        if (transform.position.x < -8f)
        {
            transform.position = new Vector3(-7.9f, transform.position.y);
        }

        if (transform.position.y > 4.7f) transform.position = new Vector3(transform.position.x, 4.6f);
        if (transform.position.y < -4.7f) transform.position = new Vector3(transform.position.x, -4.6f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyBullet bullet))
        {
            _lifeCount--;

            if (_lifeCount == 0)
            {
                Destroy(gameObject);
                GameManager.Instance.GameOver();
            }
        }
    }
}
