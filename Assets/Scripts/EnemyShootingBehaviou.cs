using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using System.Collections;

public class EnemyShootingBehaviou : MonoBehaviour
{
    public Shoot shootScript;
    private triggerAnim triggerAnimationScript;
    public float coolDownTime = 1.0f;
    private bool inCooldown;
    //public float coolUpTime = 1.0f;
    public float shotRange = 5.0f;
    public GameObject player;
    private Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootScript = GetComponent<Shoot>();
        triggerAnimationScript = GetComponent<triggerAnim>();
        player = GameObject.Find("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
            transform.LookAt(targetPos);
        }


        Vector3 delta = transform.position - target.position;

        if (delta.magnitude < shotRange && !inCooldown)
        {
            shootScript.CallShot();
            triggerAnimationScript.CallTrigger();
            inCooldown = true;
            StartCoroutine(Cooldown(coolDownTime));
        }
    }
    private IEnumerator Cooldown(float time)
    {
        yield return new WaitForSeconds(time);
        inCooldown = false;
    }
}
