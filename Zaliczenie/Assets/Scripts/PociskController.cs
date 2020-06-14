using UnityEngine;

public class PociskController : MonoBehaviour
{

    public int bazowyDMG = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -100)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy" && other.GetType() == typeof(BoxCollider))
        {
            Debug.Log(other.GetType().ToString() + " strzelam!");
            other.transform.gameObject.SendMessage("otrzymajObrazenia", bazowyDMG + Random.Range(0, bazowyDMG));
        }
    }
}
