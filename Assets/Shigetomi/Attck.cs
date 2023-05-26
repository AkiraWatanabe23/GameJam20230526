using UnityEngine;

public class Attck : MonoBehaviour
{
    [SerializeField] GameObject Bullet;

    [SerializeField] Transform[] _muzzles = new Transform[2];

    private bool _isPowerUp = false;

    public bool IsPowerUp { get => _isPowerUp; set => _isPowerUp = value; }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (_isPowerUp)
            {
                Instantiate(Bullet, _muzzles[0].position, Quaternion.identity);
            }
            else
            {
                Instantiate(Bullet, _muzzles[0].position, Quaternion.identity);
                Instantiate(Bullet, _muzzles[1].position, Quaternion.identity);
            }

        }
    }
}
