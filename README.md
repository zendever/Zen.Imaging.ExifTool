# Zen.Imaging.ExifTool
C# Wrapper for the ExifTool by Phil Harvey

## Goals
1. A simple API for reading and writing EXIF, IPTC, and XMP tags for photos
2. Provide type-aware references for metadata (i.e. no string parsing for known tag types)

## Approach
This will not be an all encompassing body for all ExifTool functions because, let's face it, ExifTool is HUGE. Furthermore, ExifTool is ever-evolving. This API will incrementally provide the most common functions, and hopefully, at some point in the near future, provide an extensible adapter for functions not coded into the API. Please be patient with its evolution (or help).