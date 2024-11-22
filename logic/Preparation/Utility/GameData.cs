﻿using Preparation.Utility.Value;
using System;

namespace Preparation.Utility
{
    public static class GameData
    {
        public const int NumOfStepPerSecond = 2500;         // 每秒行走基础步数.由于移速buff的存在，角色的具体移动速度会发生变化，相应代码需调整
        public const int FrameDuration = 50;                // 每帧时长
        public const int CheckInterval = 10;                // 检查间隔
        public const uint GameDurationInSecond = 60 * 10;   // 游戏时长
        public const int LimitOfStopAndMove = 15;           // 停止和移动的最大间隔

        public const int TolerancesLength = 3;
        public const int AdjustLength = 3;
        //character cost
        public const int SunWukongcost = 5000;
        public const int ZhuBajiecost = 4000;
        public const int ShaWujingcost = 3000;
        public const int BaiLongmacost = 4000;
        public const int Monkidcost = 1000;
        public const int HongHaiercost = 5000;
        public const int NiuMowangcost = 4000;
        public const int TieShancost = 3000;
        public const int ZhiZhujingcost = 3000;
        public const int Pawncost = 1000;

        public const int NumOfPosGridPerCell = 1000;    // 每格的【坐标单位】数
        public const int MapLength = 50000;             // 地图长度
        public const int MapRows = 50;                  // 行数
        public const int MapCols = 50;                  // 列数

        public const int CharacterRadius = 400;
        public static XY GetCellCenterPos(int x, int y)  // 求格子的中心坐标
            => new(x * NumOfPosGridPerCell + NumOfPosGridPerCell / 2,
                   y * NumOfPosGridPerCell + NumOfPosGridPerCell / 2);
        public static int PosGridToCellX(XY pos)  // 求坐标所在的格子的x坐标
            => pos.x / NumOfPosGridPerCell;
        public static int PosGridToCellY(XY pos)  // 求坐标所在的格子的y坐标
            => pos.y / NumOfPosGridPerCell;
        public static CellXY PosGridToCellXY(XY pos)  // 求坐标所在的格子的xy坐标
            => new(PosGridToCellX(pos), PosGridToCellY(pos));

        public static bool IsInTheSameCell(XY pos1, XY pos2) => PosGridToCellXY(pos1) == PosGridToCellXY(pos2);
        public static bool PartInTheSameCell(XY pos1, XY pos2)
        {
            return Math.Abs((pos1 - pos2).x) < CharacterRadius + (NumOfPosGridPerCell / 2)
                && Math.Abs((pos1 - pos2).y) < CharacterRadius + (NumOfPosGridPerCell / 2);
        }
        public static bool ApproachToInteract(XY pos1, XY pos2)
        {
            return Math.Abs(PosGridToCellX(pos1) - PosGridToCellX(pos2)) <= 1
                && Math.Abs(PosGridToCellY(pos1) - PosGridToCellY(pos2)) <= 1;
        }
        public static bool ApproachToInteractInACross(XY pos1, XY pos2)
        {
            if (pos1 == pos2) return false;
            return (Math.Abs(PosGridToCellX(pos1) - PosGridToCellX(pos2))
                  + Math.Abs(PosGridToCellY(pos1) - PosGridToCellY(pos2))) <= 1;
        }
        public static bool IsInTheRange(XY pos1, XY pos2, int range)
        {
            return (pos1 - pos2).Length() <= range;
        }
    }
}
