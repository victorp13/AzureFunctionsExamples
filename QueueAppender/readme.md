## QueueAppender
This queue trigger will append the queue message to a text file. A valid storage account Name and Key need to be put in this example code. Also the example "logs" container needs to be present in that account.

* Azure Functions does not support AppendBlobs out-of-the-box; related methods are missing
* To solve this a NuGet package of WindowsAzure.Storage is loaded via project.json 
* This code uses AppendBlock over AppendText, because the latter does not support concurrent writes