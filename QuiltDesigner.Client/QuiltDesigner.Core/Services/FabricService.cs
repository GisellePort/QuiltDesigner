using System.Collections.Generic;
using QuiltDesigner.Shared.Models;

namespace QuiltDesigner.Core.Services
{
    // FabricService keeps track of all fabrics in memory
    public class FabricService
    {
        private readonly List<Fabric> _fabrics = new List<Fabric>();

        // Get all fabrics
        public List<Fabric> GetAllFabrics()
        {
            return _fabrics;
        }

        // Add a new fabric
        public void AddFabric(Fabric fabric)
        {
            _fabrics.Add(fabric);
        }

        // Find a fabric by its Id
        public Fabric? GetFabricById(string id)
        {
            return _fabrics.Find(f => f.Id == id);
        }
    }
}
