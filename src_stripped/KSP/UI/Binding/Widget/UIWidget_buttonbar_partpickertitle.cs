﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_buttonbar_partpickertitle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_buttonbar_partpickertitle : UIWidget
  {
    [Header("Enum Part View Mode - Writable")]
    [SerializeField]
    private UIValueBinder partViewMode;

    public IUIValueEnumBindable PartViewMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_buttonbar_partpickertitle() => throw null;
  }
}
