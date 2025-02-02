﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselLoadedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/VesselLoadedMessage", true, "Player has loaded a vessel", "Currently both this and SubassemblyLoadedMessage are fired from the same code path")]
  public class VesselLoadedMessage : OABMessageBase
  {
    public bool HasAssembly;
    public bool IsFromSnapshot;
    public OABHistoricalSnapshot HistoricalSnapshot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselLoadedMessage() => throw null;
  }
}
