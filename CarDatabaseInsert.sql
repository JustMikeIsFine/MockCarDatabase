USE [Car_Rental_Service]

/** Reservation **/
Insert into Reservation Values (001, '2010-01-15', '2010-01-17', 001, 001, 002, 001, 001);
Insert into Reservation Values (002, '2012-04-20', '2013-01-04', 001, 002, 001, 005, 001);
Insert into Reservation Values (003, '2013-09-13', '2013-11-30', 002, 003, 003, 005, 003);
Insert into Reservation Values (004, '2010-12-15', '2011-02-13', 003, 003, 004, 003, 002);
Insert into Reservation Values (005, '2011-01-15', '2011-06-25', 003, 001, 004, 002, 004);

/** Branch **/
Insert into Branch Values (001, 35, 'Albertson', 'Edmonton', 'Alberta', 'T4X 4L8');
Insert into Branch Values (002, 85, 'Davison', 'Toronto', 'Ontario', 'F38 9E3');
Insert into Branch Values (003, 111, 'Madison', 'Vancouver', 'British Columbia', 'E4M 6P9');

/** Employees **/
Insert into Employees Values (001, 'John', 'Marston', 80000, 536721784);
Insert into Employees Values (002, 'Sherry', 'Birken', 70000, 414309259);
Insert into Employees Values (003, 'Luis', 'Sera', 65000, 875076276);
Insert into Employees Values (004, 'Arthur', 'Morgan', 90000, 727473411);

/** Type **/
Insert into Type Values ('Sedan', 90, 630, 2700);
Insert into Type Values ('SUV', 120, 840, 3600);
Insert into Type Values ('Sports Car', 160, 1120, 4800);

/** Cars **/
Insert into Cars Values (001, 2008, 'Nissan', 'Altima', '2010-06-03', 50000, 'bad', 'manual', 'Sedan');
Insert into Cars Values (002, 2018, 'Dodge', 'Charger', '2020-04-14', 12000, 'good', 'auto', 'Sports Car');
Insert into Cars Values (003, 2007, 'Chevrolet', 'Silverado', '2010-11-14', 55000, 'bad', 'manual', 'Sedan');
Insert into Cars Values (004, 2003, 'Jeep', 'Wrangler', '2005-06-16', 70000, 'bad', 'auto', 'SUV');
Insert into Cars Values (005, 2015, 'Toyota', 'Prius', '2017-07-09', 30000, 'alright', 'auto', 'Sedan');
Insert into Cars Values (006, 2006, 'Ford', 'GT', '2020-08-14', 25000, 'good', 'manual', 'Sports Car');

/** Customer **/
Insert into Customer Values (001, 'Abigail', 'Ohrt', '2001-04-13', 252274940, 'GEICO', 9463576749);
Insert into Customer Values (002, 'Ralph', 'Scott', '1997-02-25', 775868294, 'AMA', 6583037504);
Insert into Customer Values (003, 'Danny', 'Martinez', '1985-09-29', 494554928, 'PC', 7403275931);
Insert into Customer Values (004, 'Miah', 'Kadel', '2007-12-04', 772499603, 'Surex', 1849365843);

/** Phone **/
Insert into Phone Values (001, '780-442-4987');
Insert into Phone Values (002, '604-869-7830');
Insert into Phone Values (003, '416-474-9807');
Insert into Phone Values (004, '780-791-5620');

/** Login **/
Insert into Login Values ('Admin01', 'Pass01');
Insert into Login Values ('Arthur1899', 'Tahiti$');
Insert into Login Values ('Admin03', 'Pass02');
