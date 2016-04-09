# Azure Functions Examples

This repository contains Azure Functions sample code. They can easily be loaded by setting up Continuous Integration to your own source code repository. For each example the relevant connections will need to be set up manually in the "Integrate" tab of the function app.

## HelloWorld
This HTTP trigger shows examples of how to access the requested uri, headers and querystring. It checks for the existence of a 'name' query string parameter and, if present, will output it in the response.

## BlobUnzipper
This blob trigger will perform an in-memory root level extraction of a ZIP archive.

* Increase Memory Size in Function App Settings for larger ZIP files
* This example code only extracts the root folder of the ZIP file
* Destination is set to the same container that triggers the code

## ThumbGenerator
This blob trigger will perform an image resize using the NuGet package ImageResizer.

* It demonstrates directly interacting with an input stream and an output stream
* The project.json file is required to load the NuGet package