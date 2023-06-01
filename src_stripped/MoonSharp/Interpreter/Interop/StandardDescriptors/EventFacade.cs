﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardDescriptors.EventFacade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors
{
  internal class EventFacade : IUserDataType
  {
    private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_AddCallback;
    private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_RemoveCallback;
    private object m_Object;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EventFacade(EventMemberDescriptor parent, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EventFacade(
      Func<object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback,
      Func<object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback,
      object obj)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Index(Script script, DynValue index, bool isDirectIndexing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue MetaIndex(Script script, string metaname) => throw null;
  }
}
