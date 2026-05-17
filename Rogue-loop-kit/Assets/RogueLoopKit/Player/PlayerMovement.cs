using System;
using UnityEngine;

namespace RogueLoopKit.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        const float MovingThresholdSqr = 0.01f;

        [Header("Movement")]
        [SerializeField, Min(0f)]
        float moveSpeed = 5f;

        Rigidbody2D _rigidbody;
        Vector2 _moveDirection;
        Vector2 _facingDirection = Vector2.right;
        bool _isMoving;

        public float MoveSpeed => moveSpeed;
        public Vector2 MoveDirection => _moveDirection;
        public Vector2 FacingDirection => _facingDirection;
        public bool IsMoving => _isMoving;

        public event Action<Vector2> MoveInputChanged;
        public event Action<Vector2> FacingDirectionChanged;
        public event Action<bool> MovingStateChanged;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.gravityScale = 0f;
            _rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        public void SetMoveDirection(Vector2 direction)
        {
            direction = Vector2.ClampMagnitude(direction, 1f);

            if (_moveDirection != direction)
            {
                _moveDirection = direction;
                MoveInputChanged?.Invoke(_moveDirection);
            }

            bool moving = direction.sqrMagnitude > MovingThresholdSqr;
            if (moving)
            {
                Vector2 facing = direction.normalized;
                if (_facingDirection != facing)
                {
                    _facingDirection = facing;
                    FacingDirectionChanged?.Invoke(_facingDirection);
                }
            }

            if (_isMoving == moving)
                return;

            _isMoving = moving;
            MovingStateChanged?.Invoke(_isMoving);
        }

        void FixedUpdate()
        {
            _rigidbody.linearVelocity = _moveDirection * moveSpeed;
        }
    }
}
