﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.JsonUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public static class JsonUtil
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ObjectToJsonString<T>(T obj, SaveJsonFormatting saveJsonFormatting) where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T JsonStringToObject<T>(string jsonString) where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DebugDumpObjectToFileAsJsonText<T>(
      T obj,
      SaveJsonFormatting saveJsonFormatting,
      string fileNameBase,
      string extension = ".json")
      where T : class
    {
      throw null;
    }
  }
}
