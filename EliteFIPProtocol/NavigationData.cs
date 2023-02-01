using System;
using System.Collections.Generic;
using System.Text.Json;


namespace EliteFIPProtocol {
    public class NavigationData {
        public DateTime LastUpdate { get; set; }
        public bool NavRouteActive { get; set; }

        public List<NavRouteStop> Stops { get; set; }        

        public class NavRouteStop {
            public string SystemId { get; set; }
            public string SystemName { get; set; }
            public string Class { get; set; }

        }

        public static FIPPacket CreateFIPPacket(NavigationData navigationData) {

            GameData gameData = new GameData();
            gameData.Type = GameDataType.Navigation.ToString();
            gameData.Data = JsonSerializer.Serialize(navigationData);

            FIPPacket packet = new FIPPacket();
            packet.PacketType = PacketType.GameData.ToString();
            packet.Payload = JsonSerializer.Serialize(gameData);
            return packet;
        }
    }
}
