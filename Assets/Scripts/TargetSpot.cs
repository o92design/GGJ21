using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpot : MonoBehaviour
{
    public Vector3 mouseTarget = new Vector3();

    public Vector3 GetTarget()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Vector3 roundedHitPos = Vector3Int.RoundToInt(hit.point);

            Collider[] hitColliders = Physics.OverlapSphere(roundedHitPos, 0.5f);
            bool invalidPosition = false;
            foreach(Collider hitCollider in hitColliders)
            {
                if(hitCollider.tag == "obstacle")
                {
                    invalidPosition = true;
                    break;
                }
            }

            if(!invalidPosition)
            {
                mouseTarget = roundedHitPos;
            }
        }
        return mouseTarget;
    }
}
