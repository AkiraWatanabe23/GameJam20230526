using UnityEngine;

public class RandomSweep : MonoBehaviour
{
    [Tooltip("徘徊地点生成円の半径")]
    [Range(10f, 40f)]
    [SerializeField] private float _radius = 30f;
    [Tooltip("いくつのposを作るか")]
    [SerializeField] private int _posCount = 1;
    [Tooltip("徘徊する地点のプレハブ")]
    [SerializeField] private GameObject _wanderPrefab = default;

    private void Awake()
    {
        SettingWanderPos(transform);
    }

    private void SettingWanderPos(Transform centerPos)
    {
        var posCollider = GetComponent<CircleCollider2D>();

        posCollider.radius = _radius * 2;
        posCollider.isTrigger = true;

        var circlePos = _radius * Random.insideUnitCircle;
        var spawnPos = new Vector3(circlePos.x, circlePos.y, 0) + centerPos.position;

        Instantiate(_wanderPrefab, spawnPos, Quaternion.identity);
    }
}
