﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderLog
  {
    private const bool activeLog = false;
    protected ObjectAssemblyBuilderEvents events;
    protected ObjectAssemblyUIEvents eventsUI;
    protected ObjectAssemblyBuilderFileIO fileIO;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderLog(
      ObjectAssemblyBuilderEvents eventsToUse,
      ObjectAssemblyUIEvents uiEventsToUse,
      ObjectAssemblyBuilderFileIO fileIOToUse)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void BindType(object @class, Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool BindLoggingToField(object @class, FieldInfo field) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Write(string evtName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void InternalLog(string funcName, string evtName) => throw null;
  }
}
