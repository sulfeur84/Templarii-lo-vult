using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Geoffrey.scripts
{
    public class Controller : MonoBehaviour
    {
        [FormerlySerializedAs("_speedMove")] [SerializeField]
        private float speedMove;
        [FormerlySerializedAs("_speedRotate")] [SerializeField]
        private float speedRotate;
        private Vector3 _move;
        private Vector2 _iMove;
        private Vector3 _rotate;
        private Vector2 _iRotate;
    
        void Update()
        {
            var gamepad = Gamepad.current;
            if (gamepad == null)
            {
                Debug.Log("No controller detected.");
                return;
            }
            else
            {
                MovePlayer();
                Rotate();
            }
        }

        public void MovePlayer()
        {
            _move = new Vector3(_iMove.x, 0, _iMove.y) * speedMove * Time.fixedDeltaTime;
            transform.Translate(_move);
        }
        public void OnMove(InputValue value)
        {
            _iMove = value.Get<Vector2>();
        }
        public void OnAttack()
        {
            Debug.Log("Attack !");
        }
        public void OnAttackSpe()
        {
            Debug.Log("Attack Spe activate !");
        }
        public void OnHelpFriend()
        {
            Debug.Log("You're rescue your friend.");
        }
        public void OnInteract()
        {
            Debug.Log("Interact");
        }
        public void OnStart()
        {
            Debug.Log("Menu open !");
        }

        public void Rotate()
        {
            _rotate = new Vector3(_iRotate.x, 0, _iRotate.y) * speedRotate * Time.fixedDeltaTime;
            transform.Rotate(_rotate);
        }
        public void OnLookAt(InputValue value)
        {
            _iRotate = value.Get<Vector2>();
        }
    }
}
