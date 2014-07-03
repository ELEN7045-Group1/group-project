public enum ScheduleErrorType
{
    ScraperError,
    APSError,
    NoNewStatementError
}

public enum StatementTypesList
{
    Municipalities,
    CreditCardProviders,
    TelcoServicesProviders
}

public enum ScrapeTaskStatus
{
    Pending,
    Busy,
    Completed,
    Failed
}