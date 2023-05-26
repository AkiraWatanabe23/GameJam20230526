using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _timer = 100f;
    [SerializeField] private int _score = 0;

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

    private void Start()
    {

    }

    private void Update()
    {
        if (_isGameStart)
        {
            _timer -= Time.deltaTime;

            if (_timer < 0)
            {
                _isGameOver = true;
            }
        }
    }

    public void GameStart()
    {
        _isGameStart = true;
    }
}
