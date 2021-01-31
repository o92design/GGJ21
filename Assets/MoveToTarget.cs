using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    public UnityEngine.AI.NavMeshAgent agent;
    public TargetSpot mouseTargeter;
    // Start is called before the first frame update
    void Start()
    {
        mouseTargeter = GetComponent<TargetSpot>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            target.position = mouseTargeter.GetTarget();
            agent.destination = target.position;
        }
    }
}
