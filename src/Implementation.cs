using MelonLoader;
using UnityEngine;

namespace DetectionRange
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }
        internal static void Log(string message) => MelonLogger.Log(message);
        internal static void Log(string message, params object[] parameters) => MelonLogger.Log(message, parameters);

        internal static void AdjustRanges(BaseAi inst, string animal)
        {
            //Implementation.Log("{0} {1} {2} {3} {4} {5}", animal, inst.m_SmellRange, inst.m_DetectionRange, inst.m_DetectionRangeWhileFeeding, inst.m_HearFootstepsRange, inst.m_HearFootstepsRangeWhileFeeding);
            if (Settings.m_animals[animal].enabled)
            {
                if (Settings.m_animals[animal].hear_range_while_feeding >= 0f)
                    inst.m_HearFootstepsRangeWhileFeeding = Settings.m_animals[animal].hear_range_while_feeding;

                if (Settings.m_animals[animal].hear_range >= 0f)
                    inst.m_HearFootstepsRange = Settings.m_animals[animal].hear_range;

                if (Settings.m_animals[animal].detection_range_while_feeding >= 0f)
                    inst.m_DetectionRangeWhileFeeding = Settings.m_animals[animal].detection_range_while_feeding;

                if (Settings.m_animals[animal].detection_range >= 0f)
                    inst.m_DetectionRange = Settings.m_animals[animal].detection_range;

                if (Settings.m_animals[animal].smell_range >= 0f)
                    inst.m_SmellRange = Settings.m_animals[animal].smell_range;
            }
        }
    }
}
