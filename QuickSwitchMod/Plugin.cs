using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using InvHotkeys.Patches;


namespace InvHotkeys
{
	[BepInPlugin(modGUID, modName, modVersion)]
	public class InvHotkeysBase : BaseUnityPlugin
	{
		private const string modGUID = "Asuran.InvHotkeys";
		private const string modName = "Inventory Hotkeys";
		private const string modVersion = "1.0.0";

		private readonly Harmony harmony = new Harmony(modGUID);

		private static InvHotkeysBase instance;

		internal ManualLogSource mls;


		void Awake()
		{
			if (instance == null)
			{
				instance = this;
			}

			mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

			mls.LogInfo("InvHotkey mod has spawned.");

			harmony.PatchAll(typeof(InvHotkeysBase));
			harmony.PatchAll(typeof(InventoryControllerBPatch));
		}

	}
}
