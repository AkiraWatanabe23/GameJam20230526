using UnityEngine;
using UnityEngine.UI;

public class ResultSceneManager : MonoBehaviour
{
    [SerializeField] private Text _resultScoreText = default;

    private static int _resultScore = 0;

    public static int ResultScore { get => _resultScore; set => _resultScore = value; }

    private void Start()
    {
        _resultScoreText.text = _resultScore.ToString("F0");
    }

    private void Update()
    {
        
    }
}
