﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABXAxisLastPartPlacedOffsetHighlightPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/XAxisLastPartPlacedOffsetHighlight", false, "Returns the offset in X within the last placed part and the highlight attach point in world coords, returns 9999 if any is invalid", "Substracts LastPartPlaced.PartTransform.position and highlightAttachPoint.position and returns the offset.x")]
  public class OABXAxisLastPartPlacedOffsetHighlightPropertyWatcher : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABXAxisLastPartPlacedOffsetHighlightPropertyWatcher() => throw null;
  }
}
