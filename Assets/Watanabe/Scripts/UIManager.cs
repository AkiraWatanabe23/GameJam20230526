using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerMove _player = default;
    [SerializeField] private Text _timerText = default;
    [SerializeField] private Text _lifeText = default;
    [SerializeField] private Text _scoreText = default;

    private GameManager _manager = default;

    private void Start()
    {
        _manager = GameManager.Instance;
    }
    
    private void Update()
    {
        if (Mathf.Approximately(Mathf.Floor(_manager.Timer), 30f) ||
            Mathf.Approximately(Mathf.Floor(_manager.Timer), 10f))
        {
            _timerText.gameObject.SetActive(true);
            _timerText.text = _manager.Timer.ToString("F0");
        }
        else
        {
            _timerText.gameObject.SetActive(false);
        }

        _lifeText.text = _player.LifeCount.ToString();
        _scoreText.text = _manager.Score.ToString();
    }
}
