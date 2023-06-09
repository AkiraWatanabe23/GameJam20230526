﻿using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score = 0;
    [SerializeField] private PlayerMove _player = default;

    [SerializeField] private UnityEvent _onGameOver = default;

    [Header("Debug")]
    [SerializeField] private bool _isDebug = false;

    private float _timer = 60f;
    private bool _isGameOver = false;
    private bool _isGameStart = false;

    private static GameManager _instance = default;

    public float Timer => _timer;
    public int Score => _score;

    public bool IsGameStart { get => _isGameStart; set => _isGameStart = value; }

    public static GameManager Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        if (_isGameStart && !_isGameOver)
        {
            _timer -= Time.deltaTime;

            if (_timer < 0)
            {
                GameOver();
            }
        }
    }

    public void GameStart()
    {
        _isGameStart = true;
    }

    public void AddScore(int value)
    {
        _score += value;
    }

    public void GameOver()
    {
        _isGameOver = true;
        ResultSceneManager.ResultScore = _score + (_player.LifeCount * 50);
        _onGameOver?.Invoke();
    }
}
