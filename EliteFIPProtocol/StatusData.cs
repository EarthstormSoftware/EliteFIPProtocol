using System;

namespace EliteFIPProtocol {
 
    public class StatusData {

        public DateTime LastUpdate { get; set; }        
        public bool Docked { get; set; }
        public bool Landed { get; set; }
        public bool LandingGearDown { get; set; }
        public bool ShieldsUp { get; set; }
        public bool Supercruise { get; set; }
        public bool FlightAssistOff { get; set; }
        public bool HardpointsDeployed { get; set; }
        public bool InWing { get; set; }
        public bool LightsOn { get; set; }
        public bool CargoScoopDeployed { get; set; }
        public bool SilentRunning { get; set; }
        public bool ScoopingFuel { get; set; }        
        public bool SrvHandbrake { get; set; }
        public bool SrvTurret { get; set; }
        public bool SrvUnderShip { get; set; }
        public bool SrvDriveAssist { get; set; }
        public bool FsdMassLocked { get; set; }
        public bool FsdCharging { get; set; }
        public bool FsdCooldown { get; set; }
        public bool LowFuel { get; set; }
        public bool Overheating { get; set; }
        public bool HasLatLong { get; set; }
        public bool InDanger { get; set; }
        public bool BeingInterdicted { get; set; }
        public bool InMainShip { get; set; }
        public bool InFighter { get; set; }
        public bool InSRV { get; set; }   
        public bool HudAnalysisMode { get; set; }
        public bool NightVision { get; set; }
        public bool AltitudeFromAverageRadius { get; set; }
        public bool FsdJump { get; set; }
        public bool SrvHighBeam { get; set; }

        public int SystemPips { get; set; }
        public int EnginePips { get; set; }
        public int WeaponPips { get; set; }
        public int FireGroup { get; set; }
        public string GuiFocus { get; set; }
        public double FuelMain { get; set; }
        public double FuelResovoir { get; set; }
        public double Cargo { get; set; }
        public string LegalState { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double Heading { get; set; }
        public string BodyName { get; set; }
        public double PlanetRadius { get; set; }
    }
}
