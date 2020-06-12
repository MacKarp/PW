using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyController : MonoBehaviour
    {
        public Material[] Materialy;

        // Start is called before the first frame update
        void Start()
        {
            GetComponent<Renderer>().material = Materialy[Random.Range(0, Materialy.Length)];
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }
    }
}