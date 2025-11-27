namespace QuiltDesigner.Shared.Models
{
    // Fabric stores the picture you want to use
    public class Fabric
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "New Fabric";

        // Image stored as Data URL (base64 string)
        public string ImageDataUrl { get; set; } = "";

        public string? Notes { get; set; } // optional notes about this fabric
    }
}
