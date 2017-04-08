using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.World.Generation;
namespace Terraria.GameContent.Biomes
{
	public class CaveHouseBiome : MicroBiome
	{
		private class BuildData
		{
			public delegate void ProcessRoomMethod(Rectangle room);
			public static CaveHouseBiome.BuildData Snow = CaveHouseBiome.BuildData.CreateSnowData();
			public static CaveHouseBiome.BuildData Jungle = CaveHouseBiome.BuildData.CreateJungleData();
			public static CaveHouseBiome.BuildData Default = CaveHouseBiome.BuildData.CreateDefaultData();
			public static CaveHouseBiome.BuildData Granite = CaveHouseBiome.BuildData.CreateGraniteData();
			public static CaveHouseBiome.BuildData Marble = CaveHouseBiome.BuildData.CreateMarbleData();
			public static CaveHouseBiome.BuildData Mushroom = CaveHouseBiome.BuildData.CreateMushroomData();
			public static CaveHouseBiome.BuildData Desert = CaveHouseBiome.BuildData.CreateDesertData();
			public ushort Tile;
			public byte Wall;
			public int PlatformStyle;
			public int DoorStyle;
			public int TableStyle;
			public int WorkbenchStyle;
			public int PianoStyle;
			public int BookcaseStyle;
			public int ChairStyle;
			public int ChestStyle;
			public CaveHouseBiome.BuildData.ProcessRoomMethod ProcessRoom;
			public static CaveHouseBiome.BuildData CreateSnowData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 321,
					Wall = 149,
					DoorStyle = 30,
					PlatformStyle = 19,
					TableStyle = 28,
					WorkbenchStyle = 23,
					PianoStyle = 23,
					BookcaseStyle = 25,
					ChairStyle = 30,
					ChestStyle = 11,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeSnowRoom)
				};
			}
			public static CaveHouseBiome.BuildData CreateDesertData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 396,
					Wall = 187,
					PlatformStyle = 0,
					DoorStyle = 0,
					TableStyle = 0,
					WorkbenchStyle = 0,
					PianoStyle = 0,
					BookcaseStyle = 0,
					ChairStyle = 0,
					ChestStyle = 1,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeDesertRoom)
				};
			}
			public static CaveHouseBiome.BuildData CreateJungleData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 158,
					Wall = 42,
					PlatformStyle = 2,
					DoorStyle = 2,
					TableStyle = 2,
					WorkbenchStyle = 2,
					PianoStyle = 2,
					BookcaseStyle = 12,
					ChairStyle = 3,
					ChestStyle = 8,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeJungleRoom)
				};
			}
			public static CaveHouseBiome.BuildData CreateGraniteData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 369,
					Wall = 181,
					PlatformStyle = 28,
					DoorStyle = 34,
					TableStyle = 33,
					WorkbenchStyle = 29,
					PianoStyle = 28,
					BookcaseStyle = 30,
					ChairStyle = 34,
					ChestStyle = 50,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeGraniteRoom)
				};
			}
			public static CaveHouseBiome.BuildData CreateMarbleData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 357,
					Wall = 179,
					PlatformStyle = 29,
					DoorStyle = 35,
					TableStyle = 34,
					WorkbenchStyle = 30,
					PianoStyle = 29,
					BookcaseStyle = 31,
					ChairStyle = 35,
					ChestStyle = 51,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeMarbleRoom)
				};
			}
			public static CaveHouseBiome.BuildData CreateMushroomData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 190,
					Wall = 74,
					PlatformStyle = 18,
					DoorStyle = 6,
					TableStyle = 27,
					WorkbenchStyle = 7,
					PianoStyle = 22,
					BookcaseStyle = 24,
					ChairStyle = 9,
					ChestStyle = 32,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeMushroomRoom)
				};
			}
			public static CaveHouseBiome.BuildData CreateDefaultData()
			{
				return new CaveHouseBiome.BuildData
				{
					Tile = 30,
					Wall = 27,
					PlatformStyle = 0,
					DoorStyle = 0,
					TableStyle = 0,
					WorkbenchStyle = 0,
					PianoStyle = 0,
					BookcaseStyle = 0,
					ChairStyle = 0,
					ChestStyle = 1,
					ProcessRoom = new CaveHouseBiome.BuildData.ProcessRoomMethod(CaveHouseBiome.AgeDefaultRoom)
				};
			}
		}
		private const int VERTICAL_EXIT_WIDTH = 3;
		private static readonly bool[] _blacklistedTiles = TileID.Sets.Factory.CreateBoolSet(true, new int[]
		{
			225,
			41,
			43,
			44,
			226,
			203,
			112,
			25,
			151
		});
		private int _sharpenerCount;
		private int _extractinatorCount;
		private Rectangle GetRoom(Point origin)
		{
			Point origin2;
			bool flag = WorldUtils.Find(origin, Searches.Chain(new Searches.Left(25), new GenCondition[]
			{
				new Conditions.IsSolid()
			}), out origin2);
			Point origin3;
			bool flag2 = WorldUtils.Find(origin, Searches.Chain(new Searches.Right(25), new GenCondition[]
			{
				new Conditions.IsSolid()
			}), out origin3);
			if (!flag)
			{
				origin2 = new Point(origin.X - 25, origin.Y);
			}
			if (!flag2)
			{
				origin3 = new Point(origin.X + 25, origin.Y);
			}
			Rectangle result = new Rectangle(origin.X, origin.Y, 0, 0);
			if (origin.X - origin2.X > origin3.X - origin.X)
			{
				result.X = origin2.X;
				result.Width = Utils.Clamp<int>(origin3.X - origin2.X, 15, 30);
			}
			else
			{
				result.Width = Utils.Clamp<int>(origin3.X - origin2.X, 15, 30);
				result.X = origin3.X - result.Width;
			}
			Point point;
			bool flag3 = WorldUtils.Find(origin2, Searches.Chain(new Searches.Up(10), new GenCondition[]
			{
				new Conditions.IsSolid()
			}), out point);
			Point point2;
			bool flag4 = WorldUtils.Find(origin3, Searches.Chain(new Searches.Up(10), new GenCondition[]
			{
				new Conditions.IsSolid()
			}), out point2);
			if (!flag3)
			{
				point = new Point(origin.X, origin.Y - 10);
			}
			if (!flag4)
			{
				point2 = new Point(origin.X, origin.Y - 10);
			}
			result.Height = Utils.Clamp<int>(Math.Max(origin.Y - point.Y, origin.Y - point2.Y), 8, 12);
			result.Y -= result.Height;
			return result;
		}
		private float RoomSolidPrecentage(Rectangle room)
		{
			float num = (float)(room.Width * room.Height);
			Ref<int> @ref = new Ref<int>(0);
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.IsSolid(),
				new Actions.Count(@ref)
			}));
			return (float)@ref.Value / num;
		}
		private bool FindVerticalExit(Rectangle wall, bool isUp, out int exitX)
		{
			Point point;
			bool result = WorldUtils.Find(new Point(wall.X + wall.Width - 3, wall.Y + (isUp ? -5 : 0)), Searches.Chain(new Searches.Left(wall.Width - 3), new GenCondition[]
			{
				new Conditions.IsSolid().Not().AreaOr(3, 5)
			}), out point);
			exitX = point.X;
			return result;
		}
		private bool FindSideExit(Rectangle wall, bool isLeft, out int exitY)
		{
			Point point;
			bool result = WorldUtils.Find(new Point(wall.X + (isLeft ? -4 : 0), wall.Y + wall.Height - 3), Searches.Chain(new Searches.Up(wall.Height - 3), new GenCondition[]
			{
				new Conditions.IsSolid().Not().AreaOr(4, 3)
			}), out point);
			exitY = point.Y;
			return result;
		}
		private int SortBiomeResults(Tuple<CaveHouseBiome.BuildData, int> item1, Tuple<CaveHouseBiome.BuildData, int> item2)
		{
			return item2.Item2.CompareTo(item1.Item2);
		}
		public override bool Place(Point origin, StructureMap structures)
		{
			Point point;
			bool flag = WorldUtils.Find(origin, Searches.Chain(new Searches.Down(200), new GenCondition[]
			{
				new Conditions.IsSolid()
			}), out point);
			if (!flag || point == origin)
			{
				return false;
			}
			Rectangle room = this.GetRoom(point);
			Rectangle rectangle = this.GetRoom(new Point(room.Center.X, room.Y + 1));
			Rectangle rectangle2 = this.GetRoom(new Point(room.Center.X, room.Y + room.Height + 10));
			rectangle2.Y = room.Y + room.Height - 1;
			float num = this.RoomSolidPrecentage(rectangle);
			float num2 = this.RoomSolidPrecentage(rectangle2);
			room.Y += 3;
			rectangle.Y += 3;
			rectangle2.Y += 3;
			List<Rectangle> list = new List<Rectangle>();
			if (GenBase._random.NextFloat() > num + 0.2f)
			{
				list.Add(rectangle);
			}
			else
			{
				rectangle = room;
			}
			list.Add(room);
			if (GenBase._random.NextFloat() > num2 + 0.2f)
			{
				list.Add(rectangle2);
			}
			else
			{
				rectangle2 = room;
			}
			foreach (Rectangle current in list)
			{
				if (current.Y + current.Height > Main.maxTilesY - 220)
				{
					bool result = false;
					return result;
				}
			}
			Dictionary<ushort, int> dictionary = new Dictionary<ushort, int>();
			foreach (Rectangle current2 in list)
			{
				WorldUtils.Gen(new Point(current2.X - 10, current2.Y - 10), new Shapes.Rectangle(current2.Width + 20, current2.Height + 20), new Actions.TileScanner(new ushort[]
				{
					0,
					59,
					147,
					1,
					161,
					53,
					396,
					397,
					368,
					367,
					60,
					70
				}).Output(dictionary));
			}
			List<Tuple<CaveHouseBiome.BuildData, int>> list2 = new List<Tuple<CaveHouseBiome.BuildData, int>>();
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Default, dictionary[0] + dictionary[1]));
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Jungle, dictionary[59] + dictionary[60] * 10));
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Mushroom, dictionary[59] + dictionary[70] * 10));
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Snow, dictionary[147] + dictionary[161]));
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Desert, dictionary[397] + dictionary[396] + dictionary[53]));
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Granite, dictionary[368]));
			list2.Add(Tuple.Create<CaveHouseBiome.BuildData, int>(CaveHouseBiome.BuildData.Marble, dictionary[367]));
			list2.Sort(new Comparison<Tuple<CaveHouseBiome.BuildData, int>>(this.SortBiomeResults));
			CaveHouseBiome.BuildData item = list2[0].Item1;
			foreach (Rectangle current3 in list)
			{
				if (item != CaveHouseBiome.BuildData.Granite)
				{
					Point point2;
					bool flag2 = WorldUtils.Find(new Point(current3.X - 2, current3.Y - 2), Searches.Chain(new Searches.Rectangle(current3.Width + 4, current3.Height + 4).RequireAll(false), new GenCondition[]
					{
						new Conditions.HasLava()
					}), out point2);
					if (flag2)
					{
						bool result = false;
						return result;
					}
				}
				if (!structures.CanPlace(current3, CaveHouseBiome._blacklistedTiles, 5))
				{
					bool result = false;
					return result;
				}
			}
			int num3 = room.X;
			int num4 = room.X + room.Width - 1;
			List<Rectangle> list3 = new List<Rectangle>();
			foreach (Rectangle current4 in list)
			{
				num3 = Math.Min(num3, current4.X);
				num4 = Math.Max(num4, current4.X + current4.Width - 1);
			}
			int num5 = 6;
			while (num5 > 4 && (num4 - num3) % num5 != 0)
			{
				num5--;
			}
			for (int i = num3; i <= num4; i += num5)
			{
				for (int j = 0; j < list.Count; j++)
				{
					Rectangle rectangle3 = list[j];
					if (i >= rectangle3.X && i < rectangle3.X + rectangle3.Width)
					{
						int num6 = rectangle3.Y + rectangle3.Height;
						int num7 = 50;
						for (int k = j + 1; k < list.Count; k++)
						{
							if (i >= list[k].X && i < list[k].X + list[k].Width)
							{
								num7 = Math.Min(num7, list[k].Y - num6);
							}
						}
						if (num7 > 0)
						{
							Point point3;
							bool flag3 = WorldUtils.Find(new Point(i, num6), Searches.Chain(new Searches.Down(num7), new GenCondition[]
							{
								new Conditions.IsSolid()
							}), out point3);
							if (num7 < 50)
							{
								flag3 = true;
								point3 = new Point(i, num6 + num7);
							}
							if (flag3)
							{
								list3.Add(new Rectangle(i, num6, 1, point3.Y - num6));
							}
						}
					}
				}
			}
			List<Point> list4 = new List<Point>();
			foreach (Rectangle current5 in list)
			{
				int y;
				bool flag4 = this.FindSideExit(new Rectangle(current5.X + current5.Width, current5.Y + 1, 1, current5.Height - 2), false, out y);
				if (flag4)
				{
					list4.Add(new Point(current5.X + current5.Width - 1, y));
				}
				flag4 = this.FindSideExit(new Rectangle(current5.X, current5.Y + 1, 1, current5.Height - 2), true, out y);
				if (flag4)
				{
					list4.Add(new Point(current5.X, y));
				}
			}
			List<Tuple<Point, Point>> list5 = new List<Tuple<Point, Point>>();
			for (int l = 1; l < list.Count; l++)
			{
				Rectangle rectangle4 = list[l];
				Rectangle rectangle5 = list[l - 1];
				int num8 = rectangle5.X - rectangle4.X;
				int num9 = rectangle4.X + rectangle4.Width - (rectangle5.X + rectangle5.Width);
				if (num8 > num9)
				{
					list5.Add(new Tuple<Point, Point>(new Point(rectangle4.X + rectangle4.Width - 1, rectangle4.Y + 1), new Point(rectangle4.X + rectangle4.Width - rectangle4.Height + 1, rectangle4.Y + rectangle4.Height - 1)));
				}
				else
				{
					list5.Add(new Tuple<Point, Point>(new Point(rectangle4.X, rectangle4.Y + 1), new Point(rectangle4.X + rectangle4.Height - 1, rectangle4.Y + rectangle4.Height - 1)));
				}
			}
			List<Point> list6 = new List<Point>();
			int x;
			bool flag5 = this.FindVerticalExit(new Rectangle(rectangle.X + 2, rectangle.Y, rectangle.Width - 4, 1), true, out x);
			if (flag5)
			{
				list6.Add(new Point(x, rectangle.Y));
			}
			flag5 = this.FindVerticalExit(new Rectangle(rectangle2.X + 2, rectangle2.Y + rectangle2.Height - 1, rectangle2.Width - 4, 1), false, out x);
			if (flag5)
			{
				list6.Add(new Point(x, rectangle2.Y + rectangle2.Height - 1));
			}
			foreach (Rectangle current6 in list)
			{
				WorldUtils.Gen(new Point(current6.X, current6.Y), new Shapes.Rectangle(current6.Width, current6.Height), Actions.Chain(new GenAction[]
				{
					new Actions.SetTile(item.Tile, false, true),
					new Actions.SetFrames(true)
				}));
				WorldUtils.Gen(new Point(current6.X + 1, current6.Y + 1), new Shapes.Rectangle(current6.Width - 2, current6.Height - 2), Actions.Chain(new GenAction[]
				{
					new Actions.ClearTile(true),
					new Actions.PlaceWall(item.Wall, true)
				}));
				structures.AddStructure(current6, 8);
			}
			foreach (Tuple<Point, Point> current7 in list5)
			{
				Point item2 = current7.Item1;
				Point item3 = current7.Item2;
				int num10 = (item3.X > item2.X) ? 1 : -1;
				ShapeData shapeData = new ShapeData();
				for (int m = 0; m < item3.Y - item2.Y; m++)
				{
					shapeData.Add(num10 * (m + 1), m);
				}
				WorldUtils.Gen(item2, new ModShapes.All(shapeData), Actions.Chain(new GenAction[]
				{
					new Actions.PlaceTile(19, item.PlatformStyle),
					new Actions.SetSlope((num10 == 1) ? 1 : 2),
					new Actions.SetFrames(true)
				}));
				WorldUtils.Gen(new Point(item2.X + ((num10 == 1) ? 1 : -4), item2.Y - 1), new Shapes.Rectangle(4, 1), Actions.Chain(new GenAction[]
				{
					new Actions.Clear(),
					new Actions.PlaceWall(item.Wall, true),
					new Actions.PlaceTile(19, item.PlatformStyle),
					new Actions.SetFrames(true)
				}));
			}
			foreach (Point current8 in list4)
			{
				WorldUtils.Gen(current8, new Shapes.Rectangle(1, 3), new Actions.ClearTile(true));
				WorldGen.PlaceTile(current8.X, current8.Y, 10, true, true, -1, item.DoorStyle);
			}
			foreach (Point current9 in list6)
			{
				WorldUtils.Gen(current9, new Shapes.Rectangle(3, 1), Actions.Chain(new GenAction[]
				{
					new Actions.ClearMetadata(),
					new Actions.PlaceTile(19, item.PlatformStyle),
					new Actions.SetFrames(true)
				}));
			}
			foreach (Rectangle current10 in list3)
			{
				if (current10.Height > 1 && GenBase._tiles[current10.X, current10.Y - 1].type != 19)
				{
					WorldUtils.Gen(new Point(current10.X, current10.Y), new Shapes.Rectangle(current10.Width, current10.Height), Actions.Chain(new GenAction[]
					{
						new Actions.SetTile(124, false, true),
						new Actions.SetFrames(true)
					}));
					Tile tile = GenBase._tiles[current10.X, current10.Y + current10.Height];
					tile.slope(0);
					tile.halfBrick(false);
				}
			}
			Point[] choices = new Point[]
			{
				new Point(14, item.TableStyle),
				new Point(16, 0),
				new Point(18, item.WorkbenchStyle),
				new Point(86, 0),
				new Point(87, item.PianoStyle),
				new Point(94, 0),
				new Point(101, item.BookcaseStyle)
			};
			foreach (Rectangle current11 in list)
			{
				int num11 = current11.Width / 8;
				int num12 = current11.Width / (num11 + 1);
				int num13 = GenBase._random.Next(2);
				for (int n = 0; n < num11; n++)
				{
					int num14 = (n + 1) * num12 + current11.X;
					switch (n + num13 % 2)
					{
					case 0:
					{
						int num15 = current11.Y + Math.Min(current11.Height / 2, current11.Height - 5);
						Vector2 vector = WorldGen.randHousePicture();
						int type = (int)vector.X;
						int style = (int)vector.Y;
						if (!WorldGen.nearPicture(num14, num15))
						{
							WorldGen.PlaceTile(num14, num15, type, true, false, -1, style);
						}
						break;
					}
					case 1:
					{
						int num15 = current11.Y + 1;
						WorldGen.PlaceTile(num14, num15, 34, true, false, -1, GenBase._random.Next(6));
						for (int num16 = -1; num16 < 2; num16++)
						{
							for (int num17 = 0; num17 < 3; num17++)
							{
								Tile expr_E7C = GenBase._tiles[num16 + num14, num17 + num15];
								expr_E7C.frameX += 54;
							}
						}
						break;
					}
					}
				}
				int num18 = current11.Width / 8 + 3;
				WorldGen.SetupStatueList();
				while (num18 > 0)
				{
					int num19 = GenBase._random.Next(current11.Width - 3) + 1 + current11.X;
					int num20 = current11.Y + current11.Height - 2;
					switch (GenBase._random.Next(4))
					{
					case 0:
						WorldGen.PlaceSmallPile(num19, num20, GenBase._random.Next(31, 34), 1, 185);
						break;
					case 1:
						WorldGen.PlaceTile(num19, num20, 186, true, false, -1, GenBase._random.Next(22, 26));
						break;
					case 2:
					{
						int num21 = GenBase._random.Next(2, WorldGen.statueList.Length);
						WorldGen.PlaceTile(num19, num20, (int)WorldGen.statueList[num21].X, true, false, -1, (int)WorldGen.statueList[num21].Y);
						if (WorldGen.StatuesWithTraps.Contains(num21))
						{
							WorldGen.PlaceStatueTrap(num19, num20);
						}
						break;
					}
					case 3:
					{
						Point point4 = Utils.SelectRandom<Point>(GenBase._random, choices);
						WorldGen.PlaceTile(num19, num20, point4.X, true, false, -1, point4.Y);
						break;
					}
					}
					num18--;
				}
			}
			foreach (Rectangle current12 in list)
			{
				item.ProcessRoom(current12);
			}
			bool flag6 = false;
			foreach (Rectangle current13 in list)
			{
				int num22 = current13.Height - 1 + current13.Y;
				int style2 = (num22 > (int)Main.worldSurface) ? item.ChestStyle : 0;
				for (int num23 = 0; num23 < 10; num23++)
				{
					int i2 = GenBase._random.Next(2, current13.Width - 2) + current13.X;
					if (flag6 = WorldGen.AddBuriedChest(i2, num22, 0, false, style2))
					{
						break;
					}
				}
				if (flag6)
				{
					break;
				}
				int num24 = current13.X + 2;
				while (num24 <= current13.X + current13.Width - 2 && !(flag6 = WorldGen.AddBuriedChest(num24, num22, 0, false, style2)))
				{
					num24++;
				}
				if (flag6)
				{
					break;
				}
			}
			if (!flag6)
			{
				foreach (Rectangle current14 in list)
				{
					int num25 = current14.Y - 1;
					int style3 = (num25 > (int)Main.worldSurface) ? item.ChestStyle : 0;
					for (int num26 = 0; num26 < 10; num26++)
					{
						int i3 = GenBase._random.Next(2, current14.Width - 2) + current14.X;
						if (flag6 = WorldGen.AddBuriedChest(i3, num25, 0, false, style3))
						{
							break;
						}
					}
					if (flag6)
					{
						break;
					}
					int num27 = current14.X + 2;
					while (num27 <= current14.X + current14.Width - 2 && !(flag6 = WorldGen.AddBuriedChest(num27, num25, 0, false, style3)))
					{
						num27++;
					}
					if (flag6)
					{
						break;
					}
				}
			}
			if (!flag6)
			{
				for (int num28 = 0; num28 < 1000; num28++)
				{
					int i4 = GenBase._random.Next(list[0].X - 30, list[0].X + 30);
					int num29 = GenBase._random.Next(list[0].Y - 30, list[0].Y + 30);
					int style4 = (num29 > (int)Main.worldSurface) ? item.ChestStyle : 0;
					if (flag6 = WorldGen.AddBuriedChest(i4, num29, 0, false, style4))
					{
						break;
					}
				}
			}
			if (item == CaveHouseBiome.BuildData.Jungle && this._sharpenerCount < GenBase._random.Next(2, 5))
			{
				bool flag7 = false;
				foreach (Rectangle current15 in list)
				{
					int num30 = current15.Height - 2 + current15.Y;
					for (int num31 = 0; num31 < 10; num31++)
					{
						int num32 = GenBase._random.Next(2, current15.Width - 2) + current15.X;
						WorldGen.PlaceTile(num32, num30, 377, true, true, -1, 0);
						if (flag7 = (GenBase._tiles[num32, num30].active() && GenBase._tiles[num32, num30].type == 377))
						{
							break;
						}
					}
					if (flag7)
					{
						break;
					}
					int num33 = current15.X + 2;
					while (num33 <= current15.X + current15.Width - 2 && !(flag7 = WorldGen.PlaceTile(num33, num30, 377, true, true, -1, 0)))
					{
						num33++;
					}
					if (flag7)
					{
						break;
					}
				}
				if (flag7)
				{
					this._sharpenerCount++;
				}
			}
			if (item == CaveHouseBiome.BuildData.Desert && this._extractinatorCount < GenBase._random.Next(2, 5))
			{
				bool flag8 = false;
				foreach (Rectangle current16 in list)
				{
					int num34 = current16.Height - 2 + current16.Y;
					for (int num35 = 0; num35 < 10; num35++)
					{
						int num36 = GenBase._random.Next(2, current16.Width - 2) + current16.X;
						WorldGen.PlaceTile(num36, num34, 219, true, true, -1, 0);
						if (flag8 = (GenBase._tiles[num36, num34].active() && GenBase._tiles[num36, num34].type == 219))
						{
							break;
						}
					}
					if (flag8)
					{
						break;
					}
					int num37 = current16.X + 2;
					while (num37 <= current16.X + current16.Width - 2 && !(flag8 = WorldGen.PlaceTile(num37, num34, 219, true, true, -1, 0)))
					{
						num37++;
					}
					if (flag8)
					{
						break;
					}
				}
				if (flag8)
				{
					this._extractinatorCount++;
				}
			}
			return true;
		}
		public override void Reset()
		{
			this._sharpenerCount = 0;
			this._extractinatorCount = 0;
		}
		internal static void AgeDefaultRoom(Rectangle room)
		{
			for (int i = 0; i < room.Width * room.Height / 16; i++)
			{
				int x = GenBase._random.Next(1, room.Width - 1) + room.X;
				int y = GenBase._random.Next(1, room.Height - 1) + room.Y;
				WorldUtils.Gen(new Point(x, y), new Shapes.Rectangle(2, 2), Actions.Chain(new GenAction[]
				{
					new Modifiers.Dither(0.5),
					new Modifiers.Blotches(2, 2.0),
					new Modifiers.IsEmpty(),
					new Actions.SetTile(51, true, true)
				}));
			}
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.85000002384185791),
				new Modifiers.Blotches(2, 0.3),
				new Modifiers.OnlyWalls(new byte[]
				{
					CaveHouseBiome.BuildData.Default.Wall
				}),
				((double)room.Y > Main.worldSurface) ? (GenAction) new Actions.ClearWall(true) : (GenAction) new Actions.PlaceWall(2, true)
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.949999988079071),
				new Modifiers.OnlyTiles(new ushort[]
				{
					30,
					321,
					158
				}),
				new Actions.ClearTile(true)
			}));
		}
		internal static void AgeSnowRoom(Rectangle room)
		{
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.60000002384185791),
				new Modifiers.Blotches(2, 0.60000002384185791),
				new Modifiers.OnlyTiles(new ushort[]
				{
					CaveHouseBiome.BuildData.Snow.Tile
				}),
				new Actions.SetTile(161, true, true),
				new Modifiers.Dither(0.8),
				new Actions.SetTile(147, true, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					161
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					161
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.85000002384185791),
				new Modifiers.Blotches(2, 0.8),
				((double)room.Y > Main.worldSurface) ?(GenAction) new Actions.ClearWall(true) : (GenAction)new Actions.PlaceWall(40, true)
			}));
		}
		internal static void AgeDesertRoom(Rectangle room)
		{
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.800000011920929),
				new Modifiers.Blotches(2, 0.20000000298023224),
				new Modifiers.OnlyTiles(new ushort[]
				{
					CaveHouseBiome.BuildData.Desert.Tile
				}),
				new Actions.SetTile(396, true, true),
				new Modifiers.Dither(0.5),
				new Actions.SetTile(397, true, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					397,
					396
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					397,
					396
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.800000011920929),
				new Modifiers.Blotches(2, 0.3),
				new Modifiers.OnlyWalls(new byte[]
				{
					CaveHouseBiome.BuildData.Desert.Wall
				}),
				new Actions.PlaceWall(216, true)
			}));
		}
		internal static void AgeGraniteRoom(Rectangle room)
		{
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.60000002384185791),
				new Modifiers.Blotches(2, 0.60000002384185791),
				new Modifiers.OnlyTiles(new ushort[]
				{
					CaveHouseBiome.BuildData.Granite.Tile
				}),
				new Actions.SetTile(368, true, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.800000011920929),
				new Modifiers.OnlyTiles(new ushort[]
				{
					368
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.800000011920929),
				new Modifiers.OnlyTiles(new ushort[]
				{
					368
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.85000002384185791),
				new Modifiers.Blotches(2, 0.3),
				new Actions.PlaceWall(180, true)
			}));
		}
		internal static void AgeMarbleRoom(Rectangle room)
		{
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.60000002384185791),
				new Modifiers.Blotches(2, 0.60000002384185791),
				new Modifiers.OnlyTiles(new ushort[]
				{
					CaveHouseBiome.BuildData.Marble.Tile
				}),
				new Actions.SetTile(367, true, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.800000011920929),
				new Modifiers.OnlyTiles(new ushort[]
				{
					367
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.800000011920929),
				new Modifiers.OnlyTiles(new ushort[]
				{
					367
				}),
				new Modifiers.Offset(0, 1),
				new ActionStalagtite()
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.85000002384185791),
				new Modifiers.Blotches(2, 0.3),
				new Actions.PlaceWall(178, true)
			}));
		}
		internal static void AgeMushroomRoom(Rectangle room)
		{
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.699999988079071),
				new Modifiers.Blotches(2, 0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					CaveHouseBiome.BuildData.Mushroom.Tile
				}),
				new Actions.SetTile(70, true, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.60000002384185791),
				new Modifiers.OnlyTiles(new ushort[]
				{
					70
				}),
				new Modifiers.Offset(0, -1),
				new Actions.SetTile(71, false, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.60000002384185791),
				new Modifiers.OnlyTiles(new ushort[]
				{
					70
				}),
				new Modifiers.Offset(0, -1),
				new Actions.SetTile(71, false, true)
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.85000002384185791),
				new Modifiers.Blotches(2, 0.3),
				new Actions.ClearWall(false)
			}));
		}
		internal static void AgeJungleRoom(Rectangle room)
		{
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.60000002384185791),
				new Modifiers.Blotches(2, 0.60000002384185791),
				new Modifiers.OnlyTiles(new ushort[]
				{
					CaveHouseBiome.BuildData.Jungle.Tile
				}),
				new Actions.SetTile(60, true, true),
				new Modifiers.Dither(0.800000011920929),
				new Actions.SetTile(59, true, true)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					60
				}),
				new Modifiers.Offset(0, 1),
				new ActionVines(3, room.Height, 62)
			}));
			WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), new Shapes.Rectangle(room.Width - 2, 1), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.5),
				new Modifiers.OnlyTiles(new ushort[]
				{
					60
				}),
				new Modifiers.Offset(0, 1),
				new ActionVines(3, room.Height, 62)
			}));
			WorldUtils.Gen(new Point(room.X, room.Y), new Shapes.Rectangle(room.Width, room.Height), Actions.Chain(new GenAction[]
			{
				new Modifiers.Dither(0.85000002384185791),
				new Modifiers.Blotches(2, 0.3),
				new Actions.PlaceWall(64, true)
			}));
		}
	}
}
