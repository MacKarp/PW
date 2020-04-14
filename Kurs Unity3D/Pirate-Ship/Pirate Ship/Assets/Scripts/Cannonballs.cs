using UnityEngine;

public class Cannonballs : MonoBehaviour
{
    public GameObject waterParticlesGameObject;
    public GameObject terrainParticleGameObject;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var layerId = collision.collider.gameObject.layer;
        var layerName = LayerMask.LayerToName(layerId);

        GameObject particlesGameObject = null;
        if (layerName == "Water") particlesGameObject = waterParticlesGameObject;

        if (layerName == "Terrain") particlesGameObject = terrainParticleGameObject;

        var position = collision.contacts[0].point;
        Instantiate(particlesGameObject, position, Quaternion.identity);

        Destroy(gameObject);
    }
}
