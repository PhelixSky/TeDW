﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Chest
// Assembly: Terraria, Version=1.3.4.4, Culture=neutral, PublicKeyToken=null
// MVID: DEE50102-BCC2-472F-987B-153E892583F1
// Assembly location: C:\Users\Zhi Cai\Documents\terraria source\Terraria1.3.4.4\Terraria\Terraria-cleaned.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ObjectData;

namespace Terraria
{
  public class Chest
  {
    public static int[] chestTypeToIcon = new int[52];
    public static int[] chestItemSpawn = new int[52];
    public static int[] dresserTypeToIcon = new int[28];
    public static int[] dresserItemSpawn = new int[28];
    public const int maxChestTypes = 52;
    public const int maxDresserTypes = 28;
    public const int maxItems = 40;
    public const int MaxNameLength = 20;
    public Item[] item;
    public int x;
    public int y;
    public bool bankChest;
    public string name;
    public int frameCounter;
    public int frame;

    public Chest(bool bank = false)
    {
      this.item = new Item[40];
      this.bankChest = bank;
      this.name = string.Empty;
    }

    public override string ToString()
    {
      int num = 0;
      for (int index = 0; index < this.item.Length; ++index)
      {
        if (this.item[index].stack > 0)
          ++num;
      }
      return string.Format("{{X: {0}, Y: {1}, Count: {2}}}", (object) this.x, (object) this.y, (object) num);
    }

    public static void Initialize()
    {
      int[] chestTypeToIcon1 = Chest.chestTypeToIcon;
      int index1 = 0;
      Chest.chestItemSpawn[0] = 48;
      int num1 = 48;
      chestTypeToIcon1[index1] = num1;
      int[] chestTypeToIcon2 = Chest.chestTypeToIcon;
      int index2 = 1;
      Chest.chestItemSpawn[1] = 306;
      int num2 = 306;
      chestTypeToIcon2[index2] = num2;
      Chest.chestTypeToIcon[2] = 327;
      Chest.chestItemSpawn[2] = 306;
      int[] chestTypeToIcon3 = Chest.chestTypeToIcon;
      int index3 = 3;
      Chest.chestItemSpawn[3] = 328;
      int num3 = 328;
      chestTypeToIcon3[index3] = num3;
      Chest.chestTypeToIcon[4] = 329;
      Chest.chestItemSpawn[4] = 328;
      int[] chestTypeToIcon4 = Chest.chestTypeToIcon;
      int index4 = 5;
      Chest.chestItemSpawn[5] = 343;
      int num4 = 343;
      chestTypeToIcon4[index4] = num4;
      int[] chestTypeToIcon5 = Chest.chestTypeToIcon;
      int index5 = 6;
      Chest.chestItemSpawn[6] = 348;
      int num5 = 348;
      chestTypeToIcon5[index5] = num5;
      int[] chestTypeToIcon6 = Chest.chestTypeToIcon;
      int index6 = 7;
      Chest.chestItemSpawn[7] = 625;
      int num6 = 625;
      chestTypeToIcon6[index6] = num6;
      int[] chestTypeToIcon7 = Chest.chestTypeToIcon;
      int index7 = 8;
      Chest.chestItemSpawn[8] = 626;
      int num7 = 626;
      chestTypeToIcon7[index7] = num7;
      int[] chestTypeToIcon8 = Chest.chestTypeToIcon;
      int index8 = 9;
      Chest.chestItemSpawn[9] = 627;
      int num8 = 627;
      chestTypeToIcon8[index8] = num8;
      int[] chestTypeToIcon9 = Chest.chestTypeToIcon;
      int index9 = 10;
      Chest.chestItemSpawn[10] = 680;
      int num9 = 680;
      chestTypeToIcon9[index9] = num9;
      int[] chestTypeToIcon10 = Chest.chestTypeToIcon;
      int index10 = 11;
      Chest.chestItemSpawn[11] = 681;
      int num10 = 681;
      chestTypeToIcon10[index10] = num10;
      int[] chestTypeToIcon11 = Chest.chestTypeToIcon;
      int index11 = 12;
      Chest.chestItemSpawn[12] = 831;
      int num11 = 831;
      chestTypeToIcon11[index11] = num11;
      int[] chestTypeToIcon12 = Chest.chestTypeToIcon;
      int index12 = 13;
      Chest.chestItemSpawn[13] = 838;
      int num12 = 838;
      chestTypeToIcon12[index12] = num12;
      int[] chestTypeToIcon13 = Chest.chestTypeToIcon;
      int index13 = 14;
      Chest.chestItemSpawn[14] = 914;
      int num13 = 914;
      chestTypeToIcon13[index13] = num13;
      int[] chestTypeToIcon14 = Chest.chestTypeToIcon;
      int index14 = 15;
      Chest.chestItemSpawn[15] = 952;
      int num14 = 952;
      chestTypeToIcon14[index14] = num14;
      int[] chestTypeToIcon15 = Chest.chestTypeToIcon;
      int index15 = 16;
      Chest.chestItemSpawn[16] = 1142;
      int num15 = 1142;
      chestTypeToIcon15[index15] = num15;
      int[] chestTypeToIcon16 = Chest.chestTypeToIcon;
      int index16 = 17;
      Chest.chestItemSpawn[17] = 1298;
      int num16 = 1298;
      chestTypeToIcon16[index16] = num16;
      int[] chestTypeToIcon17 = Chest.chestTypeToIcon;
      int index17 = 18;
      Chest.chestItemSpawn[18] = 1528;
      int num17 = 1528;
      chestTypeToIcon17[index17] = num17;
      int[] chestTypeToIcon18 = Chest.chestTypeToIcon;
      int index18 = 19;
      Chest.chestItemSpawn[19] = 1529;
      int num18 = 1529;
      chestTypeToIcon18[index18] = num18;
      int[] chestTypeToIcon19 = Chest.chestTypeToIcon;
      int index19 = 20;
      Chest.chestItemSpawn[20] = 1530;
      int num19 = 1530;
      chestTypeToIcon19[index19] = num19;
      int[] chestTypeToIcon20 = Chest.chestTypeToIcon;
      int index20 = 21;
      Chest.chestItemSpawn[21] = 1531;
      int num20 = 1531;
      chestTypeToIcon20[index20] = num20;
      int[] chestTypeToIcon21 = Chest.chestTypeToIcon;
      int index21 = 22;
      Chest.chestItemSpawn[22] = 1532;
      int num21 = 1532;
      chestTypeToIcon21[index21] = num21;
      Chest.chestTypeToIcon[23] = 1533;
      Chest.chestItemSpawn[23] = 1528;
      Chest.chestTypeToIcon[24] = 1534;
      Chest.chestItemSpawn[24] = 1529;
      Chest.chestTypeToIcon[25] = 1535;
      Chest.chestItemSpawn[25] = 1530;
      Chest.chestTypeToIcon[26] = 1536;
      Chest.chestItemSpawn[26] = 1531;
      Chest.chestTypeToIcon[27] = 1537;
      Chest.chestItemSpawn[27] = 1532;
      int[] chestTypeToIcon22 = Chest.chestTypeToIcon;
      int index22 = 28;
      Chest.chestItemSpawn[28] = 2230;
      int num22 = 2230;
      chestTypeToIcon22[index22] = num22;
      int[] chestTypeToIcon23 = Chest.chestTypeToIcon;
      int index23 = 29;
      Chest.chestItemSpawn[29] = 2249;
      int num23 = 2249;
      chestTypeToIcon23[index23] = num23;
      int[] chestTypeToIcon24 = Chest.chestTypeToIcon;
      int index24 = 30;
      Chest.chestItemSpawn[30] = 2250;
      int num24 = 2250;
      chestTypeToIcon24[index24] = num24;
      int[] chestTypeToIcon25 = Chest.chestTypeToIcon;
      int index25 = 31;
      Chest.chestItemSpawn[31] = 2526;
      int num25 = 2526;
      chestTypeToIcon25[index25] = num25;
      int[] chestTypeToIcon26 = Chest.chestTypeToIcon;
      int index26 = 32;
      Chest.chestItemSpawn[32] = 2544;
      int num26 = 2544;
      chestTypeToIcon26[index26] = num26;
      int[] chestTypeToIcon27 = Chest.chestTypeToIcon;
      int index27 = 33;
      Chest.chestItemSpawn[33] = 2559;
      int num27 = 2559;
      chestTypeToIcon27[index27] = num27;
      int[] chestTypeToIcon28 = Chest.chestTypeToIcon;
      int index28 = 34;
      Chest.chestItemSpawn[34] = 2574;
      int num28 = 2574;
      chestTypeToIcon28[index28] = num28;
      int[] chestTypeToIcon29 = Chest.chestTypeToIcon;
      int index29 = 35;
      Chest.chestItemSpawn[35] = 2612;
      int num29 = 2612;
      chestTypeToIcon29[index29] = num29;
      Chest.chestTypeToIcon[36] = 327;
      Chest.chestItemSpawn[36] = 2612;
      int[] chestTypeToIcon30 = Chest.chestTypeToIcon;
      int index30 = 37;
      Chest.chestItemSpawn[37] = 2613;
      int num30 = 2613;
      chestTypeToIcon30[index30] = num30;
      Chest.chestTypeToIcon[38] = 327;
      Chest.chestItemSpawn[38] = 2613;
      int[] chestTypeToIcon31 = Chest.chestTypeToIcon;
      int index31 = 39;
      Chest.chestItemSpawn[39] = 2614;
      int num31 = 2614;
      chestTypeToIcon31[index31] = num31;
      Chest.chestTypeToIcon[40] = 327;
      Chest.chestItemSpawn[40] = 2614;
      int[] chestTypeToIcon32 = Chest.chestTypeToIcon;
      int index32 = 41;
      Chest.chestItemSpawn[41] = 2615;
      int num32 = 2615;
      chestTypeToIcon32[index32] = num32;
      int[] chestTypeToIcon33 = Chest.chestTypeToIcon;
      int index33 = 42;
      Chest.chestItemSpawn[42] = 2616;
      int num33 = 2616;
      chestTypeToIcon33[index33] = num33;
      int[] chestTypeToIcon34 = Chest.chestTypeToIcon;
      int index34 = 43;
      Chest.chestItemSpawn[43] = 2617;
      int num34 = 2617;
      chestTypeToIcon34[index34] = num34;
      int[] chestTypeToIcon35 = Chest.chestTypeToIcon;
      int index35 = 44;
      Chest.chestItemSpawn[44] = 2618;
      int num35 = 2618;
      chestTypeToIcon35[index35] = num35;
      int[] chestTypeToIcon36 = Chest.chestTypeToIcon;
      int index36 = 45;
      Chest.chestItemSpawn[45] = 2619;
      int num36 = 2619;
      chestTypeToIcon36[index36] = num36;
      int[] chestTypeToIcon37 = Chest.chestTypeToIcon;
      int index37 = 46;
      Chest.chestItemSpawn[46] = 2620;
      int num37 = 2620;
      chestTypeToIcon37[index37] = num37;
      int[] chestTypeToIcon38 = Chest.chestTypeToIcon;
      int index38 = 47;
      Chest.chestItemSpawn[47] = 2748;
      int num38 = 2748;
      chestTypeToIcon38[index38] = num38;
      int[] chestTypeToIcon39 = Chest.chestTypeToIcon;
      int index39 = 48;
      Chest.chestItemSpawn[48] = 2814;
      int num39 = 2814;
      chestTypeToIcon39[index39] = num39;
      int[] chestTypeToIcon40 = Chest.chestTypeToIcon;
      int index40 = 49;
      Chest.chestItemSpawn[49] = 3180;
      int num40 = 3180;
      chestTypeToIcon40[index40] = num40;
      int[] chestTypeToIcon41 = Chest.chestTypeToIcon;
      int index41 = 50;
      Chest.chestItemSpawn[50] = 3125;
      int num41 = 3125;
      chestTypeToIcon41[index41] = num41;
      int[] chestTypeToIcon42 = Chest.chestTypeToIcon;
      int index42 = 51;
      Chest.chestItemSpawn[51] = 3181;
      int num42 = 3181;
      chestTypeToIcon42[index42] = num42;
      int[] dresserTypeToIcon1 = Chest.dresserTypeToIcon;
      int index43 = 0;
      Chest.dresserItemSpawn[0] = 334;
      int num43 = 334;
      dresserTypeToIcon1[index43] = num43;
      int[] dresserTypeToIcon2 = Chest.dresserTypeToIcon;
      int index44 = 1;
      Chest.dresserItemSpawn[1] = 647;
      int num44 = 647;
      dresserTypeToIcon2[index44] = num44;
      int[] dresserTypeToIcon3 = Chest.dresserTypeToIcon;
      int index45 = 2;
      Chest.dresserItemSpawn[2] = 648;
      int num45 = 648;
      dresserTypeToIcon3[index45] = num45;
      int[] dresserTypeToIcon4 = Chest.dresserTypeToIcon;
      int index46 = 3;
      Chest.dresserItemSpawn[3] = 649;
      int num46 = 649;
      dresserTypeToIcon4[index46] = num46;
      int[] dresserTypeToIcon5 = Chest.dresserTypeToIcon;
      int index47 = 4;
      Chest.dresserItemSpawn[4] = 918;
      int num47 = 918;
      dresserTypeToIcon5[index47] = num47;
      int[] dresserTypeToIcon6 = Chest.dresserTypeToIcon;
      int index48 = 5;
      Chest.dresserItemSpawn[5] = 2386;
      int num48 = 2386;
      dresserTypeToIcon6[index48] = num48;
      int[] dresserTypeToIcon7 = Chest.dresserTypeToIcon;
      int index49 = 6;
      Chest.dresserItemSpawn[6] = 2387;
      int num49 = 2387;
      dresserTypeToIcon7[index49] = num49;
      int[] dresserTypeToIcon8 = Chest.dresserTypeToIcon;
      int index50 = 7;
      Chest.dresserItemSpawn[7] = 2388;
      int num50 = 2388;
      dresserTypeToIcon8[index50] = num50;
      int[] dresserTypeToIcon9 = Chest.dresserTypeToIcon;
      int index51 = 8;
      Chest.dresserItemSpawn[8] = 2389;
      int num51 = 2389;
      dresserTypeToIcon9[index51] = num51;
      int[] dresserTypeToIcon10 = Chest.dresserTypeToIcon;
      int index52 = 9;
      Chest.dresserItemSpawn[9] = 2390;
      int num52 = 2390;
      dresserTypeToIcon10[index52] = num52;
      int[] dresserTypeToIcon11 = Chest.dresserTypeToIcon;
      int index53 = 10;
      Chest.dresserItemSpawn[10] = 2391;
      int num53 = 2391;
      dresserTypeToIcon11[index53] = num53;
      int[] dresserTypeToIcon12 = Chest.dresserTypeToIcon;
      int index54 = 11;
      Chest.dresserItemSpawn[11] = 2392;
      int num54 = 2392;
      dresserTypeToIcon12[index54] = num54;
      int[] dresserTypeToIcon13 = Chest.dresserTypeToIcon;
      int index55 = 12;
      Chest.dresserItemSpawn[12] = 2393;
      int num55 = 2393;
      dresserTypeToIcon13[index55] = num55;
      int[] dresserTypeToIcon14 = Chest.dresserTypeToIcon;
      int index56 = 13;
      Chest.dresserItemSpawn[13] = 2394;
      int num56 = 2394;
      dresserTypeToIcon14[index56] = num56;
      int[] dresserTypeToIcon15 = Chest.dresserTypeToIcon;
      int index57 = 14;
      Chest.dresserItemSpawn[14] = 2395;
      int num57 = 2395;
      dresserTypeToIcon15[index57] = num57;
      int[] dresserTypeToIcon16 = Chest.dresserTypeToIcon;
      int index58 = 15;
      Chest.dresserItemSpawn[15] = 2396;
      int num58 = 2396;
      dresserTypeToIcon16[index58] = num58;
      int[] dresserTypeToIcon17 = Chest.dresserTypeToIcon;
      int index59 = 16;
      Chest.dresserItemSpawn[16] = 2529;
      int num59 = 2529;
      dresserTypeToIcon17[index59] = num59;
      int[] dresserTypeToIcon18 = Chest.dresserTypeToIcon;
      int index60 = 17;
      Chest.dresserItemSpawn[17] = 2545;
      int num60 = 2545;
      dresserTypeToIcon18[index60] = num60;
      int[] dresserTypeToIcon19 = Chest.dresserTypeToIcon;
      int index61 = 18;
      Chest.dresserItemSpawn[18] = 2562;
      int num61 = 2562;
      dresserTypeToIcon19[index61] = num61;
      int[] dresserTypeToIcon20 = Chest.dresserTypeToIcon;
      int index62 = 19;
      Chest.dresserItemSpawn[19] = 2577;
      int num62 = 2577;
      dresserTypeToIcon20[index62] = num62;
      int[] dresserTypeToIcon21 = Chest.dresserTypeToIcon;
      int index63 = 20;
      Chest.dresserItemSpawn[20] = 2637;
      int num63 = 2637;
      dresserTypeToIcon21[index63] = num63;
      int[] dresserTypeToIcon22 = Chest.dresserTypeToIcon;
      int index64 = 21;
      Chest.dresserItemSpawn[21] = 2638;
      int num64 = 2638;
      dresserTypeToIcon22[index64] = num64;
      int[] dresserTypeToIcon23 = Chest.dresserTypeToIcon;
      int index65 = 22;
      Chest.dresserItemSpawn[22] = 2639;
      int num65 = 2639;
      dresserTypeToIcon23[index65] = num65;
      int[] dresserTypeToIcon24 = Chest.dresserTypeToIcon;
      int index66 = 23;
      Chest.dresserItemSpawn[23] = 2640;
      int num66 = 2640;
      dresserTypeToIcon24[index66] = num66;
      int[] dresserTypeToIcon25 = Chest.dresserTypeToIcon;
      int index67 = 24;
      Chest.dresserItemSpawn[24] = 2816;
      int num67 = 2816;
      dresserTypeToIcon25[index67] = num67;
      int[] dresserTypeToIcon26 = Chest.dresserTypeToIcon;
      int index68 = 25;
      Chest.dresserItemSpawn[25] = 3132;
      int num68 = 3132;
      dresserTypeToIcon26[index68] = num68;
      int[] dresserTypeToIcon27 = Chest.dresserTypeToIcon;
      int index69 = 26;
      Chest.dresserItemSpawn[26] = 3134;
      int num69 = 3134;
      dresserTypeToIcon27[index69] = num69;
      int[] dresserTypeToIcon28 = Chest.dresserTypeToIcon;
      int index70 = 27;
      Chest.dresserItemSpawn[27] = 3133;
      int num70 = 3133;
      dresserTypeToIcon28[index70] = num70;
    }

    private static bool IsPlayerInChest(int i)
    {
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        if (Main.player[index].chest == i)
          return true;
      }
      return false;
    }

    public static bool isLocked(int x, int y)
    {
      return Main.tile[x, y] == null || (int) Main.tile[x, y].frameX >= 72 && (int) Main.tile[x, y].frameX <= 106 || ((int) Main.tile[x, y].frameX >= 144 && (int) Main.tile[x, y].frameX <= 178 || (int) Main.tile[x, y].frameX >= 828 && (int) Main.tile[x, y].frameX <= 1006) || ((int) Main.tile[x, y].frameX >= 1296 && (int) Main.tile[x, y].frameX <= 1330 || (int) Main.tile[x, y].frameX >= 1368 && (int) Main.tile[x, y].frameX <= 1402 || (int) Main.tile[x, y].frameX >= 1440 && (int) Main.tile[x, y].frameX <= 1474);
    }

    public static void ServerPlaceItem(int plr, int slot)
    {
      Main.player[plr].inventory[slot] = Chest.PutItemInNearbyChest(Main.player[plr].inventory[slot], Main.player[plr].Center);
      NetMessage.SendData(5, -1, -1, "", plr, (float) slot, (float) Main.player[plr].inventory[slot].prefix, 0.0f, 0, 0, 0);
    }

    public static Item PutItemInNearbyChest(Item item, Vector2 position)
    {
      if (Main.netMode == 1)
        return item;
      for (int i = 0; i < 1000; ++i)
      {
        bool flag1 = false;
        bool flag2 = false;
        if (Main.chest[i] != null && !Chest.IsPlayerInChest(i) && !Chest.isLocked(Main.chest[i].x, Main.chest[i].y) && (double) (new Vector2((float) (Main.chest[i].x * 16 + 16), (float) (Main.chest[i].y * 16 + 16)) - position).Length() < 200.0)
        {
          for (int index = 0; index < Main.chest[i].item.Length; ++index)
          {
            if (Main.chest[i].item[index].type > 0 && Main.chest[i].item[index].stack > 0)
            {
              if (item.IsTheSameAs(Main.chest[i].item[index]))
              {
                flag1 = true;
                int num = Main.chest[i].item[index].maxStack - Main.chest[i].item[index].stack;
                if (num > 0)
                {
                  if (num > item.stack)
                    num = item.stack;
                  item.stack -= num;
                  Main.chest[i].item[index].stack += num;
                  if (item.stack <= 0)
                  {
                    item.SetDefaults(0, false);
                    return item;
                  }
                }
              }
            }
            else
              flag2 = true;
          }
          if (flag1 && flag2 && item.stack > 0)
          {
            for (int index = 0; index < Main.chest[i].item.Length; ++index)
            {
              if (Main.chest[i].item[index].type == 0 || Main.chest[i].item[index].stack == 0)
              {
                Main.chest[i].item[index] = item.Clone();
                item.SetDefaults(0, false);
                return item;
              }
            }
          }
        }
      }
      return item;
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }

    public static bool Unlock(int X, int Y)
    {
      if (Main.tile[X, Y] == null)
        return false;
      short num;
      int Type;
      switch ((int) Main.tile[X, Y].frameX / 36)
      {
        case 2:
          num = (short) 36;
          Type = 11;
          AchievementsHelper.NotifyProgressionEvent(19);
          break;
        case 4:
          num = (short) 36;
          Type = 11;
          break;
        case 23:
        case 24:
        case 25:
        case 26:
        case 27:
          if (!NPC.downedPlantBoss)
            return false;
          num = (short) 180;
          Type = 11;
          AchievementsHelper.NotifyProgressionEvent(20);
          break;
        case 36:
        case 38:
        case 40:
          num = (short) 36;
          Type = 11;
          break;
        default:
          return false;
      }
      Main.PlaySound(22, X * 16, Y * 16, 1, 1f, 0.0f);
      for (int index1 = X; index1 <= X + 1; ++index1)
      {
        for (int index2 = Y; index2 <= Y + 1; ++index2)
        {
          Main.tile[index1, index2].frameX -= num;
          for (int index3 = 0; index3 < 4; ++index3)
            Dust.NewDust(new Vector2((float) (index1 * 16), (float) (index2 * 16)), 16, 16, Type, 0.0f, 0.0f, 0, new Color(), 1f);
        }
      }
      return true;
    }

    public static int UsingChest(int i)
    {
      if (Main.chest[i] != null)
      {
        for (int index = 0; index < (int) byte.MaxValue; ++index)
        {
          if (Main.player[index].active && Main.player[index].chest == i)
            return index;
        }
      }
      return -1;
    }

    public static int FindChest(int X, int Y)
    {
      for (int index = 0; index < 1000; ++index)
      {
        if (Main.chest[index] != null && Main.chest[index].x == X && Main.chest[index].y == Y)
          return index;
      }
      return -1;
    }

    public static int FindEmptyChest(int x, int y, int type = 21, int style = 0, int direction = 1)
    {
      int num = -1;
      for (int index = 0; index < 1000; ++index)
      {
        Chest chest = Main.chest[index];
        if (chest != null)
        {
          if (chest.x == x && chest.y == y)
            return -1;
        }
        else if (num == -1)
          num = index;
      }
      return num;
    }

    public static bool NearOtherChests(int x, int y)
    {
      for (int i = x - 25; i < x + 25; ++i)
      {
        for (int j = y - 8; j < y + 8; ++j)
        {
          Tile tileSafely = Framing.GetTileSafely(i, j);
          if (tileSafely.active() && (int) tileSafely.type == 21)
            return true;
        }
      }
      return false;
    }

    public static int AfterPlacement_Hook(int x, int y, int type = 21, int style = 0, int direction = 1)
    {
      Point16 baseCoords = new Point16(x, y);
      TileObjectData.OriginToTopLeft(type, style, ref baseCoords);
      int emptyChest = Chest.FindEmptyChest((int) baseCoords.X, (int) baseCoords.Y, 21, 0, 1);
      if (emptyChest == -1)
        return -1;
      if (Main.netMode != 1)
      {
        Chest chest = new Chest(false);
        chest.x = (int) baseCoords.X;
        chest.y = (int) baseCoords.Y;
        for (int index = 0; index < 40; ++index)
          chest.item[index] = new Item();
        Main.chest[emptyChest] = chest;
      }
      else if (type == 21)
        NetMessage.SendData(34, -1, -1, "", 0, (float) x, (float) y, (float) style, 0, 0, 0);
      else
        NetMessage.SendData(34, -1, -1, "", 2, (float) x, (float) y, (float) style, 0, 0, 0);
      return emptyChest;
    }

    public static int CreateChest(int X, int Y, int id = -1)
    {
      int index1 = id;
      if (index1 == -1)
      {
        index1 = Chest.FindEmptyChest(X, Y, 21, 0, 1);
        if (index1 == -1)
          return -1;
        if (Main.netMode == 1)
          return index1;
      }
      Main.chest[index1] = new Chest(false);
      Main.chest[index1].x = X;
      Main.chest[index1].y = Y;
      for (int index2 = 0; index2 < 40; ++index2)
        Main.chest[index1].item[index2] = new Item();
      return index1;
    }

    public static bool CanDestroyChest(int X, int Y)
    {
      for (int index1 = 0; index1 < 1000; ++index1)
      {
        Chest chest = Main.chest[index1];
        if (chest != null && chest.x == X && chest.y == Y)
        {
          for (int index2 = 0; index2 < 40; ++index2)
          {
            if (chest.item[index2] != null && chest.item[index2].type > 0 && chest.item[index2].stack > 0)
              return false;
          }
          return true;
        }
      }
      return true;
    }

    public static bool DestroyChest(int X, int Y)
    {
      for (int index1 = 0; index1 < 1000; ++index1)
      {
        Chest chest = Main.chest[index1];
        if (chest != null && chest.x == X && chest.y == Y)
        {
          for (int index2 = 0; index2 < 40; ++index2)
          {
            if (chest.item[index2] != null && chest.item[index2].type > 0 && chest.item[index2].stack > 0)
              return false;
          }
          Main.chest[index1] = (Chest) null;
          if (Main.player[Main.myPlayer].chest == index1)
            Main.player[Main.myPlayer].chest = -1;
          Recipe.FindRecipes();
          return true;
        }
      }
      return true;
    }

    public static void DestroyChestDirect(int X, int Y, int id)
    {
      if (id < 0)
        return;
      if (id >= Main.chest.Length)
        return;
      try
      {
        Chest chest = Main.chest[id];
        if (chest == null || chest.x != X || chest.y != Y)
          return;
        Main.chest[id] = (Chest) null;
        if (Main.player[Main.myPlayer].chest == id)
          Main.player[Main.myPlayer].chest = -1;
        Recipe.FindRecipes();
      }
      catch
      {
      }
    }

    public void AddShop(Item newItem)
    {
      for (int index = 0; index < 39; ++index)
      {
        if (this.item[index] == null || this.item[index].type == 0)
        {
          this.item[index] = newItem.Clone();
          this.item[index].favorited = false;
          this.item[index].buyOnce = true;
          if (this.item[index].value <= 0)
            break;
          this.item[index].value = this.item[index].value / 5;
          if (this.item[index].value >= 1)
            break;
          this.item[index].value = 1;
          break;
        }
      }
    }

    public static void SetupTravelShop()
    {
      for (int index = 0; index < 40; ++index)
        Main.travelShop[index] = 0;
      int num1 = Main.rand.Next(4, 7);
      if (Main.rand.Next(4) == 0)
        ++num1;
      if (Main.rand.Next(8) == 0)
        ++num1;
      if (Main.rand.Next(16) == 0)
        ++num1;
      if (Main.rand.Next(32) == 0)
        ++num1;
      if (Main.expertMode && Main.rand.Next(2) == 0)
        ++num1;
      int index1 = 0;
      int num2 = 0;
      int[] numArray = new int[6]
      {
        100,
        200,
        300,
        400,
        500,
        600
      };
      while (num2 < num1)
      {
        int num3 = 0;
        if (Main.rand.Next(numArray[4]) == 0)
          num3 = 3309;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 3314;
        if (Main.rand.Next(numArray[5]) == 0)
          num3 = 1987;
        if (Main.rand.Next(numArray[4]) == 0 && Main.hardMode)
          num3 = 2270;
        if (Main.rand.Next(numArray[4]) == 0)
          num3 = 2278;
        if (Main.rand.Next(numArray[4]) == 0)
          num3 = 2271;
        if (Main.rand.Next(numArray[3]) == 0 && Main.hardMode && NPC.downedPlantBoss)
          num3 = 2223;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2272;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2219;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2276;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2284;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2285;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2286;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2287;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 2296;
        if (Main.rand.Next(numArray[3]) == 0)
          num3 = 3628;
        if (Main.rand.Next(numArray[2]) == 0 && WorldGen.shadowOrbSmashed)
          num3 = 2269;
        if (Main.rand.Next(numArray[2]) == 0)
          num3 = 2177;
        if (Main.rand.Next(numArray[2]) == 0)
          num3 = 1988;
        if (Main.rand.Next(numArray[2]) == 0)
          num3 = 2275;
        if (Main.rand.Next(numArray[2]) == 0)
          num3 = 2279;
        if (Main.rand.Next(numArray[2]) == 0)
          num3 = 2277;
        if (Main.rand.Next(numArray[2]) == 0 && NPC.downedBoss1)
          num3 = 3262;
        if (Main.rand.Next(numArray[2]) == 0 && NPC.downedMechBossAny)
          num3 = 3284;
        if (Main.rand.Next(numArray[2]) == 0 && Main.hardMode && NPC.downedMoonlord)
          num3 = 3596;
        if (Main.rand.Next(numArray[2]) == 0 && Main.hardMode && NPC.downedMartians)
          num3 = 2865;
        if (Main.rand.Next(numArray[2]) == 0 && Main.hardMode && NPC.downedMartians)
          num3 = 2866;
        if (Main.rand.Next(numArray[2]) == 0 && Main.hardMode && NPC.downedMartians)
          num3 = 2867;
        if (Main.rand.Next(numArray[2]) == 0 && Main.xMas)
          num3 = 3055;
        if (Main.rand.Next(numArray[2]) == 0 && Main.xMas)
          num3 = 3056;
        if (Main.rand.Next(numArray[2]) == 0 && Main.xMas)
          num3 = 3057;
        if (Main.rand.Next(numArray[2]) == 0 && Main.xMas)
          num3 = 3058;
        if (Main.rand.Next(numArray[2]) == 0 && Main.xMas)
          num3 = 3059;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 2214;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 2215;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 2216;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 2217;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 3624;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 2273;
        if (Main.rand.Next(numArray[1]) == 0)
          num3 = 2274;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2266;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2267;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2268;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2281 + Main.rand.Next(3);
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2258;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2242;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 2260;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 3637;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 3119;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 3118;
        if (Main.rand.Next(numArray[0]) == 0)
          num3 = 3099;
        if (num3 != 0)
        {
          for (int index2 = 0; index2 < 40; ++index2)
          {
            if (Main.travelShop[index2] != num3)
            {
              if (num3 == 3637)
              {
                switch (Main.travelShop[index2])
                {
                  case 3621:
                  case 3622:
                  case 3633:
                  case 3634:
                  case 3635:
                  case 3636:
                  case 3637:
                  case 3638:
                  case 3639:
                  case 3640:
                  case 3641:
                  case 3642:
                    num3 = 0;
                    break;
                }
                if (num3 == 0)
                  break;
              }
            }
            else
            {
              num3 = 0;
              break;
            }
          }
        }
        if (num3 != 0)
        {
          ++num2;
          Main.travelShop[index1] = num3;
          ++index1;
          if (num3 == 2260)
          {
            Main.travelShop[index1] = 2261;
            int index2 = index1 + 1;
            Main.travelShop[index2] = 2262;
            index1 = index2 + 1;
          }
          if (num3 == 3637)
          {
            --index1;
            switch (Main.rand.Next(6))
            {
              case 0:
                int[] travelShop1 = Main.travelShop;
                int index2 = index1;
                int num4 = 1;
                int num5 = index2 + num4;
                int num6 = 3637;
                travelShop1[index2] = num6;
                int[] travelShop2 = Main.travelShop;
                int index3 = num5;
                int num7 = 1;
                index1 = index3 + num7;
                int num8 = 3642;
                travelShop2[index3] = num8;
                continue;
              case 1:
                int[] travelShop3 = Main.travelShop;
                int index4 = index1;
                int num9 = 1;
                int num10 = index4 + num9;
                int num11 = 3621;
                travelShop3[index4] = num11;
                int[] travelShop4 = Main.travelShop;
                int index5 = num10;
                int num12 = 1;
                index1 = index5 + num12;
                int num13 = 3622;
                travelShop4[index5] = num13;
                continue;
              case 2:
                int[] travelShop5 = Main.travelShop;
                int index6 = index1;
                int num14 = 1;
                int num15 = index6 + num14;
                int num16 = 3634;
                travelShop5[index6] = num16;
                int[] travelShop6 = Main.travelShop;
                int index7 = num15;
                int num17 = 1;
                index1 = index7 + num17;
                int num18 = 3639;
                travelShop6[index7] = num18;
                continue;
              case 3:
                int[] travelShop7 = Main.travelShop;
                int index8 = index1;
                int num19 = 1;
                int num20 = index8 + num19;
                int num21 = 3633;
                travelShop7[index8] = num21;
                int[] travelShop8 = Main.travelShop;
                int index9 = num20;
                int num22 = 1;
                index1 = index9 + num22;
                int num23 = 3638;
                travelShop8[index9] = num23;
                continue;
              case 4:
                int[] travelShop9 = Main.travelShop;
                int index10 = index1;
                int num24 = 1;
                int num25 = index10 + num24;
                int num26 = 3635;
                travelShop9[index10] = num26;
                int[] travelShop10 = Main.travelShop;
                int index11 = num25;
                int num27 = 1;
                index1 = index11 + num27;
                int num28 = 3640;
                travelShop10[index11] = num28;
                continue;
              case 5:
                int[] travelShop11 = Main.travelShop;
                int index12 = index1;
                int num29 = 1;
                int num30 = index12 + num29;
                int num31 = 3636;
                travelShop11[index12] = num31;
                int[] travelShop12 = Main.travelShop;
                int index13 = num30;
                int num32 = 1;
                index1 = index13 + num32;
                int num33 = 3641;
                travelShop12[index13] = num33;
                continue;
              default:
                continue;
            }
          }
        }
      }
    }

    public void SetupShop(int type)
    {
      for (int index = 0; index < 40; ++index)
        this.item[index] = new Item();
      int index1 = 0;
      if (type == 1)
      {
        this.item[index1].SetDefaults("Mining Helmet");
        int index2 = index1 + 1;
        this.item[index2].SetDefaults("Piggy Bank");
        int index3 = index2 + 1;
        this.item[index3].SetDefaults("Iron Anvil");
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(1991, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults("Copper Pickaxe");
        int index6 = index5 + 1;
        this.item[index6].SetDefaults("Copper Axe");
        int index7 = index6 + 1;
        this.item[index7].SetDefaults("Torch");
        int index8 = index7 + 1;
        this.item[index8].SetDefaults("Lesser Healing Potion");
        int index9 = index8 + 1;
        this.item[index9].SetDefaults("Lesser Mana Potion");
        int index10 = index9 + 1;
        this.item[index10].SetDefaults("Wooden Arrow");
        int index11 = index10 + 1;
        this.item[index11].SetDefaults("Shuriken");
        int index12 = index11 + 1;
        this.item[index12].SetDefaults("Rope");
        int index13 = index12 + 1;
        if (Main.player[Main.myPlayer].ZoneSnow)
        {
          this.item[index13].SetDefaults(967, false);
          ++index13;
        }
        if (Main.bloodMoon)
        {
          this.item[index13].SetDefaults("Throwing Knife");
          ++index13;
        }
        if (!Main.dayTime)
        {
          this.item[index13].SetDefaults("Glowstick");
          ++index13;
        }
        if (NPC.downedBoss3)
        {
          this.item[index13].SetDefaults("Safe");
          ++index13;
        }
        if (Main.hardMode)
        {
          this.item[index13].SetDefaults(488, false);
          ++index13;
        }
        for (int index14 = 0; index14 < 58; ++index14)
        {
          if (Main.player[Main.myPlayer].inventory[index14].type == 930)
          {
            this.item[index13].SetDefaults(931, false);
            int index15 = index13 + 1;
            this.item[index15].SetDefaults(1614, false);
            index13 = index15 + 1;
            break;
          }
        }
        this.item[index13].SetDefaults(1786, false);
        index1 = index13 + 1;
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(1348, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(3107))
        {
          this.item[index1].SetDefaults(3108, false);
          ++index1;
        }
        if (Main.halloween)
        {
          Item[] objArray1 = this.item;
          int index14 = index1;
          int num1 = 1;
          int num2 = index14 + num1;
          objArray1[index14].SetDefaults(3242, false);
          Item[] objArray2 = this.item;
          int index15 = num2;
          int num3 = 1;
          int num4 = index15 + num3;
          objArray2[index15].SetDefaults(3243, false);
          Item[] objArray3 = this.item;
          int index16 = num4;
          int num5 = 1;
          index1 = index16 + num5;
          objArray3[index16].SetDefaults(3244, false);
        }
      }
      else if (type == 2)
      {
        this.item[index1].SetDefaults("Musket Ball");
        int index2 = index1 + 1;
        if (Main.bloodMoon || Main.hardMode)
        {
          this.item[index2].SetDefaults("Silver Bullet");
          ++index2;
        }
        if (NPC.downedBoss2 && !Main.dayTime || Main.hardMode)
        {
          this.item[index2].SetDefaults(47, false);
          ++index2;
        }
        this.item[index2].SetDefaults("Flintlock Pistol");
        int index3 = index2 + 1;
        this.item[index3].SetDefaults("Minishark");
        index1 = index3 + 1;
        if (!Main.dayTime)
        {
          this.item[index1].SetDefaults(324, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(534, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(1432, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1258))
        {
          this.item[index1].SetDefaults(1261, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1835))
        {
          this.item[index1].SetDefaults(1836, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(3107))
        {
          this.item[index1].SetDefaults(3108, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1782))
        {
          this.item[index1].SetDefaults(1783, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1784))
        {
          this.item[index1].SetDefaults(1785, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1736, false);
          int index4 = index1 + 1;
          this.item[index4].SetDefaults(1737, false);
          int index5 = index4 + 1;
          this.item[index5].SetDefaults(1738, false);
          index1 = index5 + 1;
        }
      }
      else if (type == 3)
      {
        int index2;
        if (Main.bloodMoon)
        {
          if (WorldGen.crimson)
          {
            this.item[index1].SetDefaults(2886, false);
            int index3 = index1 + 1;
            this.item[index3].SetDefaults(2171, false);
            index2 = index3 + 1;
          }
          else
          {
            this.item[index1].SetDefaults(67, false);
            int index3 = index1 + 1;
            this.item[index3].SetDefaults(59, false);
            index2 = index3 + 1;
          }
        }
        else
        {
          this.item[index1].SetDefaults("Purification Powder");
          int index3 = index1 + 1;
          this.item[index3].SetDefaults("Grass Seeds");
          int index4 = index3 + 1;
          this.item[index4].SetDefaults("Sunflower");
          index2 = index4 + 1;
        }
        this.item[index2].SetDefaults("Acorn");
        int index5 = index2 + 1;
        this.item[index5].SetDefaults(114, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(1828, false);
        int index7 = index6 + 1;
        this.item[index7].SetDefaults(745, false);
        int index8 = index7 + 1;
        this.item[index8].SetDefaults(747, false);
        index1 = index8 + 1;
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(746, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(369, false);
          ++index1;
        }
        if (Main.shroomTiles > 50)
        {
          this.item[index1].SetDefaults(194, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1853, false);
          int index3 = index1 + 1;
          this.item[index3].SetDefaults(1854, false);
          index1 = index3 + 1;
        }
        if (NPC.downedSlimeKing)
        {
          this.item[index1].SetDefaults(3215, false);
          ++index1;
        }
        if (NPC.downedQueenBee)
        {
          this.item[index1].SetDefaults(3216, false);
          ++index1;
        }
        if (NPC.downedBoss1)
        {
          this.item[index1].SetDefaults(3219, false);
          ++index1;
        }
        if (NPC.downedBoss2)
        {
          if (WorldGen.crimson)
          {
            this.item[index1].SetDefaults(3218, false);
            ++index1;
          }
          else
          {
            this.item[index1].SetDefaults(3217, false);
            ++index1;
          }
        }
        if (NPC.downedBoss3)
        {
          this.item[index1].SetDefaults(3220, false);
          int index3 = index1 + 1;
          this.item[index3].SetDefaults(3221, false);
          index1 = index3 + 1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(3222, false);
          ++index1;
        }
      }
      else if (type == 4)
      {
        this.item[index1].SetDefaults("Grenade");
        int index2 = index1 + 1;
        this.item[index2].SetDefaults("Bomb");
        int index3 = index2 + 1;
        this.item[index3].SetDefaults("Dynamite");
        index1 = index3 + 1;
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults("Hellfire Arrow");
          ++index1;
        }
        if (Main.hardMode && NPC.downedPlantBoss && NPC.downedPirates)
        {
          this.item[index1].SetDefaults(937, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(1347, false);
          ++index1;
        }
      }
      else if (type == 5)
      {
        this.item[index1].SetDefaults(254, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(981, false);
        int index3 = index2 + 1;
        if (Main.dayTime)
        {
          this.item[index3].SetDefaults(242, false);
          ++index3;
        }
        if (Main.moonPhase == 0)
        {
          this.item[index3].SetDefaults(245, false);
          int index4 = index3 + 1;
          this.item[index4].SetDefaults(246, false);
          index3 = index4 + 1;
          if (!Main.dayTime)
          {
            Item[] objArray1 = this.item;
            int index5 = index3;
            int num1 = 1;
            int num2 = index5 + num1;
            objArray1[index5].SetDefaults(1288, false);
            Item[] objArray2 = this.item;
            int index6 = num2;
            int num3 = 1;
            index3 = index6 + num3;
            objArray2[index6].SetDefaults(1289, false);
          }
        }
        else if (Main.moonPhase == 1)
        {
          this.item[index3].SetDefaults(325, false);
          int index4 = index3 + 1;
          this.item[index4].SetDefaults(326, false);
          index3 = index4 + 1;
        }
        this.item[index3].SetDefaults(269, false);
        int index7 = index3 + 1;
        this.item[index7].SetDefaults(270, false);
        int index8 = index7 + 1;
        this.item[index8].SetDefaults(271, false);
        index1 = index8 + 1;
        if (NPC.downedClown)
        {
          this.item[index1].SetDefaults(503, false);
          int index4 = index1 + 1;
          this.item[index4].SetDefaults(504, false);
          int index5 = index4 + 1;
          this.item[index5].SetDefaults(505, false);
          index1 = index5 + 1;
        }
        if (Main.bloodMoon)
        {
          this.item[index1].SetDefaults(322, false);
          ++index1;
          if (!Main.dayTime)
          {
            Item[] objArray1 = this.item;
            int index4 = index1;
            int num1 = 1;
            int num2 = index4 + num1;
            objArray1[index4].SetDefaults(3362, false);
            Item[] objArray2 = this.item;
            int index5 = num2;
            int num3 = 1;
            index1 = index5 + num3;
            objArray2[index5].SetDefaults(3363, false);
          }
        }
        if (NPC.downedAncientCultist)
        {
          if (Main.dayTime)
          {
            Item[] objArray1 = this.item;
            int index4 = index1;
            int num1 = 1;
            int num2 = index4 + num1;
            objArray1[index4].SetDefaults(2856, false);
            Item[] objArray2 = this.item;
            int index5 = num2;
            int num3 = 1;
            index1 = index5 + num3;
            objArray2[index5].SetDefaults(2858, false);
          }
          else
          {
            Item[] objArray1 = this.item;
            int index4 = index1;
            int num1 = 1;
            int num2 = index4 + num1;
            objArray1[index4].SetDefaults(2857, false);
            Item[] objArray2 = this.item;
            int index5 = num2;
            int num3 = 1;
            index1 = index5 + num3;
            objArray2[index5].SetDefaults(2859, false);
          }
        }
        if (NPC.AnyNPCs(441))
        {
          Item[] objArray1 = this.item;
          int index4 = index1;
          int num1 = 1;
          int num2 = index4 + num1;
          objArray1[index4].SetDefaults(3242, false);
          Item[] objArray2 = this.item;
          int index5 = num2;
          int num3 = 1;
          int num4 = index5 + num3;
          objArray2[index5].SetDefaults(3243, false);
          Item[] objArray3 = this.item;
          int index6 = num4;
          int num5 = 1;
          index1 = index6 + num5;
          objArray3[index6].SetDefaults(3244, false);
        }
        if (Main.player[Main.myPlayer].ZoneSnow)
        {
          this.item[index1].SetDefaults(1429, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1740, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          if (Main.moonPhase == 2)
          {
            this.item[index1].SetDefaults(869, false);
            ++index1;
          }
          if (Main.moonPhase == 4)
          {
            this.item[index1].SetDefaults(864, false);
            int index4 = index1 + 1;
            this.item[index4].SetDefaults(865, false);
            index1 = index4 + 1;
          }
          if (Main.moonPhase == 6)
          {
            this.item[index1].SetDefaults(873, false);
            int index4 = index1 + 1;
            this.item[index4].SetDefaults(874, false);
            int index5 = index4 + 1;
            this.item[index5].SetDefaults(875, false);
            index1 = index5 + 1;
          }
        }
        if (NPC.downedFrost)
        {
          this.item[index1].SetDefaults(1275, false);
          int index4 = index1 + 1;
          this.item[index4].SetDefaults(1276, false);
          index1 = index4 + 1;
        }
        if (Main.halloween)
        {
          Item[] objArray1 = this.item;
          int index4 = index1;
          int num1 = 1;
          int num2 = index4 + num1;
          objArray1[index4].SetDefaults(3246, false);
          Item[] objArray2 = this.item;
          int index5 = num2;
          int num3 = 1;
          index1 = index5 + num3;
          objArray2[index5].SetDefaults(3247, false);
        }
        if (BirthdayParty.PartyIsUp)
        {
          Item[] objArray1 = this.item;
          int index4 = index1;
          int num1 = 1;
          int num2 = index4 + num1;
          objArray1[index4].SetDefaults(3730, false);
          Item[] objArray2 = this.item;
          int index5 = num2;
          int num3 = 1;
          int num4 = index5 + num3;
          objArray2[index5].SetDefaults(3731, false);
          Item[] objArray3 = this.item;
          int index6 = num4;
          int num5 = 1;
          int num6 = index6 + num5;
          objArray3[index6].SetDefaults(3733, false);
          Item[] objArray4 = this.item;
          int index9 = num6;
          int num7 = 1;
          int num8 = index9 + num7;
          objArray4[index9].SetDefaults(3734, false);
          Item[] objArray5 = this.item;
          int index10 = num8;
          int num9 = 1;
          index1 = index10 + num9;
          objArray5[index10].SetDefaults(3735, false);
        }
      }
      else if (type == 6)
      {
        this.item[index1].SetDefaults(128, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(486, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(398, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(84, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(407, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(161, false);
        index1 = index6 + 1;
      }
      else if (type == 7)
      {
        this.item[index1].SetDefaults(487, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(496, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(500, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(507, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(508, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(531, false);
        int index7 = index6 + 1;
        this.item[index7].SetDefaults(576, false);
        int index8 = index7 + 1;
        this.item[index8].SetDefaults(3186, false);
        index1 = index8 + 1;
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1739, false);
          ++index1;
        }
      }
      else if (type == 8)
      {
        this.item[index1].SetDefaults(509, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(850, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(851, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(3612, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(510, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(530, false);
        int index7 = index6 + 1;
        this.item[index7].SetDefaults(513, false);
        int index8 = index7 + 1;
        this.item[index8].SetDefaults(538, false);
        int index9 = index8 + 1;
        this.item[index9].SetDefaults(529, false);
        int index10 = index9 + 1;
        this.item[index10].SetDefaults(541, false);
        int index11 = index10 + 1;
        this.item[index11].SetDefaults(542, false);
        int index12 = index11 + 1;
        this.item[index12].SetDefaults(543, false);
        int index13 = index12 + 1;
        this.item[index13].SetDefaults(852, false);
        int index14 = index13 + 1;
        this.item[index14].SetDefaults(853, false);
        int num1 = index14 + 1;
        Item[] objArray1 = this.item;
        int index15 = num1;
        int num2 = 1;
        int index16 = index15 + num2;
        objArray1[index15].SetDefaults(3707, false);
        this.item[index16].SetDefaults(2739, false);
        int index17 = index16 + 1;
        this.item[index17].SetDefaults(849, false);
        int num3 = index17 + 1;
        Item[] objArray2 = this.item;
        int index18 = num3;
        int num4 = 1;
        int num5 = index18 + num4;
        objArray2[index18].SetDefaults(3616, false);
        Item[] objArray3 = this.item;
        int index19 = num5;
        int num6 = 1;
        int num7 = index19 + num6;
        objArray3[index19].SetDefaults(2799, false);
        Item[] objArray4 = this.item;
        int index20 = num7;
        int num8 = 1;
        int num9 = index20 + num8;
        objArray4[index20].SetDefaults(3619, false);
        Item[] objArray5 = this.item;
        int index21 = num9;
        int num10 = 1;
        int num11 = index21 + num10;
        objArray5[index21].SetDefaults(3627, false);
        Item[] objArray6 = this.item;
        int index22 = num11;
        int num12 = 1;
        index1 = index22 + num12;
        objArray6[index22].SetDefaults(3629, false);
        if (NPC.AnyNPCs(369) && Main.hardMode && Main.moonPhase == 3)
        {
          this.item[index1].SetDefaults(2295, false);
          ++index1;
        }
      }
      else if (type == 9)
      {
        this.item[index1].SetDefaults(588, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(589, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(590, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(597, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(598, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(596, false);
        index1 = index6 + 1;
        for (int Type = 1873; Type < 1906; ++Type)
        {
          this.item[index1].SetDefaults(Type, false);
          ++index1;
        }
      }
      else if (type == 10)
      {
        if (NPC.downedMechBossAny)
        {
          this.item[index1].SetDefaults(756, false);
          int index2 = index1 + 1;
          this.item[index2].SetDefaults(787, false);
          index1 = index2 + 1;
        }
        this.item[index1].SetDefaults(868, false);
        int index3 = index1 + 1;
        if (NPC.downedPlantBoss)
        {
          this.item[index3].SetDefaults(1551, false);
          ++index3;
        }
        this.item[index3].SetDefaults(1181, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(783, false);
        index1 = index4 + 1;
      }
      else if (type == 11)
      {
        this.item[index1].SetDefaults(779, false);
        int index2 = index1 + 1;
        int index3;
        if (Main.moonPhase >= 4)
        {
          this.item[index2].SetDefaults(748, false);
          index3 = index2 + 1;
        }
        else
        {
          this.item[index2].SetDefaults(839, false);
          int index4 = index2 + 1;
          this.item[index4].SetDefaults(840, false);
          int index5 = index4 + 1;
          this.item[index5].SetDefaults(841, false);
          index3 = index5 + 1;
        }
        if (NPC.downedGolemBoss)
        {
          this.item[index3].SetDefaults(948, false);
          ++index3;
        }
        Item[] objArray1 = this.item;
        int index6 = index3;
        int num1 = 1;
        int num2 = index6 + num1;
        objArray1[index6].SetDefaults(3623, false);
        Item[] objArray2 = this.item;
        int index7 = num2;
        int num3 = 1;
        int num4 = index7 + num3;
        objArray2[index7].SetDefaults(3603, false);
        Item[] objArray3 = this.item;
        int index8 = num4;
        int num5 = 1;
        int num6 = index8 + num5;
        objArray3[index8].SetDefaults(3604, false);
        Item[] objArray4 = this.item;
        int index9 = num6;
        int num7 = 1;
        int num8 = index9 + num7;
        objArray4[index9].SetDefaults(3607, false);
        Item[] objArray5 = this.item;
        int index10 = num8;
        int num9 = 1;
        int num10 = index10 + num9;
        objArray5[index10].SetDefaults(3605, false);
        Item[] objArray6 = this.item;
        int index11 = num10;
        int num11 = 1;
        int num12 = index11 + num11;
        objArray6[index11].SetDefaults(3606, false);
        Item[] objArray7 = this.item;
        int index12 = num12;
        int num13 = 1;
        int num14 = index12 + num13;
        objArray7[index12].SetDefaults(3608, false);
        Item[] objArray8 = this.item;
        int index13 = num14;
        int num15 = 1;
        int num16 = index13 + num15;
        objArray8[index13].SetDefaults(3618, false);
        Item[] objArray9 = this.item;
        int index14 = num16;
        int num17 = 1;
        int num18 = index14 + num17;
        objArray9[index14].SetDefaults(3602, false);
        Item[] objArray10 = this.item;
        int index15 = num18;
        int num19 = 1;
        int num20 = index15 + num19;
        objArray10[index15].SetDefaults(3663, false);
        Item[] objArray11 = this.item;
        int index16 = num20;
        int num21 = 1;
        int num22 = index16 + num21;
        objArray11[index16].SetDefaults(3609, false);
        Item[] objArray12 = this.item;
        int index17 = num22;
        int num23 = 1;
        int index18 = index17 + num23;
        objArray12[index17].SetDefaults(3610, false);
        this.item[index18].SetDefaults(995, false);
        int index19 = index18 + 1;
        if (NPC.downedBoss1 && NPC.downedBoss2 && NPC.downedBoss3)
        {
          this.item[index19].SetDefaults(2203, false);
          ++index19;
        }
        if (WorldGen.crimson)
        {
          this.item[index19].SetDefaults(2193, false);
          ++index19;
        }
        this.item[index19].SetDefaults(1263, false);
        int index20 = index19 + 1;
        if (!Main.eclipse && !Main.bloodMoon)
        {
          if (Main.player[Main.myPlayer].ZoneHoly)
          {
            this.item[index20].SetDefaults(781, false);
            index1 = index20 + 1;
          }
          else
          {
            this.item[index20].SetDefaults(780, false);
            index1 = index20 + 1;
          }
        }
        else if (WorldGen.crimson)
        {
          this.item[index20].SetDefaults(784, false);
          index1 = index20 + 1;
        }
        else
        {
          this.item[index20].SetDefaults(782, false);
          index1 = index20 + 1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(1344, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1742, false);
          ++index1;
        }
      }
      else if (type == 12)
      {
        this.item[index1].SetDefaults(1037, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(2874, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(1120, false);
        index1 = index3 + 1;
        if (Main.netMode == 1)
        {
          this.item[index1].SetDefaults(1969, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(3248, false);
          int index4 = index1 + 1;
          this.item[index4].SetDefaults(1741, false);
          index1 = index4 + 1;
        }
        if (Main.moonPhase == 0)
        {
          this.item[index1].SetDefaults(2871, false);
          int index4 = index1 + 1;
          this.item[index4].SetDefaults(2872, false);
          index1 = index4 + 1;
        }
      }
      else if (type == 13)
      {
        this.item[index1].SetDefaults(859, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(1000, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(1168, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(1449, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(1345, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(1450, false);
        int num1 = index6 + 1;
        Item[] objArray1 = this.item;
        int index7 = num1;
        int num2 = 1;
        int num3 = index7 + num2;
        objArray1[index7].SetDefaults(3253, false);
        Item[] objArray2 = this.item;
        int index8 = num3;
        int num4 = 1;
        int num5 = index8 + num4;
        objArray2[index8].SetDefaults(2700, false);
        Item[] objArray3 = this.item;
        int index9 = num5;
        int num6 = 1;
        int index10 = index9 + num6;
        objArray3[index9].SetDefaults(2738, false);
        if (Main.player[Main.myPlayer].HasItem(3548))
        {
          this.item[index10].SetDefaults(3548, false);
          ++index10;
        }
        if (NPC.AnyNPCs(229))
          this.item[index10++].SetDefaults(3369, false);
        if (Main.hardMode)
        {
          this.item[index10].SetDefaults(3214, false);
          int index11 = index10 + 1;
          this.item[index11].SetDefaults(2868, false);
          int index12 = index11 + 1;
          this.item[index12].SetDefaults(970, false);
          int index13 = index12 + 1;
          this.item[index13].SetDefaults(971, false);
          int index14 = index13 + 1;
          this.item[index14].SetDefaults(972, false);
          int index15 = index14 + 1;
          this.item[index15].SetDefaults(973, false);
          index10 = index15 + 1;
        }
        Item[] objArray4 = this.item;
        int index16 = index10;
        int num7 = 1;
        int num8 = index16 + num7;
        objArray4[index16].SetDefaults(3747, false);
        Item[] objArray5 = this.item;
        int index17 = num8;
        int num9 = 1;
        int num10 = index17 + num9;
        objArray5[index17].SetDefaults(3732, false);
        Item[] objArray6 = this.item;
        int index18 = num10;
        int num11 = 1;
        index1 = index18 + num11;
        objArray6[index18].SetDefaults(3742, false);
        if (BirthdayParty.PartyIsUp)
        {
          Item[] objArray7 = this.item;
          int index11 = index1;
          int num12 = 1;
          int num13 = index11 + num12;
          objArray7[index11].SetDefaults(3749, false);
          Item[] objArray8 = this.item;
          int index12 = num13;
          int num14 = 1;
          int num15 = index12 + num14;
          objArray8[index12].SetDefaults(3746, false);
          Item[] objArray9 = this.item;
          int index13 = num15;
          int num16 = 1;
          int num17 = index13 + num16;
          objArray9[index13].SetDefaults(3739, false);
          Item[] objArray10 = this.item;
          int index14 = num17;
          int num18 = 1;
          int num19 = index14 + num18;
          objArray10[index14].SetDefaults(3740, false);
          Item[] objArray11 = this.item;
          int index15 = num19;
          int num20 = 1;
          int num21 = index15 + num20;
          objArray11[index15].SetDefaults(3741, false);
          Item[] objArray12 = this.item;
          int index19 = num21;
          int num22 = 1;
          int num23 = index19 + num22;
          objArray12[index19].SetDefaults(3737, false);
          Item[] objArray13 = this.item;
          int index20 = num23;
          int num24 = 1;
          int num25 = index20 + num24;
          objArray13[index20].SetDefaults(3738, false);
          Item[] objArray14 = this.item;
          int index21 = num25;
          int num26 = 1;
          int num27 = index21 + num26;
          objArray14[index21].SetDefaults(3736, false);
          Item[] objArray15 = this.item;
          int index22 = num27;
          int num28 = 1;
          int num29 = index22 + num28;
          objArray15[index22].SetDefaults(3745, false);
          Item[] objArray16 = this.item;
          int index23 = num29;
          int num30 = 1;
          int num31 = index23 + num30;
          objArray16[index23].SetDefaults(3744, false);
          Item[] objArray17 = this.item;
          int index24 = num31;
          int num32 = 1;
          index1 = index24 + num32;
          objArray17[index24].SetDefaults(3743, false);
        }
      }
      else if (type == 14)
      {
        this.item[index1].SetDefaults(771, false);
        ++index1;
        if (Main.bloodMoon)
        {
          this.item[index1].SetDefaults(772, false);
          ++index1;
        }
        if (!Main.dayTime || Main.eclipse)
        {
          this.item[index1].SetDefaults(773, false);
          ++index1;
        }
        if (Main.eclipse)
        {
          this.item[index1].SetDefaults(774, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(760, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(1346, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1743, false);
          int index2 = index1 + 1;
          this.item[index2].SetDefaults(1744, false);
          int index3 = index2 + 1;
          this.item[index3].SetDefaults(1745, false);
          index1 = index3 + 1;
        }
        if (NPC.downedMartians)
        {
          Item[] objArray1 = this.item;
          int index2 = index1;
          int num1 = 1;
          int num2 = index2 + num1;
          objArray1[index2].SetDefaults(2862, false);
          Item[] objArray2 = this.item;
          int index3 = num2;
          int num3 = 1;
          index1 = index3 + num3;
          objArray2[index3].SetDefaults(3109, false);
        }
        if (Main.player[Main.myPlayer].HasItem(3384) || Main.player[Main.myPlayer].HasItem(3664))
        {
          this.item[index1].SetDefaults(3664, false);
          ++index1;
        }
      }
      else if (type == 15)
      {
        this.item[index1].SetDefaults(1071, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(1072, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(1100, false);
        int index4 = index3 + 1;
        for (int Type = 1073; Type <= 1084; ++Type)
        {
          this.item[index4].SetDefaults(Type, false);
          ++index4;
        }
        this.item[index4].SetDefaults(1097, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(1099, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(1098, false);
        int index7 = index6 + 1;
        this.item[index7].SetDefaults(1966, false);
        int index8 = index7 + 1;
        if (Main.hardMode)
        {
          this.item[index8].SetDefaults(1967, false);
          int index9 = index8 + 1;
          this.item[index9].SetDefaults(1968, false);
          index8 = index9 + 1;
        }
        this.item[index8].SetDefaults(1490, false);
        int index10 = index8 + 1;
        if (Main.moonPhase <= 1)
        {
          this.item[index10].SetDefaults(1481, false);
          index1 = index10 + 1;
        }
        else if (Main.moonPhase <= 3)
        {
          this.item[index10].SetDefaults(1482, false);
          index1 = index10 + 1;
        }
        else if (Main.moonPhase <= 5)
        {
          this.item[index10].SetDefaults(1483, false);
          index1 = index10 + 1;
        }
        else
        {
          this.item[index10].SetDefaults(1484, false);
          index1 = index10 + 1;
        }
        if (Main.player[Main.myPlayer].ZoneCrimson)
        {
          this.item[index1].SetDefaults(1492, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneCorrupt)
        {
          this.item[index1].SetDefaults(1488, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneHoly)
        {
          this.item[index1].SetDefaults(1489, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneJungle)
        {
          this.item[index1].SetDefaults(1486, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneSnow)
        {
          this.item[index1].SetDefaults(1487, false);
          ++index1;
        }
        if (Main.sandTiles > 1000)
        {
          this.item[index1].SetDefaults(1491, false);
          ++index1;
        }
        if (Main.bloodMoon)
        {
          this.item[index1].SetDefaults(1493, false);
          ++index1;
        }
        if ((double) Main.player[Main.myPlayer].position.Y / 16.0 < Main.worldSurface * 0.349999994039536)
        {
          this.item[index1].SetDefaults(1485, false);
          ++index1;
        }
        if ((double) Main.player[Main.myPlayer].position.Y / 16.0 < Main.worldSurface * 0.349999994039536 && Main.hardMode)
        {
          this.item[index1].SetDefaults(1494, false);
          ++index1;
        }
        if (Main.xMas)
        {
          for (int Type = 1948; Type <= 1957; ++Type)
          {
            this.item[index1].SetDefaults(Type, false);
            ++index1;
          }
        }
        for (int Type = 2158; Type <= 2160; ++Type)
        {
          if (index1 < 39)
            this.item[index1].SetDefaults(Type, false);
          ++index1;
        }
        for (int Type = 2008; Type <= 2014; ++Type)
        {
          if (index1 < 39)
            this.item[index1].SetDefaults(Type, false);
          ++index1;
        }
      }
      else if (type == 16)
      {
        this.item[index1].SetDefaults(1430, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(986, false);
        int index3 = index2 + 1;
        if (NPC.AnyNPCs(108))
          this.item[index3++].SetDefaults(2999, false);
        if (Main.hardMode && NPC.downedPlantBoss)
        {
          if (Main.player[Main.myPlayer].HasItem(1157))
          {
            this.item[index3].SetDefaults(1159, false);
            int index4 = index3 + 1;
            this.item[index4].SetDefaults(1160, false);
            int index5 = index4 + 1;
            this.item[index5].SetDefaults(1161, false);
            index3 = index5 + 1;
            if (!Main.dayTime)
            {
              this.item[index3].SetDefaults(1158, false);
              ++index3;
            }
            if (Main.player[Main.myPlayer].ZoneJungle)
            {
              this.item[index3].SetDefaults(1167, false);
              ++index3;
            }
          }
          this.item[index3].SetDefaults(1339, false);
          ++index3;
        }
        if (Main.hardMode && Main.player[Main.myPlayer].ZoneJungle)
        {
          this.item[index3].SetDefaults(1171, false);
          ++index3;
          if (!Main.dayTime)
          {
            this.item[index3].SetDefaults(1162, false);
            ++index3;
          }
        }
        this.item[index3].SetDefaults(909, false);
        int index6 = index3 + 1;
        this.item[index6].SetDefaults(910, false);
        int index7 = index6 + 1;
        this.item[index7].SetDefaults(940, false);
        int index8 = index7 + 1;
        this.item[index8].SetDefaults(941, false);
        int index9 = index8 + 1;
        this.item[index9].SetDefaults(942, false);
        int index10 = index9 + 1;
        this.item[index10].SetDefaults(943, false);
        int index11 = index10 + 1;
        this.item[index11].SetDefaults(944, false);
        int index12 = index11 + 1;
        this.item[index12].SetDefaults(945, false);
        index1 = index12 + 1;
        if (Main.player[Main.myPlayer].HasItem(1835))
        {
          this.item[index1].SetDefaults(1836, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1258))
        {
          this.item[index1].SetDefaults(1261, false);
          ++index1;
        }
        if (Main.halloween)
        {
          this.item[index1].SetDefaults(1791, false);
          ++index1;
        }
      }
      else if (type == 17)
      {
        this.item[index1].SetDefaults(928, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(929, false);
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(876, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(877, false);
        int index5 = index4 + 1;
        this.item[index5].SetDefaults(878, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(2434, false);
        index1 = index6 + 1;
        int num = (int) (((double) Main.screenPosition.X + (double) (Main.screenWidth / 2)) / 16.0);
        if ((double) Main.screenPosition.Y / 16.0 < Main.worldSurface + 10.0 && (num < 380 || num > Main.maxTilesX - 380))
        {
          this.item[index1].SetDefaults(1180, false);
          ++index1;
        }
        if (Main.hardMode && NPC.downedMechBossAny && NPC.AnyNPCs(208))
        {
          this.item[index1].SetDefaults(1337, false);
          ++index1;
        }
      }
      else if (type == 18)
      {
        this.item[index1].SetDefaults(1990, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(1979, false);
        index1 = index2 + 1;
        if (Main.player[Main.myPlayer].statLifeMax >= 400)
        {
          this.item[index1].SetDefaults(1977, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].statManaMax >= 200)
        {
          this.item[index1].SetDefaults(1978, false);
          ++index1;
        }
        long num = 0;
        for (int index3 = 0; index3 < 54; ++index3)
        {
          if (Main.player[Main.myPlayer].inventory[index3].type == 71)
            num += (long) Main.player[Main.myPlayer].inventory[index3].stack;
          if (Main.player[Main.myPlayer].inventory[index3].type == 72)
            num += (long) (Main.player[Main.myPlayer].inventory[index3].stack * 100);
          if (Main.player[Main.myPlayer].inventory[index3].type == 73)
            num += (long) (Main.player[Main.myPlayer].inventory[index3].stack * 10000);
          if (Main.player[Main.myPlayer].inventory[index3].type == 74)
            num += (long) (Main.player[Main.myPlayer].inventory[index3].stack * 1000000);
        }
        if (num >= 1000000L)
        {
          this.item[index1].SetDefaults(1980, false);
          ++index1;
        }
        if (Main.moonPhase % 2 == 0 && Main.dayTime || Main.moonPhase % 2 == 1 && !Main.dayTime)
        {
          this.item[index1].SetDefaults(1981, false);
          ++index1;
        }
        if (Main.player[Main.myPlayer].team != 0)
        {
          this.item[index1].SetDefaults(1982, false);
          ++index1;
        }
        if (Main.hardMode)
        {
          this.item[index1].SetDefaults(1983, false);
          ++index1;
        }
        if (NPC.AnyNPCs(208))
        {
          this.item[index1].SetDefaults(1984, false);
          ++index1;
        }
        if (Main.hardMode && NPC.downedMechBoss1 && (NPC.downedMechBoss2 && NPC.downedMechBoss3))
        {
          this.item[index1].SetDefaults(1985, false);
          ++index1;
        }
        if (Main.hardMode && NPC.downedMechBossAny)
        {
          this.item[index1].SetDefaults(1986, false);
          ++index1;
        }
        if (Main.hardMode && NPC.downedMartians)
        {
          this.item[index1].SetDefaults(2863, false);
          int index3 = index1 + 1;
          this.item[index3].SetDefaults(3259, false);
          index1 = index3 + 1;
        }
      }
      else if (type == 19)
      {
        for (int index2 = 0; index2 < 40; ++index2)
        {
          if (Main.travelShop[index2] != 0)
          {
            this.item[index1].netDefaults(Main.travelShop[index2]);
            ++index1;
          }
        }
      }
      else if (type == 20)
      {
        if (Main.moonPhase % 2 == 0)
          this.item[index1].SetDefaults(3001, false);
        else
          this.item[index1].SetDefaults(28, false);
        int index2 = index1 + 1;
        if (Main.dayTime && Main.moonPhase != 0)
          this.item[index2].SetDefaults(282, false);
        else
          this.item[index2].SetDefaults(3002, false);
        int index3 = index2 + 1;
        if (Main.time % 60.0 * 60.0 * 6.0 <= 10800.0)
          this.item[index3].SetDefaults(3004, false);
        else
          this.item[index3].SetDefaults(8, false);
        int index4 = index3 + 1;
        if (Main.moonPhase != 0 && Main.moonPhase != 1 && (Main.moonPhase != 4 && Main.moonPhase != 5))
          this.item[index4].SetDefaults(40, false);
        else
          this.item[index4].SetDefaults(3003, false);
        int index5 = index4 + 1;
        if (Main.moonPhase % 4 == 0)
          this.item[index5].SetDefaults(3310, false);
        else if (Main.moonPhase % 4 == 1)
          this.item[index5].SetDefaults(3313, false);
        else if (Main.moonPhase % 4 == 2)
          this.item[index5].SetDefaults(3312, false);
        else
          this.item[index5].SetDefaults(3311, false);
        int index6 = index5 + 1;
        this.item[index6].SetDefaults(166, false);
        int index7 = index6 + 1;
        this.item[index7].SetDefaults(965, false);
        index1 = index7 + 1;
        if (Main.hardMode)
        {
          if (Main.moonPhase < 4)
            this.item[index1].SetDefaults(3316, false);
          else
            this.item[index1].SetDefaults(3315, false);
          int index8 = index1 + 1;
          this.item[index8].SetDefaults(3334, false);
          index1 = index8 + 1;
          if (Main.bloodMoon)
          {
            this.item[index1].SetDefaults(3258, false);
            ++index1;
          }
        }
        if (Main.moonPhase == 0 && !Main.dayTime)
        {
          this.item[index1].SetDefaults(3043, false);
          ++index1;
        }
      }
      else if (type == 21)
      {
        bool flag1 = Main.hardMode && NPC.downedMechBossAny;
        bool flag2 = Main.hardMode && NPC.downedGolemBoss;
        this.item[index1].SetDefaults(353, false);
        int index2 = index1 + 1;
        this.item[index2].SetDefaults(3828, false);
        this.item[index2].shopCustomPrice = !flag2 ? (!flag1 ? new int?(Item.buyPrice(0, 0, 25, 0)) : new int?(Item.buyPrice(0, 1, 0, 0))) : new int?(Item.buyPrice(0, 4, 0, 0));
        int index3 = index2 + 1;
        this.item[index3].SetDefaults(3816, false);
        int index4 = index3 + 1;
        this.item[index4].SetDefaults(3813, false);
        this.item[index4].shopCustomPrice = new int?(75);
        this.item[index4].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        int num = index4 + 1;
        num = 10;
        this.item[10].SetDefaults(3818, false);
        this.item[10].shopCustomPrice = new int?(5);
        this.item[10].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        num = 11;
        this.item[11].SetDefaults(3824, false);
        this.item[11].shopCustomPrice = new int?(5);
        this.item[11].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        num = 12;
        this.item[12].SetDefaults(3832, false);
        this.item[12].shopCustomPrice = new int?(5);
        this.item[12].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        index1 = 13;
        this.item[13].SetDefaults(3829, false);
        this.item[13].shopCustomPrice = new int?(5);
        this.item[13].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        if (flag1)
        {
          num = 20;
          this.item[20].SetDefaults(3819, false);
          this.item[20].shopCustomPrice = new int?(25);
          this.item[20].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 21;
          this.item[21].SetDefaults(3825, false);
          this.item[21].shopCustomPrice = new int?(25);
          this.item[21].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 22;
          this.item[22].SetDefaults(3833, false);
          this.item[22].shopCustomPrice = new int?(25);
          this.item[22].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          index1 = 23;
          this.item[23].SetDefaults(3830, false);
          this.item[23].shopCustomPrice = new int?(25);
          this.item[23].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        }
        if (flag2)
        {
          num = 30;
          this.item[30].SetDefaults(3820, false);
          this.item[30].shopCustomPrice = new int?(100);
          this.item[30].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 31;
          this.item[31].SetDefaults(3826, false);
          this.item[31].shopCustomPrice = new int?(100);
          this.item[31].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 32;
          this.item[32].SetDefaults(3834, false);
          this.item[32].shopCustomPrice = new int?(100);
          this.item[32].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          index1 = 33;
          this.item[33].SetDefaults(3831, false);
          this.item[33].shopCustomPrice = new int?(100);
          this.item[33].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        }
        if (flag1)
        {
          num = 4;
          this.item[4].SetDefaults(3800, false);
          this.item[4].shopCustomPrice = new int?(25);
          this.item[4].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 5;
          this.item[5].SetDefaults(3801, false);
          this.item[5].shopCustomPrice = new int?(25);
          this.item[5].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 6;
          this.item[6].SetDefaults(3802, false);
          this.item[6].shopCustomPrice = new int?(25);
          this.item[6].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 7;
          num = 14;
          this.item[14].SetDefaults(3797, false);
          this.item[14].shopCustomPrice = new int?(25);
          this.item[14].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 15;
          this.item[15].SetDefaults(3798, false);
          this.item[15].shopCustomPrice = new int?(25);
          this.item[15].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 16;
          this.item[16].SetDefaults(3799, false);
          this.item[16].shopCustomPrice = new int?(25);
          this.item[16].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 17;
          num = 24;
          this.item[24].SetDefaults(3803, false);
          this.item[24].shopCustomPrice = new int?(25);
          this.item[24].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 25;
          this.item[25].SetDefaults(3804, false);
          this.item[25].shopCustomPrice = new int?(25);
          this.item[25].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 26;
          this.item[26].SetDefaults(3805, false);
          this.item[26].shopCustomPrice = new int?(25);
          this.item[26].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 27;
          num = 34;
          this.item[34].SetDefaults(3806, false);
          this.item[34].shopCustomPrice = new int?(25);
          this.item[34].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 35;
          this.item[35].SetDefaults(3807, false);
          this.item[35].shopCustomPrice = new int?(25);
          this.item[35].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 36;
          this.item[36].SetDefaults(3808, false);
          this.item[36].shopCustomPrice = new int?(25);
          this.item[36].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          index1 = 37;
        }
        if (flag2)
        {
          num = 7;
          this.item[7].SetDefaults(3871, false);
          this.item[7].shopCustomPrice = new int?(75);
          this.item[7].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 8;
          this.item[8].SetDefaults(3872, false);
          this.item[8].shopCustomPrice = new int?(75);
          this.item[8].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 9;
          this.item[9].SetDefaults(3873, false);
          this.item[9].shopCustomPrice = new int?(75);
          this.item[9].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 10;
          num = 17;
          this.item[17].SetDefaults(3874, false);
          this.item[17].shopCustomPrice = new int?(75);
          this.item[17].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 18;
          this.item[18].SetDefaults(3875, false);
          this.item[18].shopCustomPrice = new int?(75);
          this.item[18].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 19;
          this.item[19].SetDefaults(3876, false);
          this.item[19].shopCustomPrice = new int?(75);
          this.item[19].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 20;
          num = 27;
          this.item[27].SetDefaults(3877, false);
          this.item[27].shopCustomPrice = new int?(75);
          this.item[27].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 28;
          this.item[28].SetDefaults(3878, false);
          this.item[28].shopCustomPrice = new int?(75);
          this.item[28].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 29;
          this.item[29].SetDefaults(3879, false);
          this.item[29].shopCustomPrice = new int?(75);
          this.item[29].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 30;
          num = 37;
          this.item[37].SetDefaults(3880, false);
          this.item[37].shopCustomPrice = new int?(75);
          this.item[37].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 38;
          this.item[38].SetDefaults(3881, false);
          this.item[38].shopCustomPrice = new int?(75);
          this.item[38].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num = 39;
          this.item[39].SetDefaults(3882, false);
          this.item[39].shopCustomPrice = new int?(75);
          this.item[39].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          index1 = 40;
        }
      }
      if (!Main.player[Main.myPlayer].discount)
        return;
      for (int index2 = 0; index2 < index1; ++index2)
        this.item[index2].value = (int) ((double) this.item[index2].value * 0.800000011920929);
    }

    public static void UpdateChestFrames()
    {
      bool[] flagArray = new bool[1000];
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        if (Main.player[index].active && Main.player[index].chest >= 0 && Main.player[index].chest < 1000)
          flagArray[Main.player[index].chest] = true;
      }
      for (int index = 0; index < 1000; ++index)
      {
        Chest chest = Main.chest[index];
        if (chest != null)
        {
          if (flagArray[index])
            ++chest.frameCounter;
          else
            --chest.frameCounter;
          if (chest.frameCounter < 0)
            chest.frameCounter = 0;
          if (chest.frameCounter > 10)
            chest.frameCounter = 10;
          chest.frame = chest.frameCounter != 0 ? (chest.frameCounter != 10 ? 1 : 2) : 0;
        }
      }
    }
  }
}
