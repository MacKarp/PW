using UnityEngine;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
        public Material[] Materialy;
        public GameObject Kwadracik;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                StworzKwadrat();
            }
        }

        void StworzKwadrat()
        {
            Vector3 pozycjaVector3 = Input.mousePosition;
            pozycjaVector3.z = Random.Range(5f, 20f);
            pozycjaVector3 = Camera.main.ScreenToWorldPoint(pozycjaVector3);
            Instantiate(Kwadracik, pozycjaVector3, Quaternion.identity);
            Kwadracik.GetComponent<Renderer>().material = Materialy[Random.Range(0, Materialy.Length)];
        }
    }
}
