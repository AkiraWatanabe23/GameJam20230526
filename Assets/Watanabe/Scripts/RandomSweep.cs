using UnityEngine;

public class RandomSweep : MonoBehaviour
{
    [Tooltip("œpœj’n“_¶¬‰~‚Ì”¼Œa")]
    [Range(10f, 40f)]
    [SerializeField] private float _radius = 30f;
    [Tooltip("‚¢‚­‚Â‚Ìpos‚ğì‚é‚©")]
    [SerializeField] private int _posCount = 1;
    [Tooltip("œpœj‚·‚é’n“_‚ÌƒvƒŒƒnƒu")]
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
