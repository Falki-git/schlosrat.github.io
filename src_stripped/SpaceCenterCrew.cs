﻿// Decompiled with JetBrains decompiler
// Type: SpaceCenterCrew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class SpaceCenterCrew : MonoBehaviour
{
  public float speed;
  public Transform[] waypoints;
  public int currentwaypoint;
  protected Vector3 target;
  protected Vector3 moveDirection;
  protected Vector3 velocity;
  protected SpaceCenterCrew.CrewType cType;
  protected SpaceCenterCrew.crewStates state;
  protected bool stateChanged;
  protected string[] crewAnimations;
  protected Animation _animation;
  protected Rigidbody _rigidbody;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void CrewMovement() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void SetAnimation() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SpaceCenterCrew() => throw null;

  public enum CrewType
  {
    GroundCrew,
    Mechanic,
    Scientist,
  }

  public enum crewStates
  {
    Idle,
    Walking,
    Running,
    Standing,
  }
}
