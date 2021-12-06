using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdCap_Hack.Patches
{
	[HarmonyPatch(typeof(Hacks))]
	class HacksPatch
	{

		[HarmonyPrefix]
		[HarmonyPatch("Update")]
		static void PreFix(ref Hacks __instance)
		{
			Console.WriteLine("Test");
			__instance.hackable = true;
		}
	}
}
