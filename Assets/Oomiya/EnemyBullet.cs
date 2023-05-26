using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;
    [SerializeField] GameObject _player;
    [SerializeField] float _lifeTime; 

    void Start()
    {
    }
    void Update()
    {
        _lifeTime -= Time.deltaTime;
        if(_lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }

        transform.position = new Vector2(transform.position.x,
                                         transform.position.y - (_bulletSpeed * Time.deltaTime));
        
    }
}
