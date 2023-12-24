using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNetcodeStuff;
using HarmonyLib;



namespace InvHotkeys.Patches
{
	[HarmonyPatch(typeof(PlayerControllerB))]
	internal class InventoryControllerBPatch
	{

		[HarmonyPatch("Update")]
		[HarmonyPostfix]
		static void FastSwitchPatch(ref float ___timeSinceSwitchingSlots)
		{
			___timeSinceSwitchingSlots = 1f;
		}


	}
}
