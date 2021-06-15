# DotNet-Desktop-Apps

N-tier data applications are applications that access data and are separated into multiple logical layers, or tiers. Separating application components into discrete tiers increases the maintainability and scalability of the application. It does this by enabling easier adoption of new technologies that can be applied to a single tier without requiring you to redesign the whole solution. N-tier architecture includes a presentation tier, a middle-tier, and a data tier. The middle tier typically includes a data access layer, a business logic layer, and shared components such as authentication and validation. The data tier includes a relational database. N-tier applications usually store sensitive information in the data access layer of the middle-tier to maintain isolation from end users who access the presentation tier. For more information, see N-tier data applications overview.

This project contains:
 * a typed dataset (the generated TableAdapters and dataset code are separated into discrete projects),
 * a Windows Communication Foundation (WCF) service to call into the data access tier (functions in the service retrieve data from the data access tier),
 * a Windows Forms application to serve as the presentation tier (Windows Forms controls that are bound to the data source).
