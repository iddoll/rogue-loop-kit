using UnityEngine;
using UnityEngine.InputSystem;

namespace RogueLoopKit.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInputHandler : MonoBehaviour
    {
        [Header("Input")]
        [Tooltip("Player/Move from InputSystem_Actions (or your action asset).")]
        [SerializeField]
        InputActionReference moveAction;

        [SerializeField]
        PlayerMovement movement;

        Vector2 _virtualInput;
        bool _useVirtualInput;

        void Reset()
        {
            movement = GetComponent<PlayerMovement>();
        }

        void Awake()
        {
            if (movement == null)
                movement = GetComponent<PlayerMovement>();
        }

        void OnEnable()
        {
            moveAction?.action.Enable();
        }

        void OnDisable()
        {
            moveAction?.action.Disable();
        }

        void Update()
        {
            Vector2 input = _useVirtualInput ? _virtualInput : ReadMoveAction();
            movement.SetMoveDirection(input);
        }

        Vector2 ReadMoveAction()
        {
            if (moveAction == null || moveAction.action == null)
                return Vector2.zero;

            return moveAction.action.ReadValue<Vector2>();
        }

        /// <summary>On-screen joystick or other mobile UI. Overrides action map while active.</summary>
        public void SetVirtualMoveInput(Vector2 input)
        {
            _virtualInput = Vector2.ClampMagnitude(input, 1f);
            _useVirtualInput = true;
        }

        public void ClearVirtualMoveInput()
        {
            _useVirtualInput = false;
            _virtualInput = Vector2.zero;
        }
    }
}
