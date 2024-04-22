PRINT 'Seed Table: dbo.AccountType';

MERGE INTO dbo.AccountType AS target
USING (VALUES 
    (1, 'Savings Account', 1),
    (2, 'Checking Account',1),
    (3, '401k', 1),
    (4, 'IRA', 1),
    (4, 'ROTH IRA', 1),
    (4, 'Pension', 1)
) AS source (AccountTypeId, AccountTypeName, IsActive)
ON target.AccountTypeId = source.AccountTypeId
WHEN MATCHED THEN
    UPDATE SET target.AccountTypeName = source.AccountTypeName, target.IsActive = source.IsActive
WHEN NOT MATCHED BY TARGET THEN
    INSERT (AccountTypeId, AccountTypeName, IsActive) VALUES (source.AccountTypeId, source.AccountTypeName, source.IsActive);

PRINT 'Seed Complete: dbo.AccountType';
