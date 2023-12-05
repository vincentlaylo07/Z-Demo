-- Tasks Table
CREATE TABLE [dbo].[Tasks] (
    [TaskId] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    [TaskName] VARCHAR(50) NOT NULL
);

-- TimeRecords Table
CREATE TABLE [dbo].[TimeRecords] (
    [RecordId] INT IDENTITY(1, 1) NOT NULL,
    [TaskId] INT NOT NULL,
    [CurrentDate] DATE NOT NULL,
    [StartTime] TIME (7) NOT NULL,
    [FinishTime] TIME (7) NOT NULL,
    [SpentTime] TIME (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([RecordId] ASC),
    FOREIGN KEY ([TaskId]) REFERENCES [dbo].[Tasks]([TaskId])
);

-- PomodoroSessions Table
CREATE TABLE [dbo].[PomodoroSessions] (
    [PomodoroId] INT IDENTITY(1, 1) NOT NULL,
    [TaskId] INT NOT NULL,
    [PomodoroCount] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PomodoroId] ASC),
    FOREIGN KEY ([TaskId]) REFERENCES [dbo].[Tasks]([TaskId])
);