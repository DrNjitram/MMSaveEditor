﻿using FullSerializer;

[fsObject( MemberSerialization = fsMemberSerialization.OptOut )]
public class AISafetyFlagBehaviour : AIBehaviour
{
	private static readonly SpeedManager.Controller[] mSpeedControllers = new SpeedManager.Controller[4] { SpeedManager.Controller.TrackLayout, SpeedManager.Controller.Avoidance, SpeedManager.Controller.PathType, SpeedManager.Controller.SafetyCar };
	private static readonly SteeringManager.Behaviour[] mSteeringBehaviours = new SteeringManager.Behaviour[3] { SteeringManager.Behaviour.Avoidance, SteeringManager.Behaviour.RacingLine, SteeringManager.Behaviour.TargetPoint };
	private float mTargetSpace = 0.9f;
	private float mTimer;
	private float mTargetSpaceOffset;
	private bool mIsInSafetyTrain;
	private bool mCanOverTake;

}
