﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Node 
{
    public override void Execute()
    {
        currentState = Result.RUNNING;
        Debug.Log("ATTACK");
    }
	
}
