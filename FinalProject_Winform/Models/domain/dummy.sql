-- SELECT --

SELECT * FROM Item;
SELECT * FROM Stock;


-- ITEM 테이블 ID값 초기화 DUMMY --
DELETE FROM Item;

DBCC CHECKIDENT(Item, reseed, 0);

INSERT INTO Item (Item_name, Item_unit, Item_barcode, Item_type,Item_amount,Item_baseLine)
VALUES
('밀가루', 'KG', '8801110000001', '원재료',0,500)
,('물', 'L', '8801110000002', '원재료',0,500)
,('반죽', 'KG', '8801110000003', '원재료',0,1000)
,('면', 'EA', '8801110000004','반제품',0,100)
,('팜유', 'L', '8801110000005', '원재료',0,500)
,('찐 면', 'EA', '8801110000006', '반제품',0,100)
,('튀긴 면', 'EA', '8801110000007', '반제품',0,100)
,('냉동 면', 'EA', '8801110000008', '반제품',0,100)
,('후레이크', 'EA', '8801110000009', '반제품',0,100)
,('스프', 'EA', '8801110000010', '반제품',0,100)
,('포장지', 'EA', '8801110000011', '반제품',0,100)
,('라면', 'EA', '8801110000012', '완제품',0,100)

-- STOCK ID값 초기화 +DUMMY -- 
DELETE FROM Stock

DBCC CHECKIDENT(Stock, reseed, 0);

INSERT INTO Stock (ItemId, Stock_Amount, Stock_regDate, Stock_status)
VALUES
(1,300,GETDATE(),'입고')

-- ORDER ID값 초기화 + DUMMY -- 

DELETE FROM [Order]

DBCC CHECKIDENT([Order], reseed, 0);

INSERT INTO [Order] (ItemId, Order_startDate, Order_endDate, Order_sendDate,Order_status,Order_name,Order_count)
VALUES
(1,GETDATE(),GETDATE()+7,GETDATE()+6,'대기','주문',300)

