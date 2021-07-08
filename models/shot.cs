using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public GameObject arcamera;
    public GameObject smoke;

    public void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(arcamera.transform.position , arcamera.transform.forward , out hit))
        {
            if ( hit.transform.name == "ballone1(clone)" || hit.transform.name == "ballone2(clone)" || hit.transform.name == "ballone3(clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
