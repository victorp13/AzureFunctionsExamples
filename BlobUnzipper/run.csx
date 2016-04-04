#r "Microsoft.WindowsAzure.Storage"
#r "System.IO.Compression"

using Microsoft.WindowsAzure.Storage.Blob;
using System.IO.Compression;

public static void Run(ICloudBlob myBlob, TraceWriter log)
{
    log.Verbose($"Processing ZIP file: {myBlob.Name}");
    
    var stream = new MemoryStream();
    
    myBlob.DownloadToStream(stream);
    
    using(var archive = new ZipArchive(stream, ZipArchiveMode.Read)) 
    {
        foreach (var entry in archive.Entries)
        {
            var newBlob = myBlob.Container.GetBlockBlobReference(entry.Name);

            newBlob.UploadFromStream(entry.Open());
        }
    }
    
    log.Verbose("Finished processing ZIP file.");
}