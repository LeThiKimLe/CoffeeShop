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

namespace project
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CafeManagement")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIngredient(Ingredient instance);
    partial void UpdateIngredient(Ingredient instance);
    partial void DeleteIngredient(Ingredient instance);
    partial void InsertMenu(Menu instance);
    partial void UpdateMenu(Menu instance);
    partial void DeleteMenu(Menu instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertRecipe(Recipe instance);
    partial void UpdateRecipe(Recipe instance);
    partial void DeleteRecipe(Recipe instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertOrderDetail(OrderDetail instance);
    partial void UpdateOrderDetail(OrderDetail instance);
    partial void DeleteOrderDetail(OrderDetail instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::project.Properties.Settings.Default.CafeManagementConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Ingredient> Ingredients
		{
			get
			{
				return this.GetTable<Ingredient>();
			}
		}
		
		public System.Data.Linq.Table<Menu> Menus
		{
			get
			{
				return this.GetTable<Menu>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Recipe> Recipes
		{
			get
			{
				return this.GetTable<Recipe>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<OrderDetail> OrderDetails
		{
			get
			{
				return this.GetTable<OrderDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ingredient")]
	public partial class Ingredient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<int> _count;
		
		private string _unit;
		
		private System.Nullable<bool> _active;
		
		private EntitySet<Recipe> _Recipes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncountChanging(System.Nullable<int> value);
    partial void OncountChanged();
    partial void OnunitChanging(string value);
    partial void OnunitChanged();
    partial void OnactiveChanging(System.Nullable<bool> value);
    partial void OnactiveChanged();
    #endregion
		
		public Ingredient()
		{
			this._Recipes = new EntitySet<Recipe>(new Action<Recipe>(this.attach_Recipes), new Action<Recipe>(this.detach_Recipes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int")]
		public System.Nullable<int> count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unit", DbType="NVarChar(MAX)")]
		public string unit
		{
			get
			{
				return this._unit;
			}
			set
			{
				if ((this._unit != value))
				{
					this.OnunitChanging(value);
					this.SendPropertyChanging();
					this._unit = value;
					this.SendPropertyChanged("unit");
					this.OnunitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit")]
		public System.Nullable<bool> active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ingredient_Recipe", Storage="_Recipes", ThisKey="id", OtherKey="ingredient_id")]
		public EntitySet<Recipe> Recipes
		{
			get
			{
				return this._Recipes;
			}
			set
			{
				this._Recipes.Assign(value);
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
		
		private void attach_Recipes(Recipe entity)
		{
			this.SendPropertyChanging();
			entity.Ingredient = this;
		}
		
		private void detach_Recipes(Recipe entity)
		{
			this.SendPropertyChanging();
			entity.Ingredient = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Menu")]
	public partial class Menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<float> _price;
		
		private System.Nullable<bool> _active;
		
		private EntitySet<Recipe> _Recipes;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpriceChanging(System.Nullable<float> value);
    partial void OnpriceChanged();
    partial void OnactiveChanging(System.Nullable<bool> value);
    partial void OnactiveChanged();
    #endregion
		
		public Menu()
		{
			this._Recipes = new EntitySet<Recipe>(new Action<Recipe>(this.attach_Recipes), new Action<Recipe>(this.detach_Recipes));
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Real")]
		public System.Nullable<float> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit")]
		public System.Nullable<bool> active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Menu_Recipe", Storage="_Recipes", ThisKey="id", OtherKey="drink_id")]
		public EntitySet<Recipe> Recipes
		{
			get
			{
				return this._Recipes;
			}
			set
			{
				this._Recipes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Menu_OrderDetail", Storage="_OrderDetails", ThisKey="id", OtherKey="drink_id")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
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
		
		private void attach_Recipes(Recipe entity)
		{
			this.SendPropertyChanging();
			entity.Menu = this;
		}
		
		private void detach_Recipes(Recipe entity)
		{
			this.SendPropertyChanging();
			entity.Menu = null;
		}
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Menu = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Menu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _customer_id;
		
		private System.Nullable<System.DateTime> _date;
		
		private System.Nullable<int> _barista_id;
		
		private string _payment;
		
		private System.Nullable<double> _total;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Oncustomer_idChanging(System.Nullable<int> value);
    partial void Oncustomer_idChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void Onbarista_idChanging(System.Nullable<int> value);
    partial void Onbarista_idChanged();
    partial void OnpaymentChanging(string value);
    partial void OnpaymentChanged();
    partial void OntotalChanging(System.Nullable<double> value);
    partial void OntotalChanged();
    #endregion
		
		public Order()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_barista_id", DbType="Int")]
		public System.Nullable<int> barista_id
		{
			get
			{
				return this._barista_id;
			}
			set
			{
				if ((this._barista_id != value))
				{
					this.Onbarista_idChanging(value);
					this.SendPropertyChanging();
					this._barista_id = value;
					this.SendPropertyChanged("barista_id");
					this.Onbarista_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payment", DbType="NVarChar(50)")]
		public string payment
		{
			get
			{
				return this._payment;
			}
			set
			{
				if ((this._payment != value))
				{
					this.OnpaymentChanging(value);
					this.SendPropertyChanging();
					this._payment = value;
					this.SendPropertyChanged("payment");
					this.OnpaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Float")]
		public System.Nullable<double> total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this.OntotalChanging(value);
					this.SendPropertyChanging();
					this._total = value;
					this.SendPropertyChanged("total");
					this.OntotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderDetail", Storage="_OrderDetails", ThisKey="id", OtherKey="order_id")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_User", ThisKey="customer_id", OtherKey="id", IsForeignKey=true)]
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
						this._customer_id = value.id;
					}
					else
					{
						this._customer_id = default(Nullable<int>);
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe")]
	public partial class Recipe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _drink_id;
		
		private System.Nullable<int> _ingredient_id;
		
		private System.Nullable<double> _amount;
		
		private EntityRef<Ingredient> _Ingredient;
		
		private EntityRef<Menu> _Menu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ondrink_idChanging(System.Nullable<int> value);
    partial void Ondrink_idChanged();
    partial void Oningredient_idChanging(System.Nullable<int> value);
    partial void Oningredient_idChanged();
    partial void OnamountChanging(System.Nullable<double> value);
    partial void OnamountChanged();
    #endregion
		
		public Recipe()
		{
			this._Ingredient = default(EntityRef<Ingredient>);
			this._Menu = default(EntityRef<Menu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_drink_id", DbType="Int")]
		public System.Nullable<int> drink_id
		{
			get
			{
				return this._drink_id;
			}
			set
			{
				if ((this._drink_id != value))
				{
					if (this._Menu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondrink_idChanging(value);
					this.SendPropertyChanging();
					this._drink_id = value;
					this.SendPropertyChanged("drink_id");
					this.Ondrink_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ingredient_id", DbType="Int")]
		public System.Nullable<int> ingredient_id
		{
			get
			{
				return this._ingredient_id;
			}
			set
			{
				if ((this._ingredient_id != value))
				{
					if (this._Ingredient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oningredient_idChanging(value);
					this.SendPropertyChanging();
					this._ingredient_id = value;
					this.SendPropertyChanged("ingredient_id");
					this.Oningredient_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Float")]
		public System.Nullable<double> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ingredient_Recipe", Storage="_Ingredient", ThisKey="ingredient_id", OtherKey="id", IsForeignKey=true)]
		public Ingredient Ingredient
		{
			get
			{
				return this._Ingredient.Entity;
			}
			set
			{
				Ingredient previousValue = this._Ingredient.Entity;
				if (((previousValue != value) 
							|| (this._Ingredient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ingredient.Entity = null;
						previousValue.Recipes.Remove(this);
					}
					this._Ingredient.Entity = value;
					if ((value != null))
					{
						value.Recipes.Add(this);
						this._ingredient_id = value.id;
					}
					else
					{
						this._ingredient_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Ingredient");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Menu_Recipe", Storage="_Menu", ThisKey="drink_id", OtherKey="id", IsForeignKey=true)]
		public Menu Menu
		{
			get
			{
				return this._Menu.Entity;
			}
			set
			{
				Menu previousValue = this._Menu.Entity;
				if (((previousValue != value) 
							|| (this._Menu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Menu.Entity = null;
						previousValue.Recipes.Remove(this);
					}
					this._Menu.Entity = value;
					if ((value != null))
					{
						value.Recipes.Add(this);
						this._drink_id = value.id;
					}
					else
					{
						this._drink_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Menu");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Role()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="id", OtherKey="role_id")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _contact;
		
		private System.Nullable<int> _role_id;
		
		private string _password;
		
		private EntitySet<Order> _Orders;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncontactChanging(string value);
    partial void OncontactChanged();
    partial void Onrole_idChanging(System.Nullable<int> value);
    partial void Onrole_idChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public User()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact", DbType="VarChar(MAX)")]
		public string contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				if ((this._contact != value))
				{
					this.OncontactChanging(value);
					this.SendPropertyChanging();
					this._contact = value;
					this.SendPropertyChanged("contact");
					this.OncontactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role_id", DbType="Int")]
		public System.Nullable<int> role_id
		{
			get
			{
				return this._role_id;
			}
			set
			{
				if ((this._role_id != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onrole_idChanging(value);
					this.SendPropertyChanging();
					this._role_id = value;
					this.SendPropertyChanged("role_id");
					this.Onrole_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(MAX)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_Orders", ThisKey="id", OtherKey="customer_id")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="role_id", OtherKey="id", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._role_id = value.id;
					}
					else
					{
						this._role_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Role");
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
			entity.User = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderDetail")]
	public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _order_id;
		
		private System.Nullable<int> _drink_id;
		
		private System.Nullable<double> _price;
		
		private System.Nullable<int> _amount;
		
		private System.Nullable<bool> _state;
		
		private EntityRef<Menu> _Menu;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onorder_idChanging(System.Nullable<int> value);
    partial void Onorder_idChanged();
    partial void Ondrink_idChanging(System.Nullable<int> value);
    partial void Ondrink_idChanged();
    partial void OnpriceChanging(System.Nullable<double> value);
    partial void OnpriceChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    partial void OnstateChanging(System.Nullable<bool> value);
    partial void OnstateChanged();
    #endregion
		
		public OrderDetail()
		{
			this._Menu = default(EntityRef<Menu>);
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_id", DbType="Int")]
		public System.Nullable<int> order_id
		{
			get
			{
				return this._order_id;
			}
			set
			{
				if ((this._order_id != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onorder_idChanging(value);
					this.SendPropertyChanging();
					this._order_id = value;
					this.SendPropertyChanged("order_id");
					this.Onorder_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_drink_id", DbType="Int")]
		public System.Nullable<int> drink_id
		{
			get
			{
				return this._drink_id;
			}
			set
			{
				if ((this._drink_id != value))
				{
					if (this._Menu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondrink_idChanging(value);
					this.SendPropertyChanging();
					this._drink_id = value;
					this.SendPropertyChanged("drink_id");
					this.Ondrink_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float")]
		public System.Nullable<double> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="Bit")]
		public System.Nullable<bool> state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Menu_OrderDetail", Storage="_Menu", ThisKey="drink_id", OtherKey="id", IsForeignKey=true)]
		public Menu Menu
		{
			get
			{
				return this._Menu.Entity;
			}
			set
			{
				Menu previousValue = this._Menu.Entity;
				if (((previousValue != value) 
							|| (this._Menu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Menu.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Menu.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._drink_id = value.id;
					}
					else
					{
						this._drink_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Menu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderDetail", Storage="_Order", ThisKey="order_id", OtherKey="id", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._order_id = value.id;
					}
					else
					{
						this._order_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Order");
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
}
#pragma warning restore 1591