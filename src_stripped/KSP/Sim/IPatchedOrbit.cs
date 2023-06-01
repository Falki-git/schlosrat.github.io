﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPatchedOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Sim
{
  public interface IPatchedOrbit : IOrbit, IDisposable, IComparable<IPatchedOrbit>
  {
    double StartUT { get; set; }

    double EndUT { get; set; }

    bool ActivePatch { get; set; }

    PatchTransitionType PatchStartTransition { get; set; }

    PatchTransitionType PatchEndTransition { get; set; }

    IPatchedOrbit NextPatch { get; set; }

    IPatchedOrbit PreviousPatch { get; set; }

    double UniversalTimeAtClosestApproach { get; set; }

    double UniversalTimeAtSoiEncounter { get; set; }

    double ClosestApproachDistance { get; set; }

    double TimeToPe { get; set; }

    double TimeToAp { get; set; }
  }
}
