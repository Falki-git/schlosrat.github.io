﻿// Decompiled with JetBrains decompiler
// Type: EventVoidObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventVoidObsolete : BaseGameEventObsolete
{
  private List<EventVoidObsolete.EvtDelegateObsolete> events;
  private List<EventVoidObsolete.EvtDelegateObsolete> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventVoidObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventVoidObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventVoidObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Fire() => throw null;

  private class EvtDelegateObsolete
  {
    public EventVoidObsolete.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegateObsolete(EventVoidObsolete.OnEvent evt) => throw null;
  }

  public delegate void OnEvent();
}
