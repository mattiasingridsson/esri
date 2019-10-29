using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Application.Layers.Models
{
    public class MapDto
    {
        public double currentVersion { get; set; }
        public string serviceDescription { get; set; }
        public string mapName { get; set; }
        public string description { get; set; }
        public string copyrightText { get; set; }
        public List<LayersItem> layers { get; set; }
        public List<string> tables { get; set; }
        public SpatialReference spatialReference { get; set; }
        public string singleFusedMapCache { get; set; }
        public Extent initialExtent { get; set; }
        public Extent fullExtent { get; set; }
        public string units { get; set; }
        //Kommaseparerad sträng
        public string supportedImageFormatTypes { get; set; }
        public DocumentInfo documentInfo { get; set; }
        //Står ej omnämnd i dokumentationen men fanns med i REST-svaret från servern
        //Också en kommaseparerad sträng
        public string capabilities { get; set; }
    }

    public class LayersItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int parentLayerId { get; set; }
        public string defaultVisibility { get; set; }
        //Kommaseparerad lista 
        public string subLayerIds { get; set; }
        public double minScale { get; set; }
        public int maxScale { get; set; }
    }

    public class SpatialReference
    {
        public int wkid { get; set; }
    }

    public class Extent
    {
        public double xmin { get; set; }
        public double ymin { get; set; }
        public double xmax { get; set; }
        public double ymax { get; set; }
        public SpatialReference spatialReference { get; set; }
    }

    public class DocumentInfo
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Comments { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public string Keywords { get; set; }
        public string Credits { get; set; }
    }
}
