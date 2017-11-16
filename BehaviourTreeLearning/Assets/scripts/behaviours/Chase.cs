using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : Node
{
    bool move = true;

	public override void Execute()
	{
        currentState = Result.RUNNING;

        if(move)
        {
			BT.transform.position = Vector3.MoveTowards(BT.transform.position, BT.player.transform.position, BT.moveSpeed * Time.deltaTime);
		}


        if (Vector3.Distance(BT.player.transform.position, BT.transform.position) < 2f)
        {
            move = false;
            currentState = Result.SUCCESS;
        }
        else
        {
            move = true;
        }

        Debug.Log("CHASE");
	}
}
