using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private PlayerMove _player = default;
    [SerializeField] private Text _timerText = default;
    [SerializeField] private Text _lifeText = default;
    [SerializeField] private Text _scoreText = default;
    [SerializeField] private Text _countText = default;

    private GameManager _manager = default;

    private void Start()
    {
        _manager = GameManager.Instance;
        StartCoroutine(StartCount());
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

        _lifeText.text = "LIFE : " + _player.LifeCount.ToString();
        _scoreText.text = "SCORE : " + _manager.Score.ToString();
    }

    private IEnumerator StartCount()
    {
        _countText.text = "  3";
        yield return new WaitForSeconds(1);
        _countText.text = "  2";
        yield return new WaitForSeconds(1);
        _countText.text = "  1";
        yield return new WaitForSeconds(1);
        _countText.text = "Start!!";
        _manager.IsGameStart = true;

        yield return new WaitForSeconds(1);
        _countText.text = "";
    }
}
