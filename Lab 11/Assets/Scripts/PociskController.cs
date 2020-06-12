using UnityEngine;

namespace Assets.Scripts
{
    public class PociskController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

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
