using UnityEngine;

namespace Assets.Scripts
{
    public enum CameraLookDirection { FORWARD, RIGHT, BACKWARD, LEFT }

    public class Camera : MonoBehaviour
    {
        public Transform objectToTrack;
        private float m_CameraAngle = 0f;

        public Vector3 delta;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            m_CameraAngle += Input.GetAxis("Mouse X");
            var quaterion = Quaternion.Euler(0, m_CameraAngle, 0);

            var position = objectToTrack.position
                           + objectToTrack.rotation * quaterion * delta;
            transform.position = position;

            transform.LookAt(objectToTrack);
            transform.rotation *= Quaternion.Euler(-10f, 0, 0);

            getCameraLookDirection();
        }

        public CameraLookDirection getCameraLookDirection()
        {
            var angle = Mathf.DeltaAngle(0, m_CameraAngle);

            if (-45 < angle && angle < 45)
                return CameraLookDirection.FORWARD;
            if (45 < angle && angle < 135)
                return CameraLookDirection.RIGHT;
            if (-135 < angle && angle < -45)
                return CameraLookDirection.LEFT;
            return CameraLookDirection.BACKWARD;
        }
    }
}
