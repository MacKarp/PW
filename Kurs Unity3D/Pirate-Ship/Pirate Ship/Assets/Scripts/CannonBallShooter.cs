using UnityEngine;

namespace Assets.Scripts
{
    public class CannonBallShooter : MonoBehaviour
    {
        public GameObject cannonBallPrefab;

        public Vector3 LeftSpawnPosition;
        public Vector3 LeftShootDirection;
        public Vector3 RightSpawnPosition;
        public Vector3 RightShootDirection;

        public float shootPeriod = 1f;
        private float m_LastShootTime = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Space)) return;

            if (Time.timeSinceLevelLoad - m_LastShootTime < shootPeriod) return;
            m_LastShootTime = Time.timeSinceLevelLoad;

            var camera = FindObjectOfType<Camera>();
            var direction = camera.getCameraLookDirection();

            if (direction == CameraLookDirection.FORWARD || direction == CameraLookDirection.BACKWARD) return;

            var lookLeft = direction == CameraLookDirection.LEFT;
            var spawnPosition = lookLeft ? LeftSpawnPosition : RightSpawnPosition;
            var shootDirection = lookLeft ? LeftShootDirection : RightShootDirection;

            var ball = Instantiate(cannonBallPrefab);
            ball.transform.position = transform.position + transform.rotation * spawnPosition;

            var rigidbody = ball.GetComponent<Rigidbody>();
            rigidbody.velocity = transform.rotation * shootDirection;

        }
    }
}
