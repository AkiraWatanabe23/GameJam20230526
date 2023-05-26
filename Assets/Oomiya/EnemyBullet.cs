using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;
    [SerializeField] GameObject _player;

    void Start()
    {
    }
    void Update()
    {
        //transform.position = new Vector2(transform.position.x,
        //                                 transform.position.y - (_bulletSpeed * Time.deltaTime));
        HomingBullet();
    }

    void HomingBullet()
    {
        Vector2 _difVec = _player.transform.position - transform.position;
        transform.position = _difVec.normalized * (_bulletSpeed * Time.deltaTime);
    }
}
