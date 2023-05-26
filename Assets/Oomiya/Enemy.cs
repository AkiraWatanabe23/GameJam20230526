using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject _enemyBullet;

    [SerializeField] float _respownTimer;
    float RespownTimer;

    [SerializeField] float _fireRate;
    float FireRate;

    BoxCollider2D _collider;
    SpriteRenderer _spriteRenderer;
    public bool _timerStart;

    void Start()
    {
        FireRate = _fireRate;
        RespownTimer = _respownTimer;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            EnabledFalse();
        }
    }

    void Update()
    {
        FireRate -= Time.deltaTime;
        EnemyRespown();

        if(FireRate < 0 && !_timerStart)
        {
            Instantiate(_enemyBullet, new Vector2(transform.position.x,
                                                  transform.position.y - transform.localScale.y), Quaternion.identity);
            FireRate = _fireRate;
        }
    }

    /// <summary>
    /// 敵をリスポーンさせる
    /// </summary>
    void EnemyRespown()
    {
        if (_timerStart)
        {
            Debug.Log("タイマースタート");
            RespownTimer -= Time.deltaTime;
            if (RespownTimer < 0)
            {
                EnabledTrue();
                RespownTimer = _respownTimer;
            }
        }
    }

    public void EnabledFalse()
    {
        _timerStart = true;
        _collider.enabled = false;
        _spriteRenderer.enabled = false;
    }

    public void EnabledTrue()
    {
        _timerStart = false;
        _collider.enabled = true;
        _spriteRenderer.enabled = true;
    }
}
