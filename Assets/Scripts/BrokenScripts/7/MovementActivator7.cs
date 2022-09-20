using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator7 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // on needed to be capital so that the right function is called
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
    private void OnTriggerExit(Collider other) //  needed to be spelled right and capital so right function is called
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
}
