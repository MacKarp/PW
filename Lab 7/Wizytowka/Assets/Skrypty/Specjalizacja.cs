using Unity.Mathematics;
using UnityEngine;

namespace Assets.Skrypty
{
    public class Specjalizacja : MonoBehaviour
    {
        private quaternion rotacja;


        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            float translation = Mathf.Sin(Time.timeSinceLevelLoad * 3f) * 100f;
            Quaternion target = Quaternion.Euler(0, translation, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime);
        }
    }
}
