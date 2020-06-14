using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
        public Text PoziomHpText;
        public Text PunktyText;
        public Text PoczatekGryText;
        public Text KoniecGryText;
        public AudioClip KoniecGryAudioClip;
        public AudioClip[] ObrazeniaAudioClips;

        private int maxHP = 100;
        private int _aktualneHp = 100;
        private int _aktualnePunkty = 0;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(PoczatekGry());
        }

        // Update is called once per frame
        void Update()
        {

            //if (Input.GetKeyDown(KeyCode.O))
            //{
            //    otrzymajObrazenia(10);
            //}

            //if (Input.GetKeyDown(KeyCode.P))
            //{
            //    dodajPunkty(10);
            //}


        }


        //Odlicza początek gry
        IEnumerator PoczatekGry()
        {
            MoznaGrac(false);
            PoziomHpText.text = "HP: " + _aktualneHp + "%";
            KoniecGryText.enabled = false;
            PunktyText.text = "Punkty: " + _aktualnePunkty;

            PoczatekGryText.enabled = true;
            for (int i = 5; i > 0; i--)
            {
                PoczatekGryText.text = i.ToString();
                yield return new WaitForSecondsRealtime(1f);
            }

            PoczatekGryText.text = "START!";
            yield return new WaitForSecondsRealtime(1f);
            PoczatekGryText.enabled = false;
            MoznaGrac(true);
        }

        //Aktualizuje poziom życia gracza
        void otrzymajObrazenia(int obrazenia)
        {
            _aktualneHp -= obrazenia;
            _aktualneHp = Mathf.Clamp(_aktualneHp, 0, maxHP);
            PoziomHpText.text = "HP: " + _aktualneHp + "%";
            var audioSource = GetComponent<AudioSource>();
            int n = Random.Range(1, ObrazeniaAudioClips.Length);
            audioSource.clip = ObrazeniaAudioClips[n];
            audioSource.Play();
            ObrazeniaAudioClips[n] = ObrazeniaAudioClips[0];
            ObrazeniaAudioClips[0] = audioSource.clip;
            //Sprawdza czy koniec gry
            if (_aktualneHp == 0)
            {
                StartCoroutine(KoniecCoroutine());
            }
        }

        //Aktualizuje ilość punktów gracza
        void dodajPunkty(int nowePunkty)
        {
            _aktualnePunkty += nowePunkty;
            PunktyText.text = "Punkty: " + _aktualnePunkty;
        }

        //Kończy gre
        IEnumerator KoniecCoroutine()
        {
            MoznaGrac(false);
            KoniecGryText.enabled = true;
            KoniecGryText.text = "Koniec Gry!\nTwój wynik to: " + _aktualnePunkty;
            var audioSource = GetComponent<AudioSource>();
            audioSource.clip = KoniecGryAudioClip;
            audioSource.Play();

            yield return new WaitForSecondsRealtime(10f);
            Application.Quit();
        }

        void MoznaGrac(bool stanGry)
        {
            if (stanGry)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}
