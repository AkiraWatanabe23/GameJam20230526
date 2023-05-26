using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    [SerializeField] private GameObject[] _items = new GameObject[4];

    private float _dir = 1f;

    private void Update()
    {
        transform.position += new Vector3(Time.deltaTime * _moveSpeed * _dir, 0f);

        if (transform.position.x > 7f)
        {
            _dir = -1f;
        }
        else if (transform.position.x < -7f)
        {
            _dir = 1f;
        }
    }

    public void ItemSpawn()
    {
        int randomIndex = Random.Range(0, _items.Length);

        Instantiate(_items[randomIndex], transform.position, Quaternion.identity);
    }
}
