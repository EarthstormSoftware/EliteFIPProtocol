using System;

namespace EliteFIPProtocol {
 
    public class StatusData {

        public DateTime LastUpdate { get; set; }        
        public bool LandingGearDown { get; set; }
        public bool HardpointsDeployed { get; set; }
        public bool LightsOn { get; set; }
        public bool CargoScoopDeployed { get; set; }
        public bool SilentRunning { get; set; }
        public bool NightVision { get; set; }
        public bool HudAnalysisMode { get; set; }
        public bool InMainShip { get; set; }
        public bool InFighter { get; set; }
        public bool ShieldsUp { get; set; }
        public int SystemPips { get; set; }
        public int EnginePips { get; set; }
        public int WeaponPips { get; set; }
        public int FireGroup { get; set; }
        public int GuiFocus { get; set; }
        public double FuelMain { get; set; }
        public double FuelResovoir { get; set; }
        public double Cargo { get; set; }
        public string LegalState { get; set; }
        public string BodyName { get; set; }
    }
}
