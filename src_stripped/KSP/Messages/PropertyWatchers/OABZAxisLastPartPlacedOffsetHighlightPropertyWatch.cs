﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABZAxisLastPartPlacedOffsetHighlightPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/ZAxisLastPartPlacedOffsetHighlight", false, "Returns the offset in Z within the last placed part and the highlight attach point in world coords, returns 9999 if any is invalid", "Substracts LastPartPlaced.PartTransform.position and highlightAttachPoint.position and returns the offset.z")]
  public class OABZAxisLastPartPlacedOffsetHighlightPropertyWatcher : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABZAxisLastPartPlacedOffsetHighlightPropertyWatcher() => throw null;
  }
}
