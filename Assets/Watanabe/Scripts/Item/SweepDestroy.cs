using UnityEngine;

public class SweepDestroy : MonoBehaviour
{
    private void Start()
    {
        int randomCount = Random.Range(0, 5);
        var enemies = FindObjectOfType<EnemyManager>();

        for (int i = 0; i < randomCount; i++)
        {

        }
    }
}
