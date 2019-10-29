namespace CodingTest.Domain.Entities
{
    /// <summary>
    /// The extent (bounding box) of the exported image. 
    /// Unless the bboxSR parameter has been specified, 
    /// the bbox is assumed to be in the spatial reference of the map.
    /// </summary>
    public class BoundingBox
    {
        public int XMin { get; set; }
        public int YMin { get; set; }
        public int XMax { get; set; }
        public int YMax { get; set; }
    }
}
