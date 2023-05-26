using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEditor.Timeline;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    int _howMany = 100;
    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _enemy;
    private List<GameObject> _enemies;
    public List<GameObject> Enemies { get => _enemies; set { _enemies = value; }}

    public static EnemyManager _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject tmp = Instantiate(_enemy, new Vector2(-8 + i * 4, 3), Quaternion.identity);
        }
    }
}
