using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
        public Text TextComponent;
        private int _numberOfSpecialBlocksAtBeginig;
        public bool IsPlaying = true;
        public string NextLevelName;

        // Start is called before the first frame update
        void Start()
        {
            FixLightinig();
            TextComponent.enabled = false;
            _numberOfSpecialBlocksAtBeginig = CountBlocks(special: true);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnValidate()
        {
            FixLightinig();
        }

        void FixLightinig()
        {
            RenderSettings.ambientLight = Color.white;
            RenderSettings.ambientMode = AmbientMode.Flat;
        }

        public int CountBlocks(bool special)
        {
            return FindObjectsOfType<Block>().Count(block => block.Enabled && block.IsSpecial == special);
        }

        public void OnTriggerExit(Collider otherCollider)
        {
            var block = otherCollider.GetComponent<Block>();
            if (block == null) return;

            block.Enabled = false;
            if (block.IsSpecial) StartCoroutine(EndGameCouritne(false));
            else if (CountBlocks(special: false) == 0) StartCoroutine(EndGameCouritne(true));
            Destroy(block.gameObject);

        }

        IEnumerator EndGameCouritne(bool won)
        {
            if (!IsPlaying) yield break;
            TextComponent.enabled = true;
            IsPlaying = false;

            if (won)
            {
                for (int i = 5; i > 0; i--)
                {
                    TextComponent.text = i.ToString();
                    yield return new WaitForSeconds(1f);
                }

                if (_numberOfSpecialBlocksAtBeginig != CountBlocks(special: true)) won = false;
            }

            TextComponent.text = won ? "Wygrałeś!" : "Przegrałeś!";
            yield return new WaitForSeconds(3f);
            if (string.IsNullOrEmpty(NextLevelName))
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene(NextLevelName);
            }
        }
    }
}

