CREATE TABLE [dbo].[tblReviews]
(
	[ReviewNo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductID] INT NOT NULL, 
    [CustomerID] INT NOT NULL, 
    [DatePosted] DATE NOT NULL, 
    [ReviewTitle] VARCHAR(50) NOT NULL, 
    [ReviewDescription] VARCHAR(MAX) NULL, 
    [PositiveReview] BIT NOT NULL
)
