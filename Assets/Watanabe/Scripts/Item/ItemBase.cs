using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    private float _deadTime = 4f;
    private float _timer = 0f;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _deadTime)
        {
            Destroy(gameObject);
        }
    }
}
