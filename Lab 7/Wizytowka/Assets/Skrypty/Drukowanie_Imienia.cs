using UnityEngine;

namespace Assets.Skrypty
{
    public class Drukowanie_Imienia : MonoBehaviour
    {
        public int Ilosc = 1;

        // Start is called before the first frame update
        void Start()
        {
            for(int i=0; i<Ilosc;i++){
                print("Maciej");
            }
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
