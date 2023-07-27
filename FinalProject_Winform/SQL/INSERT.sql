
INSERT INTO [Order] (ItemId, Order_startDate, Order_endDate, Order_sendDate,Order_status,Order_name,Order_count,Order_Account)
VALUES
(1,GETDATE(),GETDATE()+7,GETDATE()+6,'대기','주문',300,'코리아IT아카데미')

INSERT INTO Process(Process_name, Process_status, Process_checkRight , CheckId)
VALUES ('Mix', 0, 1 , 3 )
INSERT INTO Process(Process_name, Process_status, Process_checkRight)
VALUES ('Shape', 0, 1 )
INSERT INTO Process(Process_name, Process_status, Process_checkRight, CheckId)
VALUES ('Steam', 0, 1 , 2)
INSERT INTO Process(Process_name, Process_status, Process_checkRight, CheckId)
VALUES ('Fry', 0, 1 , 1)
INSERT INTO Process(Process_name, Process_status, Process_checkRight)
VALUES ('Freeze',0, 1 )
INSERT INTO Process(Process_name, Process_status, Process_checkRight, CheckId)
VALUES ('Pack', 0, 1 , 4)

INSERT INTO Stock (ItemId, Stock_Amount, Stock_regDate, Stock_status)
VALUES
(1,300,GETDATE(),'입고')

INSERT INTO Item (Item_name, Item_unit, Item_barcode, Item_type,Item_amount,Item_baseLine)
VALUES
('밀가루', 'G', '8801110000001', '원재료',0,500)
,('반죽', 'G', '8801110000002', '원재료',0,1000)
,('면', 'EA', '8801110000003','반제품',0,100)
,('찐 면', 'EA', '8801110000004', '반제품',0,100)
,('튀긴 면', 'EA', '8801110000005', '반제품',0,100)
,('냉동 면', 'EA', '8801110000006', '반제품',0,100)
,('후레이크', 'EA', '8801110000007', '반제품',0,100)
,('스프', 'EA', '880111000008', '반제품',0,100)
,('포장지', 'EA', '880111000009', '반제품',0,100)
,('팜유','L', '880111000010', '원재료',0,100)
,('라면', 'EA', '8801110000011', '완제품',0,100)

-- STOCK ID값 초기화 +DUMMY -- 
DELETE FROM Stock

DBCC CHECKIDENT(Stock, reseed, 0);

INSERT INTO Stock (ItemId, Stock_Amount, Stock_regDate, Stock_status)
VALUES
(1,300,GETDATE(),'입고')

select * from Process

DELETE FROM Process

-- LOT ID값 초기화 +DUMMY -- 

DELETE FROM Lot

DBCC CHECKIDENT(Lot, reseed, 0);




DBCC CHECKIDENT(Process, reseed, 0);
delete Process

-- ORDER ID값 초기화 + DUMMY -- 

DELETE FROM [Order]

DBCC CHECKIDENT([Order], reseed, 0);

INSERT INTO [Order] (ItemId, Order_startDate, Order_endDate, Order_sendDate,Order_status,Order_name,Order_count,Order_account)
VALUES
(1,GETDATE(),GETDATE()+7,GETDATE()+6,'대기','주문',300,'코리아It아카데미')

select * from [FinalDB].[dbo].[Check]


delete [FinalDB].[dbo].[Check]


INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value)
VALUES ( '용량 검사', '100')
INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value)
VALUES ( '온도 검사', '100')
INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value)
VALUES ( '수량 검사 입고', '50')
INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value)
VALUES ( '수량 검사 출고', '50')