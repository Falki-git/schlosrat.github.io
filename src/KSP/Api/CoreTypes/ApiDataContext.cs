﻿// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.ApiDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class ApiDataContext : DataContext
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ApiDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RegisterContextData(bool requireAttribute = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAsRegistered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VerifyRegistered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool TryResolveProperty(string key, out IProperty property, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool TryResolveAction(string key, out IAction action, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool TryResolveSubContext(
      string key,
      out IDataContextReadonly subContext,
      bool searchStack = true,
      bool wrapStackResult = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool TryResolveList(
      string key,
      out IContextListProperty list,
      bool searchStack = true)
    {
      throw null;
    }
  }
}
