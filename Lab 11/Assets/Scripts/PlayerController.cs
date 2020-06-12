using UnityEngine;
using UnityEngine.Assertions.Must;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject Pocisk;
        public GameObject PolozeniuPocisku;
        private float inputX;
        public float PredkoscPocisku;
        public float PrzerwaMiedzySkokami;
        private float _czyMoznaSkakac = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Poruszanie się w osi
            inputX = Input.GetAxis("Horizontal");

            //Nacisnięcie spacji spowoduje podskok
            if (Input.GetButtonDown("Jump") && _czyMoznaSkakac <= 0)
            {
                _czyMoznaSkakac = PrzerwaMiedzySkokami;
                GetComponent<Rigidbody>().AddForce(0, 500, 0);
            }

            //Naciśniecie LPM odda strzał
            if (Input.GetButtonDown("Fire1"))
            {
                Strzal();
            }

            _czyMoznaSkakac -= Time.deltaTime;
        }

        void FixedUpdate()
        {
            GetComponent<Rigidbody>().velocity = new Vector3(inputX*3, 0, 0);
        }

        void Strzal()
        {
            GameObject nowy = Instantiate(Pocisk, PolozeniuPocisku.transform.position, Quaternion.identity);
            nowy.GetComponent<Rigidbody>().velocity = new Vector3(inputX * 2, 0, PredkoscPocisku);
        }
    }
}
