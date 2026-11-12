using UnityEngine;

public class PlayerCintroller : MonoBehaviour
{
// PlayerController
    
// Component
    PlayerMovement move;

// === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        move.Movement();
    }
}
