﻿// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.Const
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Networking.MP.IGNet
{
  public static class Const
  {
    public const string DEFAULT_PLAYER_NAME_STRING_BASE = "Unnamed Player";
    public const int SERVER_MAX_PLAYERS = 1;
    public const int SERVER_MIN_PLAYERS = 1;

    public static class PlayerId
    {
      public const byte NONE = 0;
      public const byte FIRST = 1;
      public const byte HOST = 1;
      public const byte SINGLEPLAYER = 1;
    }

    public static class PlayerIdString
    {
      public const string NONE = "None";
    }
  }
}
