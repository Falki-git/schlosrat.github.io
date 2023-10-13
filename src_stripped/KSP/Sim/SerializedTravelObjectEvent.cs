﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelObjectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedTravelObjectEvent
  {
    public List<Guid> TravelObjectIds;
    public string EventKey;
    public double UT;
    public string[] FlightReportArgs;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelObjectEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelObjectEvent(TravelObjectEvent tEvent) => throw null;
  }
}
