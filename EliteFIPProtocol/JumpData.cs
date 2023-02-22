using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EliteFIPProtocol {
    public class JumpData {
        public DateTime LastUpdate { get; set; }
        public string OriginSystemId { get; set; }
        public string OriginSystemName { get; set; }        
        public string DestinationSystemId { get; set; }
        public string DestinationSystemName { get; set; }
        public string DestinationSystemClass { get; set; }
        public double JumpDistance { get; init; }
        public double FuelUsed { get; init; }

        public static FIPPacket CreateFIPPacket(JumpData jumpData) {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.Jump.ToString();
            gameData.Data = JsonSerializer.Serialize(jumpData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
