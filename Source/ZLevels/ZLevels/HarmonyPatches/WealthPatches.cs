using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using RimWorld.QuestGen;
using UnityEngine;
using Verse;
using Verse.AI;
using Verse.AI.Group;

namespace ZLevels
{
	[StaticConstructorOnStartup]
	public static class WealthPatches
	{

		[HarmonyPatch(typeof(WealthWatcher), "WealthItems", MethodType.Getter)]
		internal static class WealthItemsPatch
		{
			[HarmonyReversePatch]
			private static float Get_WealthItems_Original(object instance)
			{
				throw new NotImplementedException("Harmony Reverse Patch");
			}

			[HarmonyPrefix]
			public static bool WealthItems(WealthWatcher __instance, Map ___map, ref float __result)
			{
				float result = 0;
				foreach (var map in ZUtils.ZTracker.GetAllMaps(___map.Tile))
				{
					var value = Get_WealthItems_Original(map.wealthWatcher);
					result += value;
					//ZLogger.Message("Analyzing wealthItems: " + map + " - value: " + value);
				}
				//ZLogger.Message("New result: " + result);
				__result = result;
				return false;
			}
		}

		[HarmonyPatch(typeof(WealthWatcher), "WealthBuildings", MethodType.Getter)]
		internal static class WealthBuildingsPatch
		{
			[HarmonyReversePatch]
			private static float Get_WealthBuildings_Original(object instance)
			{
				throw new NotImplementedException("Harmony Reverse Patch");
			}

			[HarmonyPrefix]
			public static bool WealthBuildings(WealthWatcher __instance, Map ___map, ref float __result)
			{
				float result = 0;
				foreach (var map in ZUtils.ZTracker.GetAllMaps(___map.Tile))
				{
					var value = Get_WealthBuildings_Original(map.wealthWatcher);
					result += value;
					//ZLogger.Message("Analyzing wealthBuildings: " + map + " - value: " + value);
				}
				//ZLogger.Message("New result: " + result);
				__result = result;
				return false;
			}
		}

		[HarmonyPatch(typeof(WealthWatcher), "WealthFloorsOnly", MethodType.Getter)]
		internal static class WealthFloorsOnlyPatch
		{
			[HarmonyReversePatch]
			private static float Get_WealthFloorsOnly_Original(object instance)
            {
				throw new NotImplementedException("Harmony Reverse Patch");
			}

			[HarmonyPrefix]
			public static bool WealthFloorsOnly(WealthWatcher __instance, Map ___map, ref float __result)
			{
				float result = 0;
				foreach (var map in ZUtils.ZTracker.GetAllMaps(___map.Tile))
				{
					var value = Get_WealthFloorsOnly_Original(map.wealthWatcher);
					result += value;
					//ZLogger.Message("Analyzing wealthFloorsOnly: " + map + " - value: " + value);
				}
				//ZLogger.Message("New result: " + result);
				__result = result;
				return false;
			}
		}

		[HarmonyPatch(typeof(WealthWatcher), "WealthPawns", MethodType.Getter)]
		internal static class WealthPawnsPatch
		{
			[HarmonyReversePatch]
			private static float Get_WealthPawns_Original(object instance)
			{
				throw new NotImplementedException("Harmony Reverse Patch");
			}

			[HarmonyPrefix]
			public static bool WealthPawns(WealthWatcher __instance, Map ___map, ref float __result)
			{
				float result = 0;
				foreach (var map in ZUtils.ZTracker.GetAllMaps(___map.Tile))
				{
					var value = Get_WealthPawns_Original(map.wealthWatcher);
					result += value;
					//ZLogger.Message("Analyzing wealthPawns: " + map + " - value: " + value);
				}
				//ZLogger.Message("New result: " + result);
				__result = result;
				return false;
			}
		}

		[HarmonyPatch(typeof(WealthWatcher), "WealthTotal", MethodType.Getter)]
		internal static class WealthTotalPatch
		{
			[HarmonyReversePatch]
			private static float Get_WealthTotal_Original(object instance)
			{
				throw new NotImplementedException("Harmony Reverse Patch");
			}
			[HarmonyPrefix]
			public static bool WealthTotal(WealthWatcher __instance, Map ___map, ref float __result)
			{
				float result = 0;
				foreach (var map in ZUtils.ZTracker.GetAllMaps(___map.Tile))
				{
					var value = Get_WealthTotal_Original(map.wealthWatcher);
					result += value;
					//ZLogger.Message("Analyzing WealthTotal: " + map + " - value: " + value);
				}
				//ZLogger.Message("New result: " + result);
				__result = result;
				return false;
			}
		}
	}
}
