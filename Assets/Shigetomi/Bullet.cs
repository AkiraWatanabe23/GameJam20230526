using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�e�̑��x
    [SerializeField] float m_initialSpeed = 3f;
    [SerializeField] private float _limit = 3f;

    private PlayerAttack _player = default;
    private float _timer = 0f;
    private int _count = 0;

    private void Start()
    {
        _player = FindObjectOfType<PlayerAttack>();
    }

    private void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * m_initialSpeed);

        _timer += Time.deltaTime;
        if (_timer > _limit)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(enemy.gameObject);

            if (_player.Type == BulletType.Normal ||
                _player.Type == BulletType.Penetration && _count < 2)
            {
                Destroy(gameObject);
            }
            else
            {
                _count++;
            }
        }
    }
}
