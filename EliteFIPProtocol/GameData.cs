namespace EliteFIPProtocol {

    public enum GameDataType {
        Status,
        Target,
        Location,
        Navigation,
        Jump
    }

    public class GameData {

        public string Type { get; set; }
        public string Data { get; set; }
    }
}
