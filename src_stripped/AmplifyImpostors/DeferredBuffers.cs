﻿// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.DeferredBuffers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace AmplifyImpostors
{
  [Flags]
  public enum DeferredBuffers
  {
    AlbedoAlpha = 1,
    SpecularSmoothness = 2,
    NormalDepth = 4,
    EmissionOcclusion = 8,
  }
}
