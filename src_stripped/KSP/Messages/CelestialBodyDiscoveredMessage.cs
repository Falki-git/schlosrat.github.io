﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyDiscoveredMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CelestialBody/CelestialBodyDiscoveredMessage", false, "Player has discovered a celestial body", "")]
  public class CelestialBodyDiscoveredMessage : CelestialBodyMessageBase
  {
    public string DiscoveredBodyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDiscoveredMessage(string discoveredBodyName) => throw null;
  }
}
