using UnityEngine;

namespace Assets.Scripts
{
    public class Ship : MonoBehaviour
    {
        public float minSpeed = 2f;
        public float maxSpeed = 10f;
        private float m_CurrentSpeed;

        public float maxAngle = 30f;
        private float m_CurrentAngle = 0;

        public Transform ShipModel;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            var targetSpeed = Input.GetKey(KeyCode.W) ? maxSpeed : minSpeed;
            m_CurrentSpeed = Mathf.Lerp(m_CurrentSpeed, targetSpeed, Time.deltaTime);

            var targetAngle = 0f;
            if (Input.GetKey(KeyCode.A))
            {
                targetAngle = -maxAngle;
            }

            if (Input.GetKey(KeyCode.D))
            {
                targetAngle = maxAngle;
            }

            m_CurrentAngle = Mathf.Lerp(m_CurrentAngle, targetAngle, Time.deltaTime / 2f);

            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.rotation *= Quaternion.Euler(Vector3.up * m_CurrentAngle * Time.deltaTime);
            rigidbody.velocity = rigidbody.rotation * Vector3.forward * m_CurrentSpeed;

            var rotationX = Mathf.Sin(Time.timeSinceLevelLoad * 1.5f) * 2f;
            var rotationZ = -m_CurrentAngle / 2f;

            ShipModel.localRotation = Quaternion.Euler(rotationX, 0, rotationZ);
        }
    }
}
