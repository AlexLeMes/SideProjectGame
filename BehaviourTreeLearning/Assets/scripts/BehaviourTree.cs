using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
    Node root;

    public GameObject player;

    public float moveSpeed = 5f;

    public void Start()
    {
        root = new Selector();
        //root.children.Add(new Selector());
        root.children.Add(new Sequencer());
        root.children[0].children.Add(new Chase());
        root.children[0].children.Add(new Attack());
        root.children.Add(new Patrol());

        root.BT = this;

        root.Start();
    }

    public void Update()
    {
        root.Execute();
    }

}
