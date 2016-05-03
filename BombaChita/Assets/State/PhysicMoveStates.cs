﻿using UnityEngine;
using System.Collections;

public abstract class PhysicMoveStates 
{
	//protected Rigidbody2D rigidbody2D;

	public abstract void  MoveUp (ref PhysicMove physicMove);
	public abstract void  MoveDown ( ref PhysicMove physicMove);
	public abstract void MoveLeft (ref  PhysicMove physicMove);
	public abstract void MoveRight (ref  PhysicMove physicMove);

	public void ChangeState ( ref PhysicMove physicMove, PhysicMoveStates state)
	{
		physicMove.ChangeMoveState (state);
	}
	public abstract void Update (ref PhysicMove physicMove);
}
