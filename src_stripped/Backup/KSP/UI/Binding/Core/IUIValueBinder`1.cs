﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.IUIValueBinder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.UI.Binding.Core
{
  public interface IUIValueBinder<T> : IUIValueBindable<T>, IUIValueBindable
  {
    T GetValue();

    void SetValue(T valueProperty);
  }
}
