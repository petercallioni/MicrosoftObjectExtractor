﻿using System.Collections.Generic;

namespace MicrosoftObjectExtractor.Models.EMF
{
    public class EmfFile
    {
        public EmfFileHeader EmfFileHeader { get; set; }
        public EmfHeader EmfHeader { get; set; }
        public EmfHeaderExtension1 EmfHeaderExtension1 { get; set; }
        public EmfHeaderExtension2 EmfHeaderExtension2 { get; set; }
        public EmfDescriptionBuffer EmfDescriptionBuffer { get; set; }
        public EmfPixelFormatBuffer EmfPixelFormatBuffer { get; set; }
        public List<EmfTextRecord> EmfTextRecords { get; set; }

        public EmfFile()
        {
            EmfFileHeader = new();
            EmfHeader = new();
            EmfDescriptionBuffer = new();
            EmfPixelFormatBuffer = new();
            EmfHeaderExtension1 = new();
            EmfHeaderExtension2 = new();
            EmfDescriptionBuffer = new();
            EmfPixelFormatBuffer = new();
            EmfTextRecords = new();
        }
    }
}