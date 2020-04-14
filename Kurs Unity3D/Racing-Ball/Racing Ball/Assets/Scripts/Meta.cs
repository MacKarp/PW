using UnityEngine;

namespace Assets.Scripts
{
    public class Meta : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider otherCollider)
        {
            if (otherCollider.name != "Sphere") return;

            FindObjectOfType<GameController>().CheckIfEndOfGame();
        }
    }
}
