﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SteppedRangeAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public sealed class SteppedRangeAttribute : PropertyAttribute
  {
    public readonly float min;
    public readonly float max;
    public readonly float step;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SteppedRangeAttribute(float min, float max, float step) => throw null;
  }
}
