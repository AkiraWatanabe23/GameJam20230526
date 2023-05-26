using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text _counterText = default;
    [SerializeField] private int _endValue = 0;
    [Tooltip("���b�����ăJ�E���g���邩")]
    [SerializeField] private float _countTime = 1f;

    public void PlayCounter()
    {
        Debug.Log("start");
        StartCoroutine(Count());
    }

    /// <summary> �R���[�`���ɂ��J�E���^�[�@�\ </summary>
    private IEnumerator Count()
    {
        float start = Time.time;
        float end = start + _countTime;

        do
        {
            float rate = (Time.time - start) / _countTime;

            int value = (int)(_endValue * rate + start);
            _counterText.text = value.ToString();

            yield return null;
        }
        while (Time.time < end);

        _counterText.text = _endValue.ToString("F0");
    }
}
