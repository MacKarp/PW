using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
        public AudioClip GameWinSoundClip;
        public AudioClip GameLooseSoundClip;
        public Text CrystalCounterText;
        public Text CountDownText;
        public Text EndOfGameText;


        // Start is called before the first frame update
        void Start()
        {
            UpdateCrystalCounterText();
            EndOfGameText.enabled = false;
            StartCoroutine(CountDownCoroutine());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator CountDownCoroutine()
        {
            SetIfSphereCanMove(false);
            CountDownText.enabled = true;
            for (int i = 5; i > 0; i--)
            {
                CountDownText.text = i.ToString();
                yield return new WaitForSeconds(1f);
            }

            CountDownText.text = "Start!";
            yield return new WaitForSeconds(1f);
            CountDownText.enabled = false;
            SetIfSphereCanMove(true);
        }

        public void UpdateCrystalCounterText()
        {
            var crystals = FindObjectsOfType<Crystal>();
            var crystalCount = crystals.Length;
            var crystalInactive = crystals.Count(crystal => !crystal.Active);

            var text = crystalInactive + " / " + crystalCount;
            CrystalCounterText.text = text;
        }

        public void CheckIfEndOfGame()
        {
            var endOfGame = FindObjectsOfType<Crystal>().All(crystal => !crystal.Active);
            if (!endOfGame) return;
            EndOfGame(true);
        }

        public void EndOfGame(bool win)
        {
            StartCoroutine(EndOfGameCoroutine(win));
        }

        private void SetIfSphereCanMove(bool canMove)
        {
            var sphere = FindObjectOfType<Sphere>();
            sphere.CanMove = canMove;
            sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        IEnumerator EndOfGameCoroutine(bool win)
        {
            SetIfSphereCanMove(false);
            EndOfGameText.enabled = true;
            EndOfGameText.text = win ? "WIN!" : "LOOSE!";

            var audioSource = GetComponent<AudioSource>();
            audioSource.clip = win ? GameWinSoundClip : GameLooseSoundClip;
            audioSource.Play();

            yield return new WaitForSeconds(3f);
            Application.Quit();
        }
    }
}
