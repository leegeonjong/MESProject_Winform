--DELETE--
DELETE FROM Item;

DBCC CHECKIDENT(Item, reseed, 0);
----------------------------------
DELETE FROM Stock

DBCC CHECKIDENT(Stock, reseed, 0);

--------------------------------------
DELETE FROM LOT
DBCC CHECKIDENT(Lot, reseed, 0);

DBCC CHECKIDENT(LotHistory, reseed, 0);
delete LotHistory


DBCC CHECKIDENT(Process, reseed, 0);
delete Process


DELETE FROM [Order]

DBCC CHECKIDENT([Order], reseed, 0);