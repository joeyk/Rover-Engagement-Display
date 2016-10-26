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

namespace RED.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="REDDatabase")]
	public partial class DataClassesLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDefault(Default instance);
    partial void UpdateDefault(Default instance);
    partial void DeleteDefault(Default instance);
    partial void InsertGPSData(GPSData instance);
    partial void UpdateGPSData(GPSData instance);
    partial void DeleteGPSData(GPSData instance);
    #endregion
		
		public DataClassesLinqDataContext() : 
				base(global::RED.Properties.Settings.Default.REDDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Default> Defaults
		{
			get
			{
				return this.GetTable<Default>();
			}
		}
		
		public System.Data.Linq.Table<GPSData> GPSDatas
		{
			get
			{
				return this.GetTable<GPSData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Default]")]
	public partial class Default : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _DataId;
		
		private System.DateTime _TimeStamp;
		
		private string _Data;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDataIdChanging(int value);
    partial void OnDataIdChanged();
    partial void OnTimeStampChanging(System.DateTime value);
    partial void OnTimeStampChanged();
    partial void OnDataChanging(string value);
    partial void OnDataChanged();
    #endregion
		
		public Default()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataId", DbType="Int NOT NULL")]
		public int DataId
		{
			get
			{
				return this._DataId;
			}
			set
			{
				if ((this._DataId != value))
				{
					this.OnDataIdChanging(value);
					this.SendPropertyChanging();
					this._DataId = value;
					this.SendPropertyChanged("DataId");
					this.OnDataIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime2 NOT NULL")]
		public System.DateTime TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GPSData")]
	public partial class GPSData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _TimeStamp;
		
		private byte _FixObtained;
		
		private byte _FixQuality;
		
		private byte _NumberOfSatellites;
		
		private int _Latitude;
		
		private int _Longitude;
		
		private float _CurrentAltitude;
		
		private float _Speed;
		
		private float _SpeedAngle;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTimeStampChanging(System.DateTime value);
    partial void OnTimeStampChanged();
    partial void OnFixObtainedChanging(byte value);
    partial void OnFixObtainedChanged();
    partial void OnFixQualityChanging(byte value);
    partial void OnFixQualityChanged();
    partial void OnNumberOfSatellitesChanging(byte value);
    partial void OnNumberOfSatellitesChanged();
    partial void OnLatitudeChanging(int value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(int value);
    partial void OnLongitudeChanged();
    partial void OnCurrentAltitudeChanging(float value);
    partial void OnCurrentAltitudeChanged();
    partial void OnSpeedChanging(float value);
    partial void OnSpeedChanged();
    partial void OnSpeedAngleChanging(float value);
    partial void OnSpeedAngleChanged();
    #endregion
		
		public GPSData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime2 NOT NULL")]
		public System.DateTime TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FixObtained", DbType="TinyInt NOT NULL")]
		public byte FixObtained
		{
			get
			{
				return this._FixObtained;
			}
			set
			{
				if ((this._FixObtained != value))
				{
					this.OnFixObtainedChanging(value);
					this.SendPropertyChanging();
					this._FixObtained = value;
					this.SendPropertyChanged("FixObtained");
					this.OnFixObtainedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FixQuality", DbType="TinyInt NOT NULL")]
		public byte FixQuality
		{
			get
			{
				return this._FixQuality;
			}
			set
			{
				if ((this._FixQuality != value))
				{
					this.OnFixQualityChanging(value);
					this.SendPropertyChanging();
					this._FixQuality = value;
					this.SendPropertyChanged("FixQuality");
					this.OnFixQualityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfSatellites", DbType="TinyInt NOT NULL")]
		public byte NumberOfSatellites
		{
			get
			{
				return this._NumberOfSatellites;
			}
			set
			{
				if ((this._NumberOfSatellites != value))
				{
					this.OnNumberOfSatellitesChanging(value);
					this.SendPropertyChanging();
					this._NumberOfSatellites = value;
					this.SendPropertyChanged("NumberOfSatellites");
					this.OnNumberOfSatellitesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Int NOT NULL")]
		public int Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Int NOT NULL")]
		public int Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentAltitude", DbType="Real NOT NULL")]
		public float CurrentAltitude
		{
			get
			{
				return this._CurrentAltitude;
			}
			set
			{
				if ((this._CurrentAltitude != value))
				{
					this.OnCurrentAltitudeChanging(value);
					this.SendPropertyChanging();
					this._CurrentAltitude = value;
					this.SendPropertyChanged("CurrentAltitude");
					this.OnCurrentAltitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="Real NOT NULL")]
		public float Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				if ((this._Speed != value))
				{
					this.OnSpeedChanging(value);
					this.SendPropertyChanging();
					this._Speed = value;
					this.SendPropertyChanged("Speed");
					this.OnSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SpeedAngle", DbType="Real NOT NULL")]
		public float SpeedAngle
		{
			get
			{
				return this._SpeedAngle;
			}
			set
			{
				if ((this._SpeedAngle != value))
				{
					this.OnSpeedAngleChanging(value);
					this.SendPropertyChanging();
					this._SpeedAngle = value;
					this.SendPropertyChanged("SpeedAngle");
					this.OnSpeedAngleChanged();
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