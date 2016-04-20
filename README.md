# Azure Functions Examples

This repository contains Azure Functions sample code. They can easily be loaded by setting up Continuous Integration to your own source code repository. For each example the relevant connections will need to be set up manually in the "Integrate" tab of the function app.

## BlobUnzipper
This blob trigger will perform an in-memory root level extraction of a ZIP archive.

* Increase Memory Size in Function App Settings for larger ZIP files
* This example code only extracts the root folder of the ZIP file
* Destination is set to the same container that triggers the code

## HelloWorld
This HTTP trigger shows examples of how to access the requested uri, headers and querystring. It checks for the existence of a 'name' query string parameter and, if present, will output it in the response.

## PSConsoleApp
This timer trigger every minute loads a PowerShell script that runs an .exe file. This executable is placed with the function; a simple console app that just posts a line to the log. Code below:

```c#
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

## QueueAppender
This queue trigger will append the queue message to a text file. A valid storage account Name and Key need to be put in this example code. Also the example "logs" container needs to be present in that account.

* Azure Functions does not support AppendBlobs out-of-the-box; related methods are missing
* To solve this a NuGet package of WindowsAzure.Storage is loaded via project.json 
* This code uses AppendBlock over AppendText, because the latter does not support concurrent writes

## ThumbGenerator
This blob trigger will perform an image resize using the NuGet package ImageResizer.

* It demonstrates directly interacting with an input stream and an output stream
* The project.json file is required to load the NuGet package