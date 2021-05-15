namespace EliteFIPProtocol {

    public enum PacketType {
        Register,
        GameData,
        Action,
        Ping,
        Pong
    }

    public class FIPPacket {
        
        public string ClientId { get; set; }
        public string PacketType { get; set; }
        public string Payload { get; set; }
    }
}
