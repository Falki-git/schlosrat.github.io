﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.ObjectCallbackMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase
  {
    private Func<object, ScriptExecutionContext, CallbackArguments, object> m_CallbackFunc;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectCallbackMemberDescriptor(string funcName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectCallbackMemberDescriptor(
      string funcName,
      Func<object, ScriptExecutionContext, CallbackArguments, object> callBack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectCallbackMemberDescriptor(
      string funcName,
      Func<object, ScriptExecutionContext, CallbackArguments, object> callBack,
      ParameterDescriptor[] parameters)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Execute(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args)
    {
      throw null;
    }
  }
}
