using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesBronze : MonoBehaviour
{
    [SerializeField] GameObject _pieceBronze;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_pieceBronze, transform.position, transform.rotation);   
    }

    
}
