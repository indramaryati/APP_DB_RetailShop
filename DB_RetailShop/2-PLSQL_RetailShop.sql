/*==============================================================*/
/* VIEWS                                                        */
/*==============================================================*/
-- drop view if exists vDaftarTransaksiSukses;
create or replace view vDaftarTransaksiSukses as
select s.sales_id, s.employee_id, e.employee_name, s.sales_date, s.sales_total, s.sales_item_count, s.sales_payment_method,
       sd.product_id, p.product_name, sd.sales_qty, sd.sales_price, (sd.sales_qty * sd.sales_price) as sales_subtotal
from SALES s
right join SALES_DETAIL sd
on s.sales_id = sd.sales_id
left join PRODUCT p
on p.product_id = sd.product_id
left join EMPLOYEE e
on e.employee_id = s.employee_id
where upper(sales_status) <> 'PENDING'
order by s.sales_id;

-- drop view if exists vPerformaEmployee;
create or replace view vPerformaEmployee as
select e.employee_id, e.employee_name, ifnull(count(s.employee_id),0) as sales_count, ifnull(sum(s.sales_total),0) as sales_sum
from EMPLOYEE e
left join (select * from SALES where sales_status='COMPLETED') s
on s.employee_id = e.employee_id
group by e.employee_id
order by e.employee_id;

-- drop view if exists vPerformaProduct;
create or replace view vPerformaProduct as
select p.product_id, p.product_name, p.product_category, 
       ifnull(sum(sd.sales_qty), 0) as product_sales_sum
from product p
left join (select sdlm.* 
           from SALES_DETAIL sdlm
           join SALES s on s.sales_id = sdlm.sales_id
           where s.sales_status='COMPLETED') sd
on sd.product_id = p.product_id
group by p.product_id
order by p.product_id;

-- drop view if exists vPenjualan;
create or replace view vPenjualan as
SELECT s.sales_id, s.sales_status, s.employee_id, e.employee_name, s.sales_date, format(sales_total ,0) as sales_total, s.sales_payment_method
FROM sales s
join employee e
on e.employee_id = s.employee_id;

/*==============================================================*/
/* FUNCTION FOR GENERATE KEY                                      */
/*==============================================================*/
drop function if exists fGenProductID;
delimiter $$
create function fGenProductID(parCat varchar(25), parName varchar(100))
returns varchar(7) -- 1 digit category, 1digit nama depan, 1 digit belakang, 4 urut. Beverage | Big Cola 200ml -> BBC0001
deterministic
begin
  declare tempID varchar(7);
  
  set tempId = upper(concat(left(parCat,1),left(substring_index(parName, ' ', 1),1) , left(substring_index(substring_index(parName, ' ', 2), ' ', -1),1)));
  
  select concat(tempId,lpad(ifnull(convert(substr(max(product_id),4,4),unsigned),0)+1,4,'0')) into tempId
  from product
  where left(product_id,3) = tempId;
    
  return tempId;
end$$
delimiter ;

-- select fGenProductID('Beverages','Big Cola 200ml');

drop function if exists fGenEmployeeID;
delimiter $$
create function fGenEmployeeID(parName varchar(100))
returns varchar(7) -- 2 digit nama depan, 2 digit belakang, 3 digit urutan
deterministic
begin
  declare tempID varchar(7);
  
  set tempId = upper(concat(left(substring_index(parName, ' ', 1),2) , left(substring_index(substring_index(parName, ' ', 2), ' ', -1),2)));
  
  select concat(tempId,lpad(ifnull(convert(substr(max(employee_id),5,3),unsigned),0)+1,3,'0')) into tempId
  from employee
  where left(employee_id,4) = tempId;
    
  return tempId;
end$$
delimiter ;

 -- select fGenEmployeeId('John Trap');

drop function if exists fGenSalesID; -- N241013001
delimiter $$
create function fGenSalesID()
returns varchar(10)
deterministic
begin
  declare tempID varchar(10);
  
  set tempId = concat('N',date_format(current_date(),'%y%m%d'));
  
  select concat(tempId,lpad(ifnull(convert(substr(max(sales_id),8,3),unsigned),0)+1,3,'0')) into tempId
  from sales
  where left(sales_id,7) = tempId;
    
  return tempId;
end$$
delimiter ;

-- select fGenSalesID();

-- -----------------------------------------------------------------

drop trigger if exists tInsEmployee;
delimiter $$
create trigger tInsEmployee
before insert on employee
for each row
begin
	set new.employee_join_date = now();
  set new.employee_id = fGenEmployeeId(new.employee_name);
  set new.employee_password = md5(new.employee_password);
end$$
delimiter ;

drop function if exists fCheckLogin;
delimiter //
create function fCheckLogin(parUser varchar(20), parPass varchar(255))
returns varchar(7)
deterministic
begin
  declare tempID varchar(7);
  set tempID = '';
  
  select employee_id into tempID
  from EMPLOYEE
  where employee_username = parUser and employee_password = md5(parPass);
  
  return tempID;
end//
delimiter ;

 select fCheckLogin('john1','password');

/*==============================================================*/
/* PROCEDURE for view data on HISTORY_PRODUCT_PRICE and have id */
/*==============================================================*/
drop procedure if exists pViewPriceHistory;
delimiter $$
create procedure pViewPriceHistory(in parID varchar(7))
begin
  if parID = 'ALL' then
    select date_format(h.his_date,'%Y-%m-%d') as change_date, h.product_id, p.product_name, format(h.his_price_before,0) as p_before, format(h.his_price_after,0) as p_after, e.employee_name as changed_by
    from history_product_price h
    join employee e on e.employee_id = h.employee_id
    join product p on p.product_id = h.product_id
    order by h.his_date desc, h.product_id;
  else
    select date_format(h.his_date,'%Y-%m-%d') as change_date, h.product_id, p.product_name, format(h.his_price_before,0) as p_before, format(h.his_price_after,0) as p_after, e.employee_name as changed_by
    from history_product_price h
    join employee e on e.employee_id = h.employee_id
    join product p on p.product_id = h.product_id
    where h.product_id = parID
    order by h.his_date desc, h.product_id;
  end if;
end $$
delimiter ;


/*==============================================================*/
/* TRIGGER for CHECK INPUT before insert PRODUCT table          */
/*==============================================================*/
/* SAFE STOCK
Beverages: 10 | Snacks: 10 | Dairy: 10 | Household: 3 | 
Personal Care: 5 | Frozen: 10 | Confectionery: 10 | Canned Goods: 5
*/
drop trigger if exists tInsProduct;
delimiter $$
create trigger tInsProduct
before insert on product
for each row
begin
  set new.product_id = fGenProductID(new.product_category, new.product_name);
  
  case lower(new.product_category)
    when 'household' then set new.product_safe_stock = 3;
    when 'personal care' then set new.product_safe_stock = 5;
    when 'canned goods' then set new.product_safe_stock = 5;
    else set new.product_safe_stock = 10;
  end case;
end$$
delimiter ;

/*==============================================================*/
/* TRIGGER dan PROCEDURE for input data on HISTORY_PRODUCT_PRICE  */
/*==============================================================*/
drop trigger if exists tUpdateProductPrice;
delimiter $$
create trigger tUpdateProductPrice 
before update on product 
for each row
begin  
  if old.product_sell_price <> new.product_sell_price then
    INSERT INTO HISTORY_PRODUCT_PRICE (product_id,employee_id,his_price_before, his_price_after) VALUES
			(new.product_id, 'JODO001', old.product_sell_price, new.product_sell_price);
  end if;
  set new.product_last_update = now();
end$$
delimiter ;

drop procedure if exists pUpdEmpID;
delimiter $$
create procedure pUpdEmpID(in parEmpID varchar(7))
begin
  declare lastID int;
  
  select max(his_price_change_id) into lastID
	from history_product_price;
  
  update history_product_price
  set employee_id = parEmpId
  where his_price_change_id = lastID;
end $$
delimiter ;

/*========================================================================*/
/* TRIGGER for minus PRODUCT_STOCK if there's new data in SALES_DETAIL    */
/* ALSO WILL UPDATE SALES_PRICE with PRODUCT_SELL_PRICE                   */
/*========================================================================*/
drop trigger if exists tUpdProductStockPrice;
delimiter ||
create trigger tUpdProductStockPrice
before insert on sales_detail
for each row
begin
  declare curStock, prodPrice int;
  
  select product_stock, product_sell_price into curStock, prodPrice
  from product
  where product_id = new.product_id;
  
  -- update the product_stock
  update product
  set product_stock = curStock - new.sales_qty
  where product_id = new.product_id;
  
  -- update sales price = product_sell_price
  set new.sales_price = prodPrice;
end ||
delimiter ;

/*========================================================================*/
/* TRIGGER for update SALES (header) if PAYMENT is DONE                 */
/*========================================================================*/
drop trigger if exists tUpdHeaderSales;
delimiter ||
create trigger tUpdHeaderSales
before update on sales
for each row
begin
  declare itemSales, totSales int;
  
  -- utk get item_count, total_sales
  select count(detail_sales_id), sum(sales_qty * sales_price) into itemSales, totSales
  from sales_detail
  where sales_id = new.sales_id
  group by sales_id;
  
  set new.sales_total = totSales;
  set new.sales_item_count = itemSales;
  set new.sales_date = now();
  
  if new.sales_payment_method <> 'N/A' then
    set new.sales_status = 'COMPLETED';
  end if;
end ||
delimiter ;
