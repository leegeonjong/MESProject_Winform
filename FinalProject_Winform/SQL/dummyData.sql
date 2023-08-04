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

