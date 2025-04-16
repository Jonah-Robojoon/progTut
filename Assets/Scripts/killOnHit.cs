using UnityEngine;
using UnityEngine.Audio;
using static UnityEngine.GraphicsBuffer;

public class killOnHit : MonoBehaviour
{

    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;
    private Hearts heartsScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision coll)
    {
        handleHit(coll.gameObject);

    }
    private void OnTriggerEnter(Collider coll)
    {
        handleHit(coll.gameObject);
    }
    private void handleHit(GameObject other)
    {
        if (other.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            expl.transform.position = other.transform.position;
            Destroy(expl, 2f);
            if (targetTag == "Player")
            {
                Destroy(gameObject);
                if (heartsScript == null)
                {
                    heartsScript = FindFirstObjectByType<Hearts>();

                    Debug.Log(heartsScript);
                }

                Debug.Log(heartsScript.Lives + "lives left");
                heartsScript.Lives--;
                Debug.Log(heartsScript.Lives + "lives left");
                if (heartsScript.Lives == 0)
                {
                    Destroy(other, 0.1f);
                }
            }
            else
            {
                Destroy(other, 0.1f);
            }
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
