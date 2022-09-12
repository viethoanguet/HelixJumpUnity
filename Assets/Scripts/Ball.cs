using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject splashPrefab;
    public float jumpForce;
    [SerializeField] private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {

        rb.AddForce(Vector3.up * jumpForce);


        if (other.transform.CompareTag("Safe"))
        {
            GameObject splash = Instantiate(splashPrefab, transform.position, transform.rotation);
            Destroy(splash, 1);
        }
        else if (other.transform.CompareTag("UnSafe"))
        {
            gm.RestartGame();
        }
        else if (other.transform.CompareTag("LastRing"))
        {
            gm.NextLevel();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Ring"))
        {
            Destroy(other.gameObject);
            GameManager.instance.GameScore(10);
        }
    }

}
