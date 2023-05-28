using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneManager : MonoBehaviour
{
    [SerializeField] private Text _resultScoreText = default;
    [Tooltip("何秒かけてカウントするか")]
    [SerializeField] private float _countTime = 1f;

    private static int _resultScore = 0;

    public static int ResultScore { get => _resultScore; set => _resultScore = value; }

    private void Start()
    {
        PlayCounter();
    }

    private void PlayCounter()
    {
        Debug.Log("start");
        StartCoroutine(Count());
    }

    /// <summary> コルーチンによるカウンター機構 </summary>
    private IEnumerator Count()
    {
        float start = Time.time;
        float end = start + _countTime;

        do
        {
            float rate = (Time.time - start) / _countTime;

            int value = (int)(_resultScore * rate + start);
            _resultScoreText.text = value.ToString();

            yield return null;
        }
        while (Time.time < end);

        _resultScoreText.text = _resultScore.ToString("F0");
    }
}
