﻿// Decompiled with JetBrains decompiler
// Type: KSP.Api.IUIDataContextProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Api
{
  public interface IUIDataContextProvider : IDataContextProvider
  {
    bool RequestForModifications(out IDataContext writableContext);

    void BindContext(IDataContextReadonly contextStack);
  }
}
