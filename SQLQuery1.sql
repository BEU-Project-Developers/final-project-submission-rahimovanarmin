SELECT TaskTitle, DueDate, Importance, Status
FROM Taskss
WHERE CONVERT(DATE, ReminderDate) = CAST(GETDATE() AS DATE)
