﻿// Decompiled with JetBrains decompiler
// Type: TripData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class TripData
{
  public List<NodeData> TripNodes;
  public List<EdgeData> TripEdges;
  public List<AngleData> TripAngles;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TripData() => throw null;
}
