using UnityEngine;

namespace Assets.Scripts
{
    public class Camera : MonoBehaviour
    {
        private float _axisX;
        private float _axisY;
        public float Distance = 40f;
        public float Speed = 5f;

        // Start is called before the first frame update
        void Start()
        {
            SetCameraPosition();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(1)) SetCameraPosition();
        }

        private void SetCameraPosition()
        {
            float deltaX = Input.GetAxis("Mouse X");
            float deltaY = Input.GetAxis("Mouse Y");

            _axisX += deltaY * Speed;
            _axisY += deltaX * Speed;
            _axisX = Mathf.Clamp(_axisX, -85f, 0f);

            var rotation = Quaternion.Euler(_axisX, _axisY, 0);
            transform.position = rotation * Vector3.forward * Distance;

            transform.LookAt(Vector3.up * 5f);
        }
    }
}
