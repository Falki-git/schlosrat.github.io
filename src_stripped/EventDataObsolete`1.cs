﻿// Decompiled with JetBrains decompiler
// Type: EventDataObsolete`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDataObsolete<T> : BaseGameEventObsolete
{
  private List<EventDataObsolete<T>.EvtDelegate> events;
  private List<EventDataObsolete<T>.EvtDelegate> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDataObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDataObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDataObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Fire(T data) => throw null;

  private class EvtDelegate
  {
    public EventDataObsolete<T>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventDataObsolete<T>.OnEvent evt) => throw null;
  }

  public delegate void OnEvent(T data);
}
