﻿// Decompiled with JetBrains decompiler
// Type: ConfigurableJointExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class ConfigurableJointExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetTargetRotationLocal(
    this ConfigurableJoint joint,
    Quaternion targetLocalRotation,
    Quaternion startLocalRotation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetTargetRotation(
    this ConfigurableJoint joint,
    Quaternion targetWorldRotation,
    Quaternion startWorldRotation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetTargetRotationInternal(
    this ConfigurableJoint joint,
    Quaternion targetRotation,
    Quaternion startRotation,
    Space space)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Quaternion GetExternalToJointSpaceRotation(this ConfigurableJoint joint) => throw null;
}
