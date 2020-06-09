using UnityEngine;

namespace Assets.Scripts
{
    public class Cube : MonoBehaviour
    {
        private float x = 0;
        private float y = 0;
        private float predkoscPoruszania = 0;

        // Start is called before the first frame update
        void Start()
        {
            while (predkoscPoruszania == 0)
            {
                predkoscPoruszania = Random.Range(-10f, 10f);
            }
        }

        // Update is called once per frame
        void Update()
        {
            //Obraca kwadrat wokół własnej osi
            transform.rotation = Quaternion.Euler(45f, Time.timeSinceLevelLoad * 60f, 45f);
            x = Input.GetAxis("Horizontal") * Time.deltaTime * predkoscPoruszania;
            y = Input.GetAxis("Vertical") * Time.deltaTime * predkoscPoruszania;
            transform.Translate(x, y, 0);
        }
    }
}
