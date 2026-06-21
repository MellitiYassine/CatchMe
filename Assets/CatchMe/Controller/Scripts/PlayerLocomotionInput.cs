using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLocomotionInput : MonoBehaviour
{
    CharacterActions controls;

    private void Awake()
    {
        controls = new CharacterActions();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        Vector2 movement =
            controls.PLayerLocomotionMap.Movement.ReadValue<Vector2>();

        transform.Translate(
            new Vector3(movement.x, 0, movement.y)
            * 5f * Time.deltaTime
        );
    }
}
