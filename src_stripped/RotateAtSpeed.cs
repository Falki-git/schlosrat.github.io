﻿// Decompiled with JetBrains decompiler
// Type: RotateAtSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class RotateAtSpeed : OABOrFlightEnablable
{
  [Space(10f)]
  public float XSpeed;
  public float YSpeed;
  public float ZSpeed;
  public bool localSpaceOn;
  private Space _curSpace;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RotateAtSpeed() => throw null;
}
