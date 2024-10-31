

INSERT INTO PRODUCT (PRODUCT_ID, PRODUCT_NAME, PRODUCT_STOCK, PRODUCT_SELL_PRICE, PRODUCT_CATEGORY) VALUES 
('BCC0001', 'Coca Cola 200ml', 100, 5000, 'Beverages'),
('BS20001', 'Sprite 200ml', 150, 4500, 'Beverages'),
('BF20001', 'Fanta 200ml', 120, 4500, 'Beverages'),
('SLO0001', 'Lays Original', 200, 10000, 'Snacks'),
('SDC0001', 'Doritos Cheese', 150, 12000, 'Snacks'),
('SPS0001', 'Pringles Salt', 100, 15000, 'Snacks'),
('DMF0001', 'Milk Full Cream 1L', 80, 20000, 'Dairy'),
('DYS0001', 'Yogurt Strawberry 200g', 100, 8000, 'Dairy'),
('HDL0001', 'Detergent Liquid 500ml', 50, 25000, 'Household'),
('HDL0002', 'Dishwashing Liquid 500ml', 60, 18000, 'Household'),
('PS30001', 'Shampoo 300ml', 150, 25000, 'Personal Care'),
('PC30001', 'Conditioner 300ml', 120, 22000, 'Personal Care'),
('PT10001', 'Toothpaste 150g', 200, 10000, 'Personal Care'),
('FCN0001', 'Chicken Nuggets 500g', 80, 35000, 'Frozen'),
('FFF0001', 'Fish Fingers 300g', 70, 30000, 'Frozen'),
('CMC0001', 'Mars Chocolate 50g', 300, 8000, 'Confectionery'),
('CSC0001', 'Snickers Chocolate 50g', 300, 8500, 'Confectionery'),
('CTC0001', 'Twix Chocolate 50g', 250, 8500, 'Confectionery'),
('CCT0001', 'Canned Tuna 150g', 150, 12000, 'Canned Goods'),
('CCB0001', 'Canned Beans 300g', 120, 9000, 'Canned Goods');

INSERT INTO EMPLOYEE (EMPLOYEE_ID, EMPLOYEE_NIK, EMPLOYEE_NAME, EMPLOYEE_PHONE, EMPLOYEE_EMAIL, EMPLOYEE_USERNAME, EMPLOYEE_PASSWORD) VALUES
('JODO001', '123456789012341', 'John Doe', '081234567190', 'john.doe@example.com', 'john1', 'password'),
('ALSM001', '123456789012342', 'Alice Smith', '081234567290', 'alice.smith@example.com', 'alice1', 'password'),
('DAJO001', '123456789012343', 'David Johnson', '081234567390', 'david.johnson@example.com', 'david1', 'password'),
('EMDA001', '123456789012344', 'Emily Davis', '081234567490', 'emily.davis@example.com', 'emily1', 'password'),
('MIBR001', '123456789012345', 'Michael Brown', '081234567590', 'michael.brown@example.com', 'michael1', 'password');

INSERT INTO SALES (SALES_ID, EMPLOYEE_ID, SALES_DATE) VALUES
('N241013001', 'JODO001', '2024-10-13'),
('N241014001', 'JODO001', '2024-10-14'),
('N241014002', 'JODO001', '2024-10-14'),
('N241015001', 'JODO001', '2024-10-15'),
('N241016001', 'JODO001', '2024-10-16');

INSERT INTO SALES_DETAIL (SALES_ID, PRODUCT_ID, SALES_QTY) VALUES
('N241013001', 'PC30001', 13),
('N241013001', 'PT10001', 5),
('N241014001', 'DYS0001', 5),
('N241014001', 'HDL0001', 10),
('N241014001', 'HDL0002', 5),
('N241014001', 'PS30001', 10),
('N241014002', 'DMF0001', 8),
('N241015001', 'SDC0001', 5),
('N241015001', 'SPS0001', 5),
('N241016001', 'BS20001', 15),
('N241016001', 'BF20001', 5),
('N241016001', 'SLO0001', 10);



