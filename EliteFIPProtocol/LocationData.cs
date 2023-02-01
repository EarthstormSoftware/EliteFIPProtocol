using System;
using System.Text.Json;

namespace EliteFIPProtocol {
    public class LocationData {
        public DateTime LastUpdate { get; set; }
        public string SystemId { get; set; }
        public string SystemName { get; set; }
        public string BodyId { get; set; }
        public string BodyName { get; set; }
        public string MarketId { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }

        public static FIPPacket CreateFIPPacket(LocationData locationData) {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.Location.ToString();
            gameData.Data = JsonSerializer.Serialize(locationData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }

    }
}
