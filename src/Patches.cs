using Harmony;

namespace DetectionRange
{
    internal class Patches
    {
        [HarmonyPatch(typeof(BaseAi), "DoCustomModeModifiers")]
        public class DetectionRangeModify
        {
            public static void Postfix(BaseAi __instance)
            {
                switch (__instance.m_AiSubType)
                {
                    case AiSubType.Wolf:
                        Implementation.AdjustRanges(__instance, "wolf");
                        break;
                    case AiSubType.Stag:
                        Implementation.AdjustRanges(__instance, "deer");
                        break;
                    case AiSubType.Moose:
                        Implementation.AdjustRanges(__instance, "moose");
                        break;
                    case AiSubType.Rabbit:
                        Implementation.AdjustRanges(__instance, "rabbit");
                        break;
                    case AiSubType.Bear:
                        Implementation.AdjustRanges(__instance, "bear");
                        break;
                }

            }
        }
    }
}
