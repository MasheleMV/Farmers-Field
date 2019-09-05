﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GroupWork")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProduct_Category(Product_Category instance);
    partial void UpdateProduct_Category(Product_Category instance);
    partial void DeleteProduct_Category(Product_Category instance);
    partial void InsertReport(Report instance);
    partial void UpdateReport(Report instance);
    partial void DeleteReport(Report instance);
    partial void InsertSupplier(Supplier instance);
    partial void UpdateSupplier(Supplier instance);
    partial void DeleteSupplier(Supplier instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WcfService2.Properties.Settings.Default.GroupWorkConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Product_Category> Product_Categories
		{
			get
			{
				return this.GetTable<Product_Category>();
			}
		}
		
		public System.Data.Linq.Table<Report> Reports
		{
			get
			{
				return this.GetTable<Report>();
			}
		}
		
		public System.Data.Linq.Table<Supplier> Suppliers
		{
			get
			{
				return this.GetTable<Supplier>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Order_ID;
		
		private int _Order_Number;
		
		private decimal _Price;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<System.DateTime> _Order_Date;
		
		private string _Active;
		
		private int _User_ID;
		
		private int _Product_ID;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrder_IDChanging(int value);
    partial void OnOrder_IDChanged();
    partial void OnOrder_NumberChanging(int value);
    partial void OnOrder_NumberChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnOrder_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrder_DateChanged();
    partial void OnActiveChanging(string value);
    partial void OnActiveChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnProduct_IDChanging(int value);
    partial void OnProduct_IDChanged();
    #endregion
		
		public Order()
		{
			this._Product = default(EntityRef<Product>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Order_ID
		{
			get
			{
				return this._Order_ID;
			}
			set
			{
				if ((this._Order_ID != value))
				{
					this.OnOrder_IDChanging(value);
					this.SendPropertyChanging();
					this._Order_ID = value;
					this.SendPropertyChanged("Order_ID");
					this.OnOrder_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Number", DbType="Int NOT NULL")]
		public int Order_Number
		{
			get
			{
				return this._Order_Number;
			}
			set
			{
				if ((this._Order_Number != value))
				{
					this.OnOrder_NumberChanging(value);
					this.SendPropertyChanging();
					this._Order_Number = value;
					this.SendPropertyChanged("Order_Number");
					this.OnOrder_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Order_Date
		{
			get
			{
				return this._Order_Date;
			}
			set
			{
				if ((this._Order_Date != value))
				{
					this.OnOrder_DateChanging(value);
					this.SendPropertyChanging();
					this._Order_Date = value;
					this.SendPropertyChanged("Order_Date");
					this.OnOrder_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int NOT NULL")]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProduct_IDChanging(value);
					this.SendPropertyChanging();
					this._Product_ID = value;
					this.SendPropertyChanged("Product_ID");
					this.OnProduct_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order", Storage="_Product", ThisKey="Product_ID", OtherKey="Product_ID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._Product_ID = value.Product_ID;
					}
					else
					{
						this._Product_ID = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_User", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._User_ID = value.User_ID;
					}
					else
					{
						this._User_ID = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Product_ID;
		
		private string _P_Name;
		
		private int _P_Category_ID;
		
		private string _P_Description;
		
		private decimal _Price;
		
		private System.Nullable<decimal> _Discount;
		
		private System.Nullable<decimal> _Discount_Amount;
		
		private int _Supplier_ID;
		
		private string _Availablle;
		
		private int _NumProd;
		
		private EntitySet<Order> _Orders;
		
		private EntityRef<Product_Category> _Product_Category;
		
		private EntityRef<Supplier> _Supplier;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProduct_IDChanging(int value);
    partial void OnProduct_IDChanged();
    partial void OnP_NameChanging(string value);
    partial void OnP_NameChanged();
    partial void OnP_Category_IDChanging(int value);
    partial void OnP_Category_IDChanged();
    partial void OnP_DescriptionChanging(string value);
    partial void OnP_DescriptionChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnDiscountChanging(System.Nullable<decimal> value);
    partial void OnDiscountChanged();
    partial void OnDiscount_AmountChanging(System.Nullable<decimal> value);
    partial void OnDiscount_AmountChanged();
    partial void OnSupplier_IDChanging(int value);
    partial void OnSupplier_IDChanged();
    partial void OnAvailableChanging(string value);
    partial void OnAvailableChanged();
    partial void OnNumProdChanging(int value);
    partial void OnNumProdChanged();
    #endregion
		
		public Product()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			this._Product_Category = default(EntityRef<Product_Category>);
			this._Supplier = default(EntityRef<Supplier>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this.OnProduct_IDChanging(value);
					this.SendPropertyChanging();
					this._Product_ID = value;
					this.SendPropertyChanged("Product_ID");
					this.OnProduct_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string P_Name
		{
			get
			{
				return this._P_Name;
			}
			set
			{
				if ((this._P_Name != value))
				{
					this.OnP_NameChanging(value);
					this.SendPropertyChanging();
					this._P_Name = value;
					this.SendPropertyChanged("P_Name");
					this.OnP_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Category_ID", DbType="Int NOT NULL")]
		public int P_Category_ID
		{
			get
			{
				return this._P_Category_ID;
			}
			set
			{
				if ((this._P_Category_ID != value))
				{
					if (this._Product_Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnP_Category_IDChanging(value);
					this.SendPropertyChanging();
					this._P_Category_ID = value;
					this.SendPropertyChanged("P_Category_ID");
					this.OnP_Category_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Description", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string P_Description
		{
			get
			{
				return this._P_Description;
			}
			set
			{
				if ((this._P_Description != value))
				{
					this.OnP_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._P_Description = value;
					this.SendPropertyChanged("P_Description");
					this.OnP_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Money")]
		public System.Nullable<decimal> Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this.OnDiscountChanging(value);
					this.SendPropertyChanging();
					this._Discount = value;
					this.SendPropertyChanged("Discount");
					this.OnDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount_Amount", DbType="Money")]
		public System.Nullable<decimal> Discount_Amount
		{
			get
			{
				return this._Discount_Amount;
			}
			set
			{
				if ((this._Discount_Amount != value))
				{
					this.OnDiscount_AmountChanging(value);
					this.SendPropertyChanging();
					this._Discount_Amount = value;
					this.SendPropertyChanged("Discount_Amount");
					this.OnDiscount_AmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supplier_ID", DbType="Int NOT NULL")]
		public int Supplier_ID
		{
			get
			{
				return this._Supplier_ID;
			}
			set
			{
				if ((this._Supplier_ID != value))
				{
					if (this._Supplier.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSupplier_IDChanging(value);
					this.SendPropertyChanging();
					this._Supplier_ID = value;
					this.SendPropertyChanged("Supplier_ID");
					this.OnSupplier_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Availablle", Storage="_Availablle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Available
		{
			get
			{
				return this._Availablle;
			}
			set
			{
				if ((this._Availablle != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._Availablle = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumProd")]
		public int NumProd
		{
			get
			{
				return this._NumProd;
			}
			set
			{
				if ((this._NumProd != value))
				{
					this.OnNumProdChanging(value);
					this.SendPropertyChanging();
					this._NumProd = value;
					this.SendPropertyChanged("NumProd");
					this.OnNumProdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order", Storage="_Orders", ThisKey="Product_ID", OtherKey="Product_ID")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Category_Product", Storage="_Product_Category", ThisKey="P_Category_ID", OtherKey="PC_ID", IsForeignKey=true)]
		public Product_Category Product_Category
		{
			get
			{
				return this._Product_Category.Entity;
			}
			set
			{
				Product_Category previousValue = this._Product_Category.Entity;
				if (((previousValue != value) 
							|| (this._Product_Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product_Category.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Product_Category.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._P_Category_ID = value.PC_ID;
					}
					else
					{
						this._P_Category_ID = default(int);
					}
					this.SendPropertyChanged("Product_Category");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Product", Storage="_Supplier", ThisKey="Supplier_ID", OtherKey="Supp_ID", IsForeignKey=true)]
		public Supplier Supplier
		{
			get
			{
				return this._Supplier.Entity;
			}
			set
			{
				Supplier previousValue = this._Supplier.Entity;
				if (((previousValue != value) 
							|| (this._Supplier.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Supplier.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Supplier.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._Supplier_ID = value.Supp_ID;
					}
					else
					{
						this._Supplier_ID = default(int);
					}
					this.SendPropertyChanged("Supplier");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product_Category")]
	public partial class Product_Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PC_ID;
		
		private string _PC_Name;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnPC_NameChanging(string value);
    partial void OnPC_NameChanged();
    #endregion
		
		public Product_Category()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PC_ID
		{
			get
			{
				return this._PC_ID;
			}
			set
			{
				if ((this._PC_ID != value))
				{
					this.OnPC_IDChanging(value);
					this.SendPropertyChanging();
					this._PC_ID = value;
					this.SendPropertyChanged("PC_ID");
					this.OnPC_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PC_Name
		{
			get
			{
				return this._PC_Name;
			}
			set
			{
				if ((this._PC_Name != value))
				{
					this.OnPC_NameChanging(value);
					this.SendPropertyChanging();
					this._PC_Name = value;
					this.SendPropertyChanged("PC_Name");
					this.OnPC_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Category_Product", Storage="_Products", ThisKey="PC_ID", OtherKey="P_Category_ID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Product_Category = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Product_Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reports")]
	public partial class Report : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Report_ID;
		
		private System.Nullable<int> _Num_Registered_Users;
		
		private System.Nullable<int> _Num_Products_Available;
		
		private System.Nullable<int> _Num_Products_Bought;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReport_IDChanging(int value);
    partial void OnReport_IDChanged();
    partial void OnNum_Registered_UsersChanging(System.Nullable<int> value);
    partial void OnNum_Registered_UsersChanged();
    partial void OnNum_Products_AvailableChanging(System.Nullable<int> value);
    partial void OnNum_Products_AvailableChanged();
    partial void OnNum_Products_BoughtChanging(System.Nullable<int> value);
    partial void OnNum_Products_BoughtChanged();
    #endregion
		
		public Report()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Report_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Report_ID
		{
			get
			{
				return this._Report_ID;
			}
			set
			{
				if ((this._Report_ID != value))
				{
					this.OnReport_IDChanging(value);
					this.SendPropertyChanging();
					this._Report_ID = value;
					this.SendPropertyChanged("Report_ID");
					this.OnReport_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Registered_Users", DbType="Int")]
		public System.Nullable<int> Num_Registered_Users
		{
			get
			{
				return this._Num_Registered_Users;
			}
			set
			{
				if ((this._Num_Registered_Users != value))
				{
					this.OnNum_Registered_UsersChanging(value);
					this.SendPropertyChanging();
					this._Num_Registered_Users = value;
					this.SendPropertyChanged("Num_Registered_Users");
					this.OnNum_Registered_UsersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Products_Available", DbType="Int")]
		public System.Nullable<int> Num_Products_Available
		{
			get
			{
				return this._Num_Products_Available;
			}
			set
			{
				if ((this._Num_Products_Available != value))
				{
					this.OnNum_Products_AvailableChanging(value);
					this.SendPropertyChanging();
					this._Num_Products_Available = value;
					this.SendPropertyChanged("Num_Products_Available");
					this.OnNum_Products_AvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Products_Bought", DbType="Int")]
		public System.Nullable<int> Num_Products_Bought
		{
			get
			{
				return this._Num_Products_Bought;
			}
			set
			{
				if ((this._Num_Products_Bought != value))
				{
					this.OnNum_Products_BoughtChanging(value);
					this.SendPropertyChanging();
					this._Num_Products_Bought = value;
					this.SendPropertyChanged("Num_Products_Bought");
					this.OnNum_Products_BoughtChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Supplier")]
	public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Supp_ID;
		
		private string _Supp_Name;
		
		private string _Supp_Email;
		
		private string _Supp_Contacts;
		
		private string _Country;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSupp_IDChanging(int value);
    partial void OnSupp_IDChanged();
    partial void OnSupp_NameChanging(string value);
    partial void OnSupp_NameChanged();
    partial void OnSupp_EmailChanging(string value);
    partial void OnSupp_EmailChanged();
    partial void OnSupp_ContactsChanging(string value);
    partial void OnSupp_ContactsChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    #endregion
		
		public Supplier()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supp_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Supp_ID
		{
			get
			{
				return this._Supp_ID;
			}
			set
			{
				if ((this._Supp_ID != value))
				{
					this.OnSupp_IDChanging(value);
					this.SendPropertyChanging();
					this._Supp_ID = value;
					this.SendPropertyChanged("Supp_ID");
					this.OnSupp_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supp_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Supp_Name
		{
			get
			{
				return this._Supp_Name;
			}
			set
			{
				if ((this._Supp_Name != value))
				{
					this.OnSupp_NameChanging(value);
					this.SendPropertyChanging();
					this._Supp_Name = value;
					this.SendPropertyChanged("Supp_Name");
					this.OnSupp_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supp_Email", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Supp_Email
		{
			get
			{
				return this._Supp_Email;
			}
			set
			{
				if ((this._Supp_Email != value))
				{
					this.OnSupp_EmailChanging(value);
					this.SendPropertyChanging();
					this._Supp_Email = value;
					this.SendPropertyChanged("Supp_Email");
					this.OnSupp_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supp_Contacts", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Supp_Contacts
		{
			get
			{
				return this._Supp_Contacts;
			}
			set
			{
				if ((this._Supp_Contacts != value))
				{
					this.OnSupp_ContactsChanging(value);
					this.SendPropertyChanging();
					this._Supp_Contacts = value;
					this.SendPropertyChanged("Supp_Contacts");
					this.OnSupp_ContactsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Product", Storage="_Products", ThisKey="Supp_ID", OtherKey="Supplier_ID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Supplier = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Supplier = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_ID;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Email;
		
		private string _Phone_Number;
		
		private string _Address;
		
		private string _Country;
		
		private string _User_Type;
		
		private string _Active;
		
		private string _Password;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhone_NumberChanging(string value);
    partial void OnPhone_NumberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnUser_TypeChanging(string value);
    partial void OnUser_TypeChanged();
    partial void OnActiveChanging(string value);
    partial void OnActiveChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this.OnPhone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Phone_Number = value;
					this.SendPropertyChanged("Phone_Number");
					this.OnPhone_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(250)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string User_Type
		{
			get
			{
				return this._User_Type;
			}
			set
			{
				if ((this._User_Type != value))
				{
					this.OnUser_TypeChanging(value);
					this.SendPropertyChanging();
					this._User_Type = value;
					this.SendPropertyChanged("User_Type");
					this.OnUser_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_Orders", ThisKey="User_ID", OtherKey="User_ID")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591