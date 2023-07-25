﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIDataContextBindBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public abstract class UIDataContextBindBase : MonoBehaviour, IUIDataContextBindable
  {
    protected bool isDestroyed;
    private IUIDataContextProvider cachedContextProvider;

    protected IDataContextReadonly DataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsContextBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    protected bool IsBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected abstract bool CheckSelfForContextProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CheckForMetadataChanges(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindContext(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IUIDataContextProvider GetDataContextProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IUIDataContextProvider RecursiveFindContextProviderInParents(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIDataContextBindBase() => throw null;
  }
}
