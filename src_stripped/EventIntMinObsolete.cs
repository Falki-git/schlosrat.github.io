﻿// Decompiled with JetBrains decompiler
// Type: EventIntMinObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventIntMinObsolete : BaseGameEventObsolete
{
  private List<EventIntMinObsolete.EvtDelegate> events;
  private List<EventIntMinObsolete.EvtDelegate> eventsClone;
  public int defaultValue;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventIntMinObsolete(string eventName, int defaultValue = 0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventIntMinObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventIntMinObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int Fire() => throw null;

  private class EvtDelegate
  {
    public EventIntMinObsolete.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventIntMinObsolete.OnEvent evt) => throw null;
  }

  public delegate int OnEvent();
}
