using UnityEngine;

namespace Assets.Skrypty
{
    public class Numer_Albumu : MonoBehaviour
    {
        private Vector2 kierunekPrawo = Vector2.right;
        private Vector2 kierunekGora = Vector2.up;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float translationPrawo = Mathf.Sin(Time.timeSinceLevelLoad * 1.5f) * 5f;
            float translationGora = Mathf.Sin(Time.timeSinceLevelLoad * 2f) * 1f;
            transform.Translate(kierunekPrawo * translationPrawo);
            transform.Translate(kierunekGora * translationGora);

        }
    }
}
