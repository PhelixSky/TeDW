﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Net.ServerMode
// Assembly: Terraria, Version=1.3.4.4, Culture=neutral, PublicKeyToken=null
// MVID: DEE50102-BCC2-472F-987B-153E892583F1
// Assembly location: C:\Users\Zhi Cai\Documents\terraria source\Terraria1.3.4.4\Terraria\Terraria-cleaned.exe

using System;

namespace Terraria.Net
{
  [Flags]
  public enum ServerMode : byte
  {
    None = 0,
    Lobby = 1,
    FriendsCanJoin = 2,
    FriendsOfFriends = 4,
  }
}
