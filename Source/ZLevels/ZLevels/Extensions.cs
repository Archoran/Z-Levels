using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Verse;
using Verse.AI;

namespace ZLevels
{
    public static class FogGrid_Extensions
    {
        private static readonly FastInvokeHandler h_FloodUnfogAdjacent = MethodInvoker.GetHandler(AccessTools.Method(typeof(FogGrid), "FloodUnfogAdjacent"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void FloodUnfogAdjacent(this FogGrid t, IntVec3 pos)
        {
            h_FloodUnfogAdjacent(t, pos);
        }
    }
    public static class Thing_Extensions
    {
        private static readonly AccessTools.FieldRef<Thing, sbyte> r_mapIndexOrState = AccessTools.FieldRefAccess<Thing, sbyte>(AccessTools.Field(typeof(Thing), "mapIndexOrState"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref sbyte MapIndexOrState(this Thing t)
        {
            return ref r_mapIndexOrState(t);
        }

        private static readonly AccessTools.FieldRef<Thing, IntVec3> r_positionInt = AccessTools.FieldRefAccess<Thing, IntVec3>(AccessTools.Field(typeof(Thing), "positionInt"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref IntVec3 PositionInt(this Thing t)
        {
            return ref r_positionInt(t);
        }
    }

    public static class FloatMenuMap_Extensions
    {
        public static bool OptionsMatch(FloatMenuOption a, FloatMenuOption b)
        {
            return a.Label == b.Label;
        }

        private static readonly AccessTools.FieldRef<Thing, Dictionary<Vector3, List<FloatMenuOption>>> r_cachedChoices = AccessTools.FieldRefAccess<Thing, Dictionary<Vector3, List<FloatMenuOption>>>(AccessTools.Field(typeof(FloatMenuMap), "cachedChoices"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Dictionary<Vector3, List<FloatMenuOption>> CachedChoices()
        {
            return r_cachedChoices(null);
        }
    }

    public static class JobGiver_AIFollowPawn_Extensions
    {
        private static readonly FastInvokeHandler h_GetFollowee = MethodInvoker.GetHandler(AccessTools.Method(typeof(JobGiver_AIFollowPawn), "GetFollowee"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Pawn GetFollowee(this JobGiver_AIFollowPawn t, Pawn pawn)
        {
            return (Pawn) h_GetFollowee(t, pawn);
        }

        private static readonly FastInvokeHandler h_GetRadius = MethodInvoker.GetHandler(AccessTools.Method(typeof(JobGiver_AIFollowPawn), "GetRadius"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static float GetRadius(this JobGiver_AIFollowPawn t, Pawn pawn)
        {
            return (float) h_GetRadius(t, pawn);
        }

        private static readonly FastInvokeHandler h_get_FollowJobExpireInterval = MethodInvoker.GetHandler(AccessTools.PropertyGetter(typeof(JobGiver_AIFollowPawn), "FollowJobExpireInterval"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Get_FollowJobExpireInterval(this JobGiver_AIFollowPawn t)
        {
            return (int) h_get_FollowJobExpireInterval(t);
        }
    }

    public static class ThinkNode_JobGiver_Extensions
    {
        private static readonly FastInvokeHandler h_TryGiveJob = MethodInvoker.GetHandler(AccessTools.Method(typeof(ThinkNode_JobGiver), "TryGiveJob"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Job TryGiveJob(this ThinkNode_JobGiver t, Pawn pawn)
        {
            return (Job) h_TryGiveJob(t, pawn);
        }
    }

    public static class TerrainGrid_Extensions
    {
        private static readonly FastInvokeHandler h_DoTerrainChangedEffects = MethodInvoker.GetHandler(AccessTools.Method(typeof(TerrainGrid), "DoTerrainChangedEffects"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void DoTerrainChangedEffects(this TerrainGrid t, IntVec3 c)
        {
            h_DoTerrainChangedEffects(t, c);
        }
    }

    public static class Graphic_Extensions
    {
        private static readonly AccessTools.FieldRef<Graphic_Linked, Graphic> r_subGraphic_Linked = AccessTools.FieldRefAccess<Graphic_Linked, Graphic>(AccessTools.Field(typeof(Graphic_Linked), "subGraphic"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ref Graphic SubGraphic(this Graphic_Linked t)
        {
            return ref r_subGraphic_Linked(t);
        }

        private static readonly AccessTools.FieldRef<Graphic_RandomRotated, Graphic> r_subGraphic_RandomRotated = AccessTools.FieldRefAccess<Graphic_RandomRotated, Graphic>(AccessTools.Field(typeof(Graphic_RandomRotated), "subGraphic"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ref Graphic SubGraphic(this Graphic_RandomRotated t)
        {
            return ref r_subGraphic_RandomRotated(t);
        }
    }

    public static class WorkGiver_Extensions
    {
        private static readonly FastInvokeHandler h_ResourceDeliverJobFor = MethodInvoker.GetHandler(AccessTools.Method(typeof(WorkGiver_ConstructDeliverResources), "ResourceDeliverJobFor"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Job ResourceDeliverJobFor(this WorkGiver_ConstructDeliverResources t, Pawn pawn, IConstructible c, bool canRemoveExistingFloorUnderNearbyNeeders = true)
        {
            return (Job) h_ResourceDeliverJobFor(t, pawn, c, canRemoveExistingFloorUnderNearbyNeeders);
        }
        private static readonly FastInvokeHandler h_RemoveExistingFloorJob = MethodInvoker.GetHandler(AccessTools.Method(typeof(WorkGiver_ConstructDeliverResources), "RemoveExistingFloorJob"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Job RemoveExistingFloorJob(this WorkGiver_ConstructDeliverResources t, Pawn pawn, Blueprint blue)
        {
            return (Job) h_RemoveExistingFloorJob(t, pawn, blue);
        }
        private static readonly FastInvokeHandler h_NoCostFrameMakeJobFor = MethodInvoker.GetHandler(AccessTools.Method(typeof(WorkGiver_ConstructDeliverResourcesToBlueprints), "NoCostFrameMakeJobFor"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Job NoCostFrameMakeJobFor(this WorkGiver_ConstructDeliverResources t, Pawn pawn, IConstructible c)
        {
            return (Job) h_NoCostFrameMakeJobFor(t, pawn, c);
        }
        private static readonly FastInvokeHandler h_TryFindBestBillIngredients = MethodInvoker.GetHandler(AccessTools.Method(typeof(WorkGiver_DoBill), "TryFindBestBillIngredients"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool TryFindBestBillIngredients(Bill bill, Pawn pawn, Thing billGiver, List<ThingCount> chosen)
        {
            return (bool) h_TryFindBestBillIngredients(null, bill, pawn, billGiver, chosen);
        }
        private static readonly FastInvokeHandler h_FinishUftJob = MethodInvoker.GetHandler(AccessTools.Method(typeof(WorkGiver_DoBill), "FinishUftJob"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Job FinishUftJob(Pawn pawn, UnfinishedThing uft, Bill_ProductionWithUft bill)
        {
            return (Job) h_FinishUftJob(null, pawn, uft, bill);
        }
        private static readonly FastInvokeHandler h_ClosestUnfinishedThingForBill = MethodInvoker.GetHandler(AccessTools.Method(typeof(WorkGiver_DoBill), "ClosestUnfinishedThingForBill"), true);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static UnfinishedThing ClosestUnfinishedThingForBill(Pawn pawn, Bill_ProductionWithUft bill)
        {
            return (UnfinishedThing) h_ClosestUnfinishedThingForBill(null, pawn, bill);
        }
    }
}
