## TriggerStoredProcedure
This timer trigger will execute a SQL Stored Procedure every 5 minutes. This timing is dictated by the Cron expression in Schedule on the Integrate tab.

In this particular example, DeleteExpiredSessions is called which cleans up expired session state of Sitecore on Azure SQL databases. Azure SQL does not have a SQL Agent running to do this job. [note: untested]

The SQL connection string (named "ASPState" in this example) can be set using Function App Settings -> Go to App Service Settings -> Application Settings -> Connection Strings.