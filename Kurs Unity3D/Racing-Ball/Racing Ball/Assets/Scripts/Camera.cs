using UnityEngine;

namespace Assets.Scripts
{
    public class Camera : MonoBehaviour
    {
        public Transform ObjectToTrack;
        public Vector3 Delta;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void FixedUpdate()
        {
            transform.LookAt(ObjectToTrack);

            var trackedRigidbody = ObjectToTrack.GetComponent<Rigidbody>();
            var speed = trackedRigidbody.velocity.magnitude;
            var targetPosition = ObjectToTrack.position + Delta * (speed / 20f + 1f);

            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.smoothDeltaTime * 2f);
        }
    }
}
