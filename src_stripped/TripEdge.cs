﻿// Decompiled with JetBrains decompiler
// Type: TripEdge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

[Serializable]
public struct TripEdge
{
  public TripNode StartNode;
  public TripNode EndNode;
  public double Cost;
  public double InclinationCost;
  public bool CanAerobrake;

  public bool HasInclinationCost
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }
}
