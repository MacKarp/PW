using UnityEngine;

namespace Assets.Scripts
{
    public class Crystal : MonoBehaviour
    {
        public bool Active = true;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.rotation = Quaternion.Euler(45f, Time.timeSinceLevelLoad * 60f, 45f);
        }

        private void OnTriggerEnter(Collider otherCollider)
        {
            if (!Active) return;
            if (otherCollider.name != "Sphere") return;

            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;

            Active = false;

            FindObjectOfType<GameController>().UpdateCrystalCounterText();
        }
    }
}
