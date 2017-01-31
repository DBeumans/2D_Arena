using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    Vector2 _moveInput;
    
    public Vector2 MoveInput { get { return _moveInput; } }

    void Update() { KeysCheck(); }

    void KeysCheck()
    {

        _moveInput = new Vector2(Input.GetAxis("Horizontal"),0);
    }
}
