using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChampi : MonoBehaviour
{

    [SerializeField] GameObject _ileDrapeau;
    [SerializeField] GameObject _ileChampi;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 drapeau = _ileDrapeau.transform.position;
        Vector3 champi = _ileChampi.transform.position;

        if (Random.value * 100 > 50f)
        {
            transform.position = champi;
        } 

        else
        {
           transform.position = drapeau;
        }
        Debug.Log(Random.value);
        
    }

}
