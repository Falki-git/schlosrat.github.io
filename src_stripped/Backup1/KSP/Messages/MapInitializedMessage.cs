﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MapInitializedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/MapInitializedMessage", true, "Player has initialized the map view", "Whenever the map in any form is shown, be it 2D or 3D, this is called. This includes 2D tracking UI for things like the KSC, or colonies")]
  public class MapInitializedMessage : MessageCenterMessage
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapInitializedMessage() => throw null;
  }
}
