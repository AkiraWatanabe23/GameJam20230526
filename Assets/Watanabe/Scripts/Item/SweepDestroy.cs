using UnityEngine;

public class SweepDestroy : MonoBehaviour
{
    private void Start()
    {
        int randomCount = Random.Range(1, 5);
        var enemies = FindObjectOfType<EnemyManager>().Enemies;

        for (int i = 0; i < randomCount; i++)
        {
            enemies[i].GetComponent<Enemy>().EnabledFalse();
        }
    }
}
