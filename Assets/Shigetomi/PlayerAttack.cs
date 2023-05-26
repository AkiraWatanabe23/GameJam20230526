using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //’e‚Ì‘¬“x
    [SerializeField] float m_initialSpeed = 3f;
    [SerializeField] private float _limit = 3f;

    private float _timer = 0f;

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
            Destroy(gameObject);
        }
    }
}
