﻿// Decompiled with JetBrains decompiler
// Type: EventValueOperationObsolete`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventValueOperationObsolete<T> : BaseGameEventObsolete
{
  private List<EventValueOperationObsolete<T>.EvtDelegate> events;
  private List<EventValueOperationObsolete<T>.EvtDelegate> eventsClone;
  private T defaultValue;
  private EventValueOperationObsolete<T>.OnOperation operation;

  public T value
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventValueOperationObsolete(
    string eventName,
    T defaultValue,
    EventValueOperationObsolete<T>.OnOperation operation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventValueOperationObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventValueOperationObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  private class EvtDelegate
  {
    public EventValueOperationObsolete<T>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventValueOperationObsolete<T>.OnEvent evt) => throw null;
  }

  public delegate T OnOperation(T a, T b);

  public delegate T OnEvent();
}
