CREATE DATABASE EShop_DB;
USE EShop_DB;

CREATE TABLE Customers (
    Customer_ID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email_address VARCHAR(100) NOT NULL,
    Contact_Information VARCHAR(20)
);

CREATE TABLE ShippingAddresses (
    AddressID INT PRIMARY KEY,
    Customer_ID INT NOT NULL,
    Street VARCHAR(100),
    State VARCHAR(50),
    Country VARCHAR(50),
    PostalCode VARCHAR(10),
    FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID)
);


CREATE TABLE PaymentInformations (
    PaymentID INT PRIMARY KEY,
    Customer_ID INT NOT NULL,
    PaymentMethod VARCHAR(50),
    CardNumber VARCHAR(20),
    ExpirationDate DATE,
    CVV VARCHAR(5),
    FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID)
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL
);

CREATE TABLE Products (
    Product_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT,
    Price DECIMAL(10,2),
    CategoryID INT,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Orders_ (
    OrderID INT PRIMARY KEY,
    Customer_ID INT NOT NULL,
    Address_ID INT NOT NULL,
    OrderDate DATE,
    TotalPrice DECIMAL(10,2),
    FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID),
    FOREIGN KEY (Address_ID) REFERENCES ShippingAddresses(AddressID) ON DELETE NO ACTION
);

CREATE TABLE OrderItems (
    OrderItemID INT PRIMARY KEY,
    OrderID INT NOT NULL,
    Product_ID INT NOT NULL,
    Quantity INT,
    ItemPrice DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID)
);

CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY,
    Product_ID INT NOT NULL,
    Customer_ID INT NOT NULL,
    Rating INT,
    Comments TEXT,
    FOREIGN KEY (Customer_ID) REFERENCES Customers(Customer_ID),
    FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID)
);

