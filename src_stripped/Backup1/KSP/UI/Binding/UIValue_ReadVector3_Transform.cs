﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadVector3_Transform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadVector3_Transform : UIValueBinder<Vector3>
  {
    [SerializeField]
    private Transform boundTransform;
    [SerializeField]
    private UIValue_ReadVector3_Transform.TransformGroup destinationGroup;
    [Tooltip("TRUE = local space  FALSE = world space")]
    [SerializeField]
    private bool applyAsLocalCoordinates;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadVector3_Transform() => throw null;

    private enum TransformGroup
    {
      POSITION,
      ROTATION,
      SCALE,
    }
  }
}
