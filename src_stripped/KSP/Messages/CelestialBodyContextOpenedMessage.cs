﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyContextOpenedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CelestialBody/CelestialBodyContextOpenedMessage", false, "Fires when the context menu is opened on a planet.", "")]
  public class CelestialBodyContextOpenedMessage : CelestialBodyMessageBase
  {
    public string CelestialBodyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyContextOpenedMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyContextOpenedMessage(string celestialBodyName) => throw null;
  }
}
