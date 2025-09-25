using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class pong : MonoBehaviour
{
    [Range(1.0f, 10.0f)]
    public float Speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private KeyCode _leftDirection;
    [SerializeField] private KeyCode _rightDirection;


    private float _direction;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        _rb.linearVelocityX = _direction * Speed;

    }

    // Update is called once per frame
    void Update()
    {

        _direction = 0.0f;

        if (Input.GetKey(_rightDirection))
        {
            _direction += 1.0f;
        }

        if (Input.GetKey(_leftDirection))
        {
            _direction -= 1.0f;
        }
    }

}
