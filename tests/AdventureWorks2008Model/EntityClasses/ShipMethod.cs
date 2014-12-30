﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace ReadTestsAdventureWorks2008.EntityClasses
{
	/// <summary>Class which represents the entity 'ShipMethod', mapped on table 'AdventureWorks.Purchasing.ShipMethod'.</summary>
	public partial class ShipMethod : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private System.Guid	_rowguid;
		private System.Decimal	_shipBase;
		private System.Int32	_shipMethodId;
		private System.Decimal	_shipRate;
		private EntitySet <PurchaseOrderHeader> _purchaseOrderHeaders;
		private EntitySet <SalesOrderHeader> _salesOrderHeaders;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnShipBaseChanging(System.Decimal value);
		partial void OnShipBaseChanged();
		partial void OnShipMethodIdChanging(System.Int32 value);
		partial void OnShipMethodIdChanged();
		partial void OnShipRateChanging(System.Decimal value);
		partial void OnShipRateChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ShipMethod"/> class.</summary>
		public ShipMethod()
		{
			_purchaseOrderHeaders = new EntitySet<PurchaseOrderHeader>(new Action<PurchaseOrderHeader>(this.Attach_PurchaseOrderHeaders), new Action<PurchaseOrderHeader>(this.Detach_PurchaseOrderHeaders) );
			_salesOrderHeaders = new EntitySet<SalesOrderHeader>(new Action<SalesOrderHeader>(this.Attach_SalesOrderHeaders), new Action<SalesOrderHeader>(this.Detach_SalesOrderHeaders) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_PurchaseOrderHeaders(PurchaseOrderHeader entity)
		{
			this.SendPropertyChanging("PurchaseOrderHeaders");
			entity.ShipMethod = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_PurchaseOrderHeaders(PurchaseOrderHeader entity)
		{
			this.SendPropertyChanging("PurchaseOrderHeaders");
			entity.ShipMethod = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.ShipMethod = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.ShipMethod = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Name field. Mapped on target field 'Name'. </summary>
		public System.String Name
		{
			get	{ return _name; }
			set
			{
				if((_name != value))
				{
					OnNameChanging(value);
					SendPropertyChanging("Name");
					_name = value;
					SendPropertyChanged("Name");
					OnNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the ShipBase field. Mapped on target field 'ShipBase'. </summary>
		public System.Decimal ShipBase
		{
			get	{ return _shipBase; }
			set
			{
				if((_shipBase != value))
				{
					OnShipBaseChanging(value);
					SendPropertyChanging("ShipBase");
					_shipBase = value;
					SendPropertyChanged("ShipBase");
					OnShipBaseChanged();
				}
			}
		}

		/// <summary>Gets or sets the ShipMethodId field. Mapped on target field 'ShipMethodID'. </summary>
		public System.Int32 ShipMethodId
		{
			get	{ return _shipMethodId; }
			set
			{
				if((_shipMethodId != value))
				{
					OnShipMethodIdChanging(value);
					SendPropertyChanging("ShipMethodId");
					_shipMethodId = value;
					SendPropertyChanged("ShipMethodId");
					OnShipMethodIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the ShipRate field. Mapped on target field 'ShipRate'. </summary>
		public System.Decimal ShipRate
		{
			get	{ return _shipRate; }
			set
			{
				if((_shipRate != value))
				{
					OnShipRateChanging(value);
					SendPropertyChanging("ShipRate");
					_shipRate = value;
					SendPropertyChanged("ShipRate");
					OnShipRateChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.ShipMethod - ShipMethod.PurchaseOrderHeaders (m:1)'</summary>
		public EntitySet<PurchaseOrderHeader> PurchaseOrderHeaders
		{
			get { return this._purchaseOrderHeaders; }
			set { this._purchaseOrderHeaders.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.ShipMethod - ShipMethod.SalesOrderHeaders (m:1)'</summary>
		public EntitySet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return this._salesOrderHeaders; }
			set { this._salesOrderHeaders.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649