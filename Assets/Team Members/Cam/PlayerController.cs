using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    MainActions mainActions;

    public CharacterModel characterModel;

    // Start is called before the first frame update
    void Start()
    {
        mainActions = new MainActions();
        mainActions.InGame.Enable();

        mainActions.InGame.Jump.performed += aContext => characterModel.Jump();
        mainActions.InGame.Interact.performed += aContext => characterModel.Interact();
        
        mainActions.InGame.Movement.performed += OnMovementOnperformed;
        mainActions.InGame.Movement.canceled += OnMovementOnperformed;
    }

    private void OnMovementOnperformed(InputAction.CallbackContext aContext)
    {
        if (aContext.phase == InputActionPhase.Performed)
        {
            characterModel.movementDirection = aContext.ReadValue<Vector2>();
        }
        else if(aContext.phase == InputActionPhase.Canceled)
        {
            characterModel.movementDirection = Vector2.zero;
        }
    }
}