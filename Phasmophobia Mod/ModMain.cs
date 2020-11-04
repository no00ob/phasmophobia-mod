using System;
using MelonLoader;
using UnityEngine;

namespace Phasmophobia_Mod
{
    public class ModMain : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Log("Phasmophobia 8 player mod loaded!");
        }
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                MelonLogger.Log("Debug Test. You pressed the 'P' key.");
            }
        }
    }
}
