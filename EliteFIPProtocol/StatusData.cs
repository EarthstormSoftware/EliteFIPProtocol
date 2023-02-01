using System;
using System.Text.Json;

namespace EliteFIPProtocol {
 
    public class StatusData {

        public DateTime LastUpdate { get; set; }
        
        // Flags
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


        // Flags 2
        public bool OnFoot { get; set; }
        public bool InTaxi { get; set; }
        public bool InMulticrew { get; set; }
        public bool OnFootInStation { get; set; }
        public bool OnFootOnPlanet  { get; set; }
        public bool AimDownSight { get; set; }
        public bool LowOxygen { get; set; }
        public bool LowHealth { get; set; }
        public bool Cold { get; set; }
        public bool Hot { get; set; }
        public bool VeryCold { get; set; }
        public bool VeryHot { get; set; }
        public bool GlideMode { get; set; }
        public bool OnFootInHanger { get; set; }
        public bool OnFootSocialSpace { get; set; }
        public bool OnFootExterior { get; set; }
        public bool BreathableAtmosphere { get; set; }


        // Status
        public int SystemPips { get; set; }
        public int EnginePips { get; set; }
        public int WeaponPips { get; set; }
        public int FireGroup { get; set; }
        public string GuiFocus { get; set; }
        public double FuelMain { get; set; }
        public double FuelReservoir { get; set; }
        public double Cargo { get; set; }
        public string LegalState { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double Heading { get; set; }
        public string BodyName { get; set; }
        public double PlanetRadius { get; set; }
        public long Balance { get; set; }
        public string DestinationSystem { get; set; }
        public string DestinationBody { get; set; }
        public string DestinationName { get; set; }
        public double Oxygen { get; set; }
        public double Health { get; set; }
        public double Temperature { get; set; }
        public string SelectedWeapon { get; set; }
        public double Gravity { get; set; }

        public static FIPPacket CreateFIPPacket(StatusData statusData) {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.Status.ToString();
            gameData.Data = JsonSerializer.Serialize(statusData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }

    }
}
