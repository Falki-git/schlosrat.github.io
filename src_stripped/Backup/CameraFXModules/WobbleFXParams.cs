﻿// Decompiled with JetBrains decompiler
// Type: CameraFXModules.WobbleFXParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace CameraFXModules
{
  [Serializable]
  public class WobbleFXParams
  {
    public MinMaxFloat amplitude;
    public MinMaxFloat frequency;
    public float slope;
    public FXModuleParams fxPars;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WobbleFXParams() => throw null;
  }
}
