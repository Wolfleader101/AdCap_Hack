using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using PlayFab;
using PlayFab.ClientModels;

namespace AdCap_Hack.Patches
{
	//[HarmonyPatch(typeof(Platforms.Store.SteamStore))]
	//class StorePatch
	//{

	//	[HarmonyPrefix]
	//	[HarmonyPatch("OnStartPurchase")]
	//	static bool Prefix1(ref StartPurchaseResult __order, ref Platforms.PlayFabWrapper ___playFab, ref Platforms.Logger.Logger ___logger)
	//	{
	//		___logger.Debug("Test");
	//		___playFab.PayForPurchase(__order.OrderId, "Steam", "RM", onResult, onError, null);


	//		return true;
	//	}

	//	private static void onResult(PayForPurchaseResult obj)
	//	{

	//	}

	//	private static void onError(PlayFabError obj)
	//	{

	//	}
	//}
}
