using System.Collections.Generic;

namespace QuiltDesigner.Shared.Models
{
    // A Pattern is the whole quilt layout
    public class Pattern
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Untitled Pattern";

        public int Width { get; set; } = 6;  // number of blocks horizontally
        public int Height { get; set; } = 4; // number of blocks vertically

        public List<Block> Blocks { get; set; } = new List<Block>(); // all blocks in this pattern
    }
}
