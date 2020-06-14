using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    public class ZombieController : MonoBehaviour
    {
        public float PredkoscPoruszania = 5.0f;
        public float DystansAtaku = 2.0f;
        public int SilaAtaku = 10;
        public float PrzerwaMiedzyAtakiem = 1.0f;
        public int BazoweHP = 10;
        //public int PunktyZaZabicie = 100;
        public GameObject Zombiak;
        public AudioClip[] ObrazeniaAudioClips;
        public Animator animator;

        private float _timer = 0;
        private float _idleObrotTimer = 0;

        private GameObject _gameController;
        private GameObject _playerGameObject;
        private int _hp;
        private bool _idle = true;
        private string _akutalnaAnimacja;

        private AnimatorStateInfo _animatorStanInfo;


        // Start is called before the first frame update
        void Start()
        {
            _gameController = GameObject.FindGameObjectWithTag("GameController");
            _playerGameObject = GameObject.FindGameObjectWithTag("Player");
            _hp = BazoweHP + Random.Range(0, BazoweHP);
        }

        // Update is called once per frame
        void Update()
        {
            if (_idle && _idleObrotTimer <= 0)
            {
                //losowy obrót zombiaka
                var euler = transform.eulerAngles;
                euler.y = Random.Range(0f, 360.0f);
                transform.eulerAngles = euler; ;
                Quaternion docelowyObrot = Quaternion.LookRotation(transform.eulerAngles - transform.position);

                float poczatkowyrRotationX = transform.rotation.x;
                float poczatkowyRotationZ = transform.rotation.z;

                Quaternion nowyRotation = Quaternion.Slerp(transform.rotation, docelowyObrot, 10.0f * Time.deltaTime);
                nowyRotation.x = poczatkowyrRotationX;
                nowyRotation.z = poczatkowyRotationZ;
                transform.rotation = nowyRotation;

                _idleObrotTimer = Random.Range(0, 5f);

            }

            if (_idle)
            {
                //losowy ruch zombiaka

                animator.SetBool("isWalking", true);
                transform.Translate(Vector3.forward * (PredkoscPoruszania - 2f) * Time.deltaTime);
            }

            if (_idleObrotTimer > 0)
            {
                _idleObrotTimer -= Time.deltaTime;
            }
            if (_hp <= 0)
            {
                Debug.Log("Spawn i zabicie zombiakow");
                //losowy spawn 3 przeciwników, jeśli ,mniej niż 20
                int ileSzkieletow = GameObject.FindGameObjectsWithTag("Enemy").Length;
                Debug.Log("Szkieletów na mapie: " + ileSzkieletow);
                if (ileSzkieletow < 30)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Debug.Log("Spawn zombiaka nr: " + i);
                        Instantiate(Zombiak,
                            _playerGameObject.transform.position +
                            new Vector3(Random.Range(-25f, 25f), 50f, Random.Range(-25f, 25f)), Quaternion.identity);
                    }
                }

                Destroy(gameObject);
            }

            if (transform.position.y < -50)
            {
                _hp = -10000000;
            }
        }

        void FixedUpdate()
        {
            if (_idle == false)
            {

                Quaternion docelowyObrot = Quaternion.LookRotation(_playerGameObject.transform.position - transform.position);
                float poczatkowyrRotationX = transform.rotation.x;
                float poczatkowyRotationZ = transform.rotation.z;

                Quaternion nowyRotation = Quaternion.Slerp(transform.rotation, docelowyObrot, 5.0f * Time.deltaTime);
                nowyRotation.x = poczatkowyrRotationX;
                nowyRotation.z = poczatkowyRotationZ;
                transform.rotation = nowyRotation;

                //ruch zombiaka w stronę gracza
                float dystansDoGracza = Vector3.Distance(transform.position, _playerGameObject.transform.position);
                if (dystansDoGracza > DystansAtaku)
                {
                    animator.SetBool("isWalking", false);
                    animator.SetBool("isRun", true);
                    transform.Translate(Vector3.forward * PredkoscPoruszania * Time.deltaTime);
                }
                else
                {
                    if (_timer <= 0)
                    {
                        animator.SetTrigger("Attack");
                        int obrazenia = Random.Range(0, SilaAtaku);
                        _gameController.SendMessage("otrzymajObrazenia", obrazenia);
                        _timer = PrzerwaMiedzyAtakiem;
                    }
                }
            }
            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
            }
        }

        void OnTriggerStay(Collider other)
        {
            //Obrót zombiaka
            if (other.tag.Equals("Player") && _hp > 0)
            {
                _idle = false;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.tag.Equals("Player") && _hp > 0)
            {
                _idle = true;
            }
        }

        void otrzymajObrazenia(int obrazenia)
        {
            _hp -= obrazenia;
            var audioSource = GetComponent<AudioSource>();
            int n = Random.Range(1, ObrazeniaAudioClips.Length);
            audioSource.clip = ObrazeniaAudioClips[n];
            audioSource.Play();
            ObrazeniaAudioClips[n] = ObrazeniaAudioClips[0];
            ObrazeniaAudioClips[0] = audioSource.clip;
            _gameController.SendMessage("dodajPunkty", obrazenia * Random.Range(1, 10));


        }
    }
}