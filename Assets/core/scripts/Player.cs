using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private PlayerInputActions _playerinputactions;
    [SerializeField] private int _speed = 5;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerinputactions = new PlayerInputActions();
        _playerinputactions.Enable();
    }
    private void Update()
    {
        Vector2 directions = _playerinputactions.Player.move.ReadValue<Vector2>();

        _rigidbody.linearVelocity = new Vector3(directions.x, _rigidbody.linearVelocity.y,directions.y);
    }

    //private void Update()
    //{
    //    Vector3 directions = Vector3.zero;
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        directions += new Vector3(1,0,0) * _speed;
    //    }
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        directions += new Vector3(-1, 0, 0) * _speed;
    //    }
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        directions += new Vector3(0, 0, 1) * _speed;
    //    }
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        directions += new Vector3(0, 0, -1) * _speed;
    //    }
    //    if (Input.GetKey(KeyCode.Space))
    //    {
    //        directions += new Vector3(0, 1, 0) * _speed;
    //    }
    //    _rigidbody.linearVelocity = new Vector3(directions.x, _rigidbody.linearVelocity.y,directions.z);
    //}
}
