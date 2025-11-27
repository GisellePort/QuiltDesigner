using System;

namespace QuiltDesigner.Shared.Models
{
    // A Block is one tile in the pattern grid
    public class Block
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); // unique ID
        public BlockType Type { get; set; } = BlockType.Square;     // shape

        public int X { get; set; } = 0; // horizontal position in grid
        public int Y { get; set; } = 0; // vertical position in grid

        public string? FabricId { get; set; } // which fabric is on this block
        public int Rotation { get; set; } = 0; // 0, 90, 180, 270
    }
}
