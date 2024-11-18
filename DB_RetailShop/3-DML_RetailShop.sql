

INSERT INTO PRODUCT (PRODUCT_NAME, PRODUCT_STOCK, PRODUCT_SELL_PRICE, PRODUCT_CATEGORY) VALUES 
('Coca Cola 200ml', 100, 5000, 'Beverages'),
('Sprite 200ml', 150, 4500, 'Beverages'),
('Fanta 200ml', 120, 4500, 'Beverages'),
('Lays Original', 200, 10000, 'Snacks'),
('Doritos Cheese', 150, 12000, 'Snacks'),
('Pringles Salt', 100, 15000, 'Snacks'),
('Milk Full Cream 1L', 80, 20000, 'Dairy'),
('Yogurt Strawberry 200g', 100, 8000, 'Dairy'),
('Detergent Liquid 500ml', 50, 25000, 'Household'),
('Dishwashing Liquid 500ml', 60, 18000, 'Household'),
('Shampoo 300ml', 150, 25000, 'Personal Care'),
('Conditioner 300ml', 120, 22000, 'Personal Care'),
('Toothpaste 150g', 200, 10000, 'Personal Care'),
('Chicken Nuggets 500g', 80, 35000, 'Frozen'),
('Fish Fingers 300g', 70, 30000, 'Frozen'),
('Mars Chocolate 50g', 300, 8000, 'Confectionery'),
('Snickers Chocolate 50g', 300, 8500, 'Confectionery'),
('Twix Chocolate 50g', 250, 8500, 'Confectionery'),
('Canned Tuna 150g', 150, 12000, 'Canned Goods'),
('Canned Beans 300g', 120, 9000, 'Canned Goods');

INSERT INTO EMPLOYEE (EMPLOYEE_NIK, EMPLOYEE_NAME, EMPLOYEE_PHONE, EMPLOYEE_EMAIL, EMPLOYEE_USERNAME, EMPLOYEE_PASSWORD) VALUES
('123456789012341', 'John Doe', '081234567190', 'john.doe@example.com', 'john1', 'password'),
('123456789012342', 'Alice Smith', '081234567290', 'alice.smith@example.com', 'alice1', 'password'),
('123456789012343', 'David Johnson', '081234567390', 'david.johnson@example.com', 'david1', 'password'),
('123456789012344', 'Emily Davis', '081234567490', 'emily.davis@example.com', 'emily1', 'password'),
('123456789012345', 'Michael Brown', '081234567590', 'michael.brown@example.com', 'michael1', 'password');

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



