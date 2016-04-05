using ImageResizer;

public static void Run(Stream inputStream, Stream outputStream, TraceWriter log)
{
    var job = new ImageResizer.ImageJob(inputStream, outputStream, new Instructions("maxwidth=200;maxheight=200"));

    job.Build();
}