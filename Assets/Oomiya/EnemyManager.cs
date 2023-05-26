using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _enemy;
    private List<GameObject> _enemies = new List<GameObject>();
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
            Enemies.Add(Instantiate(_enemy, new Vector2(-8 + i * 3, 3), Quaternion.identity));
        }
    }
}
