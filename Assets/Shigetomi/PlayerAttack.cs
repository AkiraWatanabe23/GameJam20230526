using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform[] _muzzles = new Transform[2];
    [SerializeField] private BulletType _type = BulletType.Normal;
    [SerializeField] private ItemSpawner _spawner = default;

    private bool _isSweepAway = false;
    private bool _isPowerUp = false;
    private float _powerUpTimer = 0f;

    public BulletType Type { get => _type; set => _type = value; }
    public ItemSpawner Spawner => _spawner;
    public bool IsSweepAway { get => _isSweepAway; set => _isSweepAway = value; }
    public bool IsPowerUp { get => _isPowerUp; set => _isPowerUp = value; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_isPowerUp)
            {
                var bullet = Instantiate(_bullet, _muzzles[0].position, new Quaternion(0, 0, 90, 0));

                bullet.transform.rotation = new Quaternion(0, 0, 90f, 0);
            }
            else
            {
                Instantiate(_bullet, _muzzles[0].position, new Quaternion(0, 0, 90, 0));
                Instantiate(_bullet, _muzzles[1].position, new Quaternion(0, 0, 90, 0));
            }
        }
        else if (Input.GetMouseButtonDown(1) && _isSweepAway)
        {
            var pos = Input.mousePosition;

            Debug.Log("aaa");
            SpecialAttack(pos);

            _isSweepAway = false;
        }

        if (_type == BulletType.Penetration)
        {
            _powerUpTimer += Time.deltaTime;

            if (_powerUpTimer > 5f)
            {
                _type = BulletType.Normal;
                _powerUpTimer = 0f;
            }
        }
    }

    private void SpecialAttack(Vector3 pos)
    {
        for (float i = 0; i < 2f; i += 0.01f)
        {
            var hit = Physics2D.Linecast(pos, new Vector2(Mathf.Cos(i * Mathf.PI), Mathf.Sin(i * Mathf.PI)));

            if (hit)
            {
                if (hit.collider.gameObject.TryGetComponent(out EnemyBullet enemyBullet))
                {
                    Destroy(enemyBullet.gameObject);
                }
            }
        }
    }
}

public enum BulletType
{
    Normal,
    Penetration,
}
