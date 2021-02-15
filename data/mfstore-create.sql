CREATE TABLE "Order" (
OrderId integer PRIMARY KEY AUTOINCREMENT,
CreatedDate real,
Total real
);

INSERT INTO "Order" (CreatedDate, total) values ('2015-02-14', 1.00);
INSERT INTO "Order" (CreatedDate, total) values ('2015-01-13', 51.00);
INSERT INTO "Order" (CreatedDate, total) values ('2017-09-01', 111.00);
INSERT INTO "Order" (CreatedDate, total) values ('2017-09-01', 222.00);
INSERT INTO "Order" (CreatedDate, total) values ('2017-09-01', 9.00);


CREATE TABLE "Payment" (
PaymentId integer PRIMARY KEY AUTOINCREMENT,
OrderId integer,
Amount real,
CreatedDate real,
FOREIGN KEY(OrderId) REFERENCES "Order"(OrderId)
);

INSERT INTO "Payment" (OrderId, Amount, CreatedDate) values (3, 41.0, datetime('now'));
INSERT INTO "Payment" (OrderId, Amount, CreatedDate) values (3, 10.0, datetime('now'));

INSERT INTO "Payment" (OrderId, Amount, CreatedDate) values (4, 50.0, datetime('now'));

INSERT INTO "Payment" (OrderId, Amount, CreatedDate) values (5, 100.0, datetime('now'));
INSERT INTO "Payment" (OrderId, Amount, CreatedDate) values (5, 100.0, datetime('now'));
INSERT INTO "Payment" (OrderId, Amount, CreatedDate) values (6, 9.0, datetime('now'));

CREATE TABLE "Item" (
ItemId integer PRIMARY KEY AUTOINCREMENT,
Name text,
Cost real
);

INSERT INTO "Item" (Name, Cost) values ("Widget1", 1.00);
INSERT INTO "Item" (Name, Cost) values ("Widget2", 5.00);
INSERT INTO "Item" (Name, Cost) values ("Widget3", 11.00);
INSERT INTO "Item" (Name, Cost) values ("Widget4", 41.00);
INSERT INTO "Item" (Name, Cost) values ("Widget5", 111.00);

CREATE TABLE OrderItem (
OrderItemId integer PRIMARY KEY AUTOINCREMENT,
OrderId integer,
ItemId integer,
FOREIGN KEY(OrderId) REFERENCES "Order"(OrderId),
FOREIGN KEY(ItemId) REFERENCES "Item"(ItemId)
);

INSERT INTO "OrderItem" ("OrderId", ItemId) values (2, 1);

INSERT INTO "OrderItem" ("OrderId", ItemId) values (3, 2);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (3, 2);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (3, 4);

INSERT INTO "OrderItem" ("OrderId", ItemId) values (4, 5);

INSERT INTO "OrderItem" ("OrderId", ItemId) values (5, 5);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (5, 5);

INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);
INSERT INTO "OrderItem" ("OrderId", ItemId) values (6, 1);