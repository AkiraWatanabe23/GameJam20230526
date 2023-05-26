using UnityEngine;

public class RandomSweep : MonoBehaviour
{
    [Tooltip("�p�j����n�_�̃v���n�u")]
    [SerializeField] private GameObject _wanderPrefab = default;

    public void SettingPos()
    {
        var circlePos = Random.insideUnitCircle * 4;
        var spawnPos = new Vector3(circlePos.x, circlePos.y, 0);

        Instantiate(_wanderPrefab, spawnPos, Quaternion.identity);
    }
}
