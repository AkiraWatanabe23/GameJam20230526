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
        transform.position = new Vector2(transform.position.x,
                                         transform.position.y - (_bulletSpeed * Time.deltaTime));
        
    }
}
