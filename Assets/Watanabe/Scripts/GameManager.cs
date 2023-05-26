using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _timer = 100f;
    [SerializeField] private int _score = 0;

    [SerializeField] private UnityEvent _onGameOver = default;

    [Header("Debug")]
    [SerializeField] private bool _isDebug = false;

    private bool _isGameOver = false;
    private bool _isGameStart = false;

    private static GameManager _instance = default;

    public float Timer => _timer;

    public static GameManager Instance => _instance;

    private void Awake()
    {
        _instance = this;
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
        ResultSceneManager.ResultScore = _score;
        _onGameOver?.Invoke();
    }
}
