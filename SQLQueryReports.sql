/** Report 1 Groupby num of car types with avg miles**/

select T_ID as Type, count(Car_ID) as Cars, avg(mileage) as AvgMile from Cars 
group by T_ID;

/** Report 2 Groupby cars and  with reservations B_pickup != B_return**/

select Cars.Car_ID, count(Reservation.R_ID) as NumOfRes from Reservation, Cars, Customer 
where Reservation.Car_ID = Cars.Car_ID and Reservation.C_ID = Customer.C_ID
and B_pickup_ID != B_Return_ID
group by Cars.Car_ID;

/** Report 3 Groupby customers with the same area code **/

select temp.areacode, count (*) as total from
(select substring(Phone_No, 1, 3) as areacode from Customer, Phone
where Customer.C_ID = Phone.C_ID) as temp
group by temp.areacode;

/** Report 4 Nested cars where **/

select * from Employees where salary > (select avg(salary) from Employees);

/** Report 5 Nested list employees where there salary is greater than renting a sports car for 1 year**/

select Employees.E_ID, Employees.f_name, Employees.l_name from Reservation, Employees, Cars, Type 
where Reservation.E_ID = Employees.E_ID and Reservation.Car_ID = Cars.Car_ID and Type.T_ID = Cars.T_ID
and salary > (select month_price from Type where T_ID = 'Sports Car')*12;