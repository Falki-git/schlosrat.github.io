﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modding.IKSP2ModCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Modding
{
  public interface IKSP2ModCore
  {
    KSP2ModCoreState ModCoreState { get; }

    void ModStart();

    void ModUpdate();

    void ModShutdown();

    bool ExecuteEvent(string eventName);
  }
}
