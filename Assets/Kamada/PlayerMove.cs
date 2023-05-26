using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private Rigidbody2D _rb2d = default;
   

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();

        _rb2d.gravityScale = 0f;
    }


    private void Update()
    {
        var hol = Input.GetAxisRaw("Horizontal");

        _rb2d.velocity = new Vector2(hol * _moveSpeed, _rb2d.velocity.y);
    }
}
