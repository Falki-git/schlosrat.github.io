﻿// Decompiled with JetBrains decompiler
// Type: EventBoolAndObsolete`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventBoolAndObsolete<T, U> : BaseGameEventObsolete
{
  private List<EventBoolAndObsolete<T, U>.EvtDelegate> events;
  private List<EventBoolAndObsolete<T, U>.EvtDelegate> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventBoolAndObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventBoolAndObsolete<T, U>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventBoolAndObsolete<T, U>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Fire(T data0, U data1) => throw null;

  private class EvtDelegate
  {
    public EventBoolAndObsolete<T, U>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventBoolAndObsolete<T, U>.OnEvent evt) => throw null;
  }

  public delegate bool OnEvent(T data0, U data1);
}
