--DELETE--
DELETE FROM Item;

DBCC CHECKIDENT(Item, reseed, 0);
----------------------------------
DELETE FROM Stock

DBCC CHECKIDENT(Stock, reseed, 0);

--------------------------------------
DELETE FROM LOT
DELETE FROM LOT where id = '1';
DELETE FROM LOT where id = '2';
DELETE FROM LOT where id = '3';
DELETE FROM LOT where id = '4';
DELETE FROM LOT where id = '5';
DELETE FROM LOT where id = '6';

DBCC CHECKIDENT(Lot, reseed, 0);
-------------------------------------------
DBCC CHECKIDENT(LotHistory, reseed, 0);
delete LotHistory
-------------------------------------------

DELETE FROM Process
DBCC CHECKIDENT(Process, reseed, 0);
-------------------------------------------
DELETE FROM [Order]
DBCC CHECKIDENT([Order], reseed, 0);
-------------------------------------------
DELETE FROM [CHECK]
DBCC CHECKIDENT([CHECK], reseed, 0);


DELETE FROM [LotHistory]