using UnityEngine;

namespace Assets.Scripts
{
    public class ShootingController : MonoBehaviour
    {

        public AudioClip[] wystrzalyAudio;
        public float PrzerwaMiedzyStrzalami = 0.13f;
        public Texture2D Celownik;
        public GameObject Pocisk;
        public GameObject PozycjaLufy;


        //private readonly float _zasieg = 15.0f;
        private Vector3 _przod;

        private float _czyMoznaStrzelac = 0f;
        private Rect _pozycjaCelownika;

        // Start is called before the first frame update
        void Start()
        {
            //ukrywa kursor
            Cursor.visible = false;

            //ustala pozycje celownika
            _pozycjaCelownika = new Rect((Screen.width - Celownik.width) / 2, (Screen.height - Celownik.height) / 2, Celownik.width, Celownik.height);
        }

        // Update is called once per frame
        void Update()
        {
            _przod = transform.TransformDirection(Vector3.back);

            if ((Input.GetButtonDown("Fire1") || Input.GetButton("Fire1")) && _czyMoznaStrzelac <= 0)
            {
                _czyMoznaStrzelac = PrzerwaMiedzyStrzalami;
                StrzalAudio();
                Strzal();


            }

            _czyMoznaStrzelac -= Time.deltaTime;
        }

        void OnGUI()
        {
            GUI.DrawTexture(_pozycjaCelownika, Celownik);
        }


        private void StrzalAudio()
        {
            var audioSource = GetComponent<AudioSource>();
            int n = Random.Range(1, wystrzalyAudio.Length);
            audioSource.clip = wystrzalyAudio[n];
            audioSource.Play();
            wystrzalyAudio[n] = wystrzalyAudio[0];
            wystrzalyAudio[0] = audioSource.clip;
        }

        void Strzal()
        {
            Vector3 obrotPocisku = new Vector3(0, 1, 1);
            GameObject pocisk = Instantiate(Pocisk, PozycjaLufy.transform.position, Quaternion.AngleAxis(90, obrotPocisku));
            pocisk.GetComponent<Rigidbody>().velocity = _przod * 100;
        }
    }
}
