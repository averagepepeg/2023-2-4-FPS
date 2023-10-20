using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    private void Update() 
    {
        Debug.DrawRay(
            transform.position, 
            transform.forward * 10f, 
            Color.red
        );
    }

    public void Fire()
    {
        RaycastHit hit;

        if (Physics.Raycast(
            transform.position,
            transform.forward,
            out hit,
            10f
        )){
            // Choco con algo
            GameObject temp = Resources.Load<GameObject>("TestFire");
            var obj = Instantiate(
                temp, 
                hit.point, 
                Quaternion.identity);
            
            Destroy(obj, 3f);
            
        }

    }
}