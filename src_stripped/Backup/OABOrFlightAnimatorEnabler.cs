﻿// Decompiled with JetBrains decompiler
// Type: OABOrFlightAnimatorEnabler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OABOrFlightAnimatorEnabler : KerbalMonoBehaviour
{
  [SerializeField]
  [Tooltip("Will be enabled in OAB")]
  private bool enableInOAB;
  [SerializeField]
  [Tooltip("Will be enabled in Flight")]
  private bool enableInFlight;
  [SerializeField]
  private Animator[] animators;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABOrFlightAnimatorEnabler() => throw null;
}
