using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMultiplier = 4f;
    private float _movementHorizontal, _movementVertical;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal") * speedMultiplier;
        float movementVertical = Input.GetAxis("Vertical") * speedMultiplier;
        _rigidbody.AddForce(movementHorizontal, 0, movementVertical, ForceMode.Acceleration);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Gold")) // Detection of Coin
        { 
        GameObject.Destroy(other.gameObject); //Destroy Coin

        //Increase Score
        //At 100 Coins Gain Life
        }
    }
}
