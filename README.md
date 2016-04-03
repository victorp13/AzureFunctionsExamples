# Azure Functions Examples

This repository contains Azure Functions sample code. For starters: A blob trigger that unzips a ZIP file upon it being saved.

## Blob Unzipper
This blob trigger will perform an in-memory root level extraction of a ZIP archive. Words of caution: 
* Memory may be a constraint
* This example code does not traverse folders
* Destination is set to the same container that triggers the code

Still, a nifty piece of code that removes complexity when uploading files.