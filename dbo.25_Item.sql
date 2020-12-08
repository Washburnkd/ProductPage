CREATE TABLE [dbo].[25 Item] (
    [IID]            INT             IDENTITY (1, 1) NOT NULL,
    [AID]            INT             NOT NULL,
    [OID]            INT             NOT NULL,
    [Default]        BIT             NULL,
    [Enable]         BIT             NULL,
    [Selections]     NVARCHAR (100)  NULL,
    [InventoryID]    NVARCHAR (100)  NULL,
    [ScanID]         INT             NULL,
    [Title]          NVARCHAR (100)  NULL,
    [MSRP]           MONEY           NULL,
    [Price]          MONEY           NULL,
    [Weight]         FLOAT (53)      NULL,
    [Body]           NVARCHAR (100)  NULL,
    [Count]          INT             NULL,
    [SellIfOut]      BIT             NULL,
    [LeadTime]       FLOAT (53)      NULL,
    [ReorderTrigger] INT             NULL,
    [ReorderLink]    NVARCHAR (100)  NULL,
    [SOP]            NVARCHAR (1000) NULL,
    [Notes]          NTEXT           NULL,
    PRIMARY KEY CLUSTERED ([IID] ASC)
);

