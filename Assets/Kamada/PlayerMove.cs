using UnityEngine;

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
        var hol = Input.GetAxisRaw("Horizontal");

        _rb2d.velocity = new Vector2(hol * _moveSpeed, _rb2d.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
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
