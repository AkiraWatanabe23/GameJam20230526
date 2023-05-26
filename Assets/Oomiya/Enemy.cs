using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float _respownTimer;
    BoxCollider2D _collider;
    SpriteRenderer _spriteRenderer;
    bool _timerStart;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            _collider.enabled = false;
            _spriteRenderer.enabled = false;
            _timerStart = true;
        }
    }

    void Update()
    {
        if( _timerStart )
        {
            _respownTimer -= Time.deltaTime;
            if( _respownTimer < 0 )
            {
                _collider.enabled = true;
                _spriteRenderer.enabled = true;
                _timerStart = false;
            }
        }
    }
}
