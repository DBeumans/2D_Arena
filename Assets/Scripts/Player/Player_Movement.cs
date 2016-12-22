using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour {

    [SerializeField]
    float _movementSpeed;

    Rigidbody2D _rigidBody2D;

    bool _isMoving;

    public bool PlayerIsMoving { get { return _isMoving; } }

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Mathf.Abs(MoveInput.x) < .2f)
        { _rigidBody2D.velocity = _rigidBody2D.velocity * .5f; _isMoving = false; }
        if (Mathf.Abs(MoveInput.x) > .2f)
        { _rigidBody2D.AddForce(MoveInput * _movementSpeed); _isMoving = true; }

        direction();
    }

    void direction()
    {
        if (MoveInput.x <= -.2f)
            transform.eulerAngles = new Vector2(0, 180);
        if(MoveInput.x >= .2f)
            transform.eulerAngles = new Vector2(0, 0);
    }
}
