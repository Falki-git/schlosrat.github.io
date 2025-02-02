﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIVesselHudLocator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding.Core
{
  public abstract class UIVesselHudLocator : UIDataBinder<VesselDataProvider>
  {
    [Tooltip("This is how we fade in/out our UI elements as well as change its position if necessary.\r\nShould Contain all UI elements bound in this Binder Object.")]
    [Header("Group for showing/hiding bound UI")]
    [SerializeField]
    private CanvasGroup locationGroup;
    [FormerlySerializedAs("AnimationDuration")]
    [SerializeField]
    private float animationDuration;
    [FormerlySerializedAs("OffsetWhenDisabled")]
    [SerializeField]
    private Vector3 offsetWhenDisabled;

    protected CanvasGroup LocationGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected RectTransform LocationGroupTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new virtual void BindData(IProperty<VesselDataProvider> vesselProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void RedrawOnIsBoundChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIVesselHudLocator() => throw null;
  }
}
