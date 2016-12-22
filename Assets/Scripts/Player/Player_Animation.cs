using UnityEngine;
using System.Collections;

public class Player_Animation : MonoBehaviour {

    Animator _animator;

    Player_Movement _player_Movement;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _player_Movement = GetComponent<Player_Movement>();
    }

    void Update()
    {
        _animator.SetBool("isMoving", _player_Movement.PlayerIsMoving);
        _animator.SetFloat("Horizontal", _player_Movement.MoveInput.x);
    }
}
