﻿using Caliburn.Micro;
using RED.Addons;
using RED.Interfaces;
using RED.Models;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.ViewModels.ControlCenter
{
    public class GPSViewModel : PropertyChangedBase, ISubscribe
    {
        GPSModel _model;
        ControlCenterViewModel _cc;

        public bool FixObtained
        {
            get
            {
                return _model.fixObtained;
            }
            set
            {
                _model.fixObtained = value;
                NotifyOfPropertyChange(() => FixObtained);
            }
        }
        public byte FixQuality
        {
            get
            {
                return _model.fixQuality;
            }
            set
            {
                _model.fixQuality = value;
                NotifyOfPropertyChange(() => FixQuality);
            }
        }
        public byte NumberOfSatellites
        {
            get
            {
                return _model.numberOfSatellites;
            }
            set
            {
                _model.numberOfSatellites = value;
                NotifyOfPropertyChange(() => NumberOfSatellites);
            }
        }
        public GPSCoordinate CurrentLocation
        {
            get
            {
                return _model.currentLocation;
            }
            set
            {
                _model.currentLocation = value;
                NotifyOfPropertyChange(() => CurrentLocation);
            }
        }
        public float CurrentAltitude
        {
            get
            {
                return _model.currentAltitude;
            }
            set
            {
                _model.currentAltitude = value;
                NotifyOfPropertyChange(() => CurrentAltitude);
            }
        }
        public float Speed
        {
            get
            {
                return _model.speed;
            }
            set
            {
                _model.speed = value;
                NotifyOfPropertyChange(() => Speed);
            }
        }
        public float SpeedAngle
        {
            get
            {
                return _model.speedAngle;
            }
            set
            {
                _model.speedAngle = value;
                NotifyOfPropertyChange(() => SpeedAngle);
            }
        }
        public GPSCoordinate BaseStationLocation
        {
            get
            {
                return _model.baseStationLocation;
            }
            set
            {
                _model.baseStationLocation = value;
                NotifyOfPropertyChange(() => BaseStationLocation);
                RecalculateAntennaDirection();
            }
        }
        public double AntennaDirectionDeg
        {
            get
            {
                return _model.antennaDirectionDeg;
            }
            set
            {
                _model.antennaDirectionDeg = value;
                NotifyOfPropertyChange(() => AntennaDirectionDeg);
            }
        }

        public ObservableCollection<GPSCoordinate> Waypoints
        {
            get
            {
                return _model.waypoints;
            }
            set
            {
                _model.waypoints = value;
                NotifyOfPropertyChange(() => Waypoints);
            }
        }

        public GPSViewModel(ControlCenterViewModel cc)
        {
            _model = new GPSModel();
            _cc = cc;

            _cc.DataRouter.Subscribe(this, _cc.MetadataManager.GetId("GPSData"));

            Waypoints.Add(new GPSCoordinate(37.951631, -91.777713));//Rolla
            Waypoints.Add(new GPSCoordinate(37.850025, -91.701845));//Fugitive Beach
            Waypoints.Add(new GPSCoordinate(38.406426, -110.791919));//Mars Desert Research Station
        }

        public void ReceiveFromRouter(byte dataId, byte[] data)
        {
            var ms = new MemoryStream(data);
            using (var br = new BinaryReader(ms))
            {
                FixObtained = br.ReadByte() != 0;
                FixQuality = br.ReadByte();
                NumberOfSatellites = br.ReadByte();
                CurrentLocation = new GPSCoordinate()
                {
                    Latitude = br.ReadInt32() / 10000000f,
                    Longitude = br.ReadInt32() / 10000000f
                };
                CurrentAltitude = br.ReadSingle();
                Speed = br.ReadSingle();
                SpeedAngle = br.ReadSingle();
            }
        }

        private void RecalculateAntennaDirection()
        {
            var thetaRad = Math.Atan2(CurrentLocation.Latitude - BaseStationLocation.Latitude, CurrentLocation.Longitude - BaseStationLocation.Longitude);
            AntennaDirectionDeg = thetaRad / Math.PI * 180;
        }
    }
}