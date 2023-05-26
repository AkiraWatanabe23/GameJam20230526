using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private Rigidbody2D _rb2d = default;
   
    float rotaion_speed = 0;
   

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();

        _rb2d.gravityScale = 0f;
    }


    private void Update()
    {
        var hol = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");

        _rb2d.velocity = new Vector2(hol * _moveSpeed, ver * _moveSpeed);

        if (Input.GetMouseButtonDown(0)) 
        {
            rotaion_speed = 20.0f;
        }
        transform.Rotate(0,0, rotaion_speed);
    }
}
