using UnityEngine;

namespace Assets.Skrypty
{
    public class Poruszanie_Imienia : MonoBehaviour
    {

        private Vector2 kierunekPrawo= Vector2.right;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            float translation = Mathf.Sin(Time.timeSinceLevelLoad * 1.5f) * 2f;
            transform.Translate(kierunekPrawo*translation);
            float translation2 = Mathf.Sin(Time.timeSinceLevelLoad * 3f) * 100f;
            Quaternion target = Quaternion.Euler(0, 0, translation2);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime);
        }
    }
}
