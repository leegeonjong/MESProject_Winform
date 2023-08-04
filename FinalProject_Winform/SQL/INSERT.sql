
INSERT INTO [Order] (ItemId, Order_startDate, Order_endDate, Order_sendDate,Order_status,Order_name,Order_count,Order_Account)
VALUES
(1,GETDATE(),GETDATE()+7,GETDATE()+6,'대기','주문',300,'코리아IT아카데미')

INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value ,Check_Tolerance )
VALUES ( '용량 검사', '100', '0')
INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value,Check_Tolerance)
VALUES ( '온도 검사', '100', '0')
INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value,Check_Tolerance)
VALUES ( '수량 검사 입고', '50', '0')
INSERT INTO [FinalDB].[dbo].[Check] ( Check_item, Check_value,Check_Tolerance)
VALUES ( '수량 검사 출고', '50', '0')

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(1,'123456789',100,'MIXEND',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(1,'123456789',100,'MIXEND',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(1,'123456789',1000,'SteamEnd',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(6,'157845785413',100,'FreezeEnd',1,GETDATE())



UPDATE LOT
SET LOT_STATUS = 'PackEnd'
WHERE Id = 3;

SET ItemId = 11



INSERT INTO Process(Process_name, Process_status, Process_checkRight , CheckId)
VALUES ('Mix', 1, 1 , 3 )
INSERT INTO Process(Process_name, Process_status, Process_checkRight)
VALUES ('Shape', 1, 1 )
INSERT INTO Process(Process_name, Process_status, Process_checkRight, CheckId)
VALUES ('Steam', 1, 1 , 2)
INSERT INTO Process(Process_name, Process_status, Process_checkRight, CheckId)
VALUES ('Fry', 1, 1 , 1)
INSERT INTO Process(Process_name, Process_status, Process_checkRight)
VALUES ('Freeze',1, 1 )
INSERT INTO Process(Process_name, Process_status, Process_checkRight, CheckId)
VALUES ('Pack', 1, 1 , 4)

INSERT INTO Stock (ItemId, Stock_Amount, Stock_regDate, Stock_status)
VALUES
(1,300,GETDATE(),'출고')

INSERT INTO Stock (ItemId, Stock_Amount, Stock_regAmount, Stock_regDate, Stock_status)
VALUES
(11,+100,3400,GETDATE(),'라면 포장')
,(9,-100,200,GETDATE(),'라면 포장')
,(11,-50,300,GETDATE()+1,'출고')
,(11,-70,300,GETDATE(),'출고')
,(11,-30,300,GETDATE()+2,'출고')
,(11,-30,300,GETDATE()+3,'출고')
,(11,-30,300,GETDATE()+4,'출고')



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




UPDATE [FinalDB].[dbo].[Check]
SET Check_Tolerance = 0
WHERE Id IN (1, 2, 3, 4)


-- 발표용--

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(11,'157845485423',100,'PackEnd',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(11,'157845485424',100,'PackEnd',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(11,'157845485425',100,'PackEnd',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(11,'157845485426',100,'PackEnd',1,GETDATE())

INSERT INTO LOT(ItemId,LOT_Barcode,LOT_amount,LOT_STATUS,LOT_BREAK,LOT_REGDATE)
VALUES(11,'157845485427',100,'PackEnd',1,GETDATE())


INSERT INTO [Order] (ItemId, Order_startDate, Order_endDate, Order_sendDate,Order_status,Order_name,Order_count,Order_account)
VALUES
(11,GETDATE()-10,GETDATE()-7,GETDATE()-5,'완료','라면출고1',100,'코리아It아카데미') -- 기한 넘김
,(11,GETDATE()-10,GETDATE()-6,GETDATE()-5,'완료','라면출고2',100,'코리아It아카데미')
,(11,GETDATE()-10,GETDATE()-6,GETDATE()-5,'완료','라면출고3',100,'코리아It아카데미')
,(11,GETDATE()-10,GETDATE()-6,GETDATE()-5,'완료','라면출고4',100,'코리아It아카데미')
,(11,GETDATE()-10,GETDATE()-6,GETDATE()-5,'완료','라면출고5',100,'코리아It아카데미')
,(11,GETDATE()-15,GETDATE()-10,GETDATE()-12,'완료','라면출고6',100,'코리아It아카데미')-- 기한 지킴
,(11,GETDATE()-15,GETDATE()-10,GETDATE()-13,'완료','라면출고7',100,'코리아It아카데미')
,(11,GETDATE()-15,GETDATE()-10,GETDATE()-13,'완료','라면출고8',100,'코리아It아카데미')
,(11,GETDATE()-15,GETDATE()-10,GETDATE()-13,'완료','라면출고9',100,'코리아It아카데미')
,(11,GETDATE()-15,GETDATE()-10,GETDATE()-13,'완료','라면출고10',100,'코리아It아카데미')
,(11,GETDATE(),GETDATE()+10,NULL,'주문 제작 중','라면출고11',100,'코리아It아카데미')--제작 중
,(11,GETDATE(),GETDATE()+10,NULL,'주문 제작 중','라면출고12',100,'코리아It아카데미')
,(11,GETDATE(),GETDATE()+10,NULL,'주문 제작 중','라면출고13',100,'코리아It아카데미')
,(11,GETDATE(),GETDATE()+10,NULL,'주문 제작 중','라면출고14',100,'코리아It아카데미')
,(11,GETDATE(),GETDATE()+10,NULL,'주문 제작 중','라면출고15',100,'코리아It아카데미')

UPDATE Item
SET Item_baseLine = 20000,
 Item_amount = 26000
WHERE Id = 1;

UPDATE Item
SET Item_baseLine = 20000,
 Item_amount = 15000
WHERE Id = 2;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 9000
WHERE ID = 3

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 11000
WHERE ID = 4;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 11000
WHERE ID = 5;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 9000
WHERE ID = 6;


UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 13000
WHERE ID = 7;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 13000
WHERE ID = 8;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 9000
WHERE ID = 9;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 10000
WHERE ID = 10;

UPDATE Item
SET Item_baseLine = 10000
,Item_amount = 8000
WHERE ID = 11;

INSERT INTO Stock (ItemId, Stock_Amount,Stock_regAmount, Stock_regDate, Stock_status)
VALUES
(1,2000,2000,GETDATE()-6,'입고')
,(1,2000,4000,GETDATE()-5,'입고')
,(1,2000,6000,GETDATE()-4,'입고')
,(1,2000,8000,GETDATE()-3,'입고')
,(1,5000,13000,GETDATE()-2,'입고')
,(1,5000,18000,GETDATE()-1,'입고')
,(1,8000,26000,GETDATE(),'입고')

INSERT INTO Stock (ItemId, Stock_Amount,Stock_regAmount, Stock_regDate, Stock_status)
VALUES
(2,2000,2000,GETDATE()-6,'입고')
,(2,2000,4000,GETDATE()-5,'입고')
,(2,-2000,2000,GETDATE()-4,'출고')
,(2,4000,6000,GETDATE()-3,'입고')
,(2,-1000,5000,GETDATE()-2,'출고')
,(2,9000,14000,GETDATE()-1,'입고')
,(2,1000,15000,GETDATE(),'입고')




