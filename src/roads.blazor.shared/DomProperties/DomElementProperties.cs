namespace roads.blazor.shared.DomProperties
{

    public class WindowProperties
    {
        public float WindowHeight { get; set; }
        public float WindowWidth { get; set; }
    }
    public class DomElementProperties
    {
        public WindowProperties WindowProperties { get; set; }
        public float AbsoluteTop { get; set; }
        public float AbsoluteLeft { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

    }
}