using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(12 * Time.deltaTime, 6 * Time.deltaTime, -9.23f * Time.deltaTime) ;
    }
}
