﻿// Decompiled with JetBrains decompiler
// Type: SgtShape
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class SgtShape : MonoBehaviour
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public abstract float GetDensity(Vector3 worldPoint) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected SgtShape() => throw null;
}
