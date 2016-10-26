using Caliburn.Micro;
using RED.Database;
using RED.Interfaces;
using RED.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Configuration;

namespace RED.ViewModels.ControlCenter
{
    public class DatabaseViewModel : PropertyChangedBase, ISubscribe
    {
        private DatabaseModel _model;
        private ControlCenterViewModel _cc;

        public DatabaseViewModel(ControlCenterViewModel cc)
        {
            _model = new Models.DatabaseModel();
            _cc = cc;

            for (byte i = 0; i < _model.numofsub; i++)
                _cc.DataRouter.Subscribe(this, i);
        }

        public void ReceiveFromRouter(byte dataId, byte[] data)
        {
            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Database\REDDatabase.mdf; Integrated Security = True";

            using (DataClassesLinqDataContext REDdb = new DataClassesLinqDataContext(connectionstring))
            {
                switch (_cc.MetadataManager.GetTelemetry(dataId).Name)
                {
                    case "GPSData":
                        {
                            //save to GPS database
                            GPSData NewEntry = new GPSData();

                            NewEntry.TimeStamp = DateTime.Now;
                            var ms = new MemoryStream(data);
                            using (var br = new BinaryReader(ms))
                            {
                                NewEntry.FixObtained = br.ReadByte();
                                NewEntry.FixQuality = br.ReadByte();
                                NewEntry.NumberOfSatellites = br.ReadByte();
                                NewEntry.Latitude = br.ReadInt32() / 10000000;
                                NewEntry.Longitude = br.ReadInt32() / 10000000;
                                NewEntry.CurrentAltitude = br.ReadSingle();
                                NewEntry.Speed = br.ReadSingle();
                                NewEntry.SpeedAngle = br.ReadSingle();
                            }

                            REDdb.GPSDatas.InsertOnSubmit(NewEntry);
                            try
                            {
                                REDdb.SubmitChanges();
                            }
                            catch (Exception e)
                            {
                                System.Windows.Forms.MessageBox.Show(e.Message);
                            }
                        }//end case GPSData
                        break;
                    default:
                        {   
                            //creat new entry
                            Default NewEntry = new Default
                            {
                                DataId = dataId,
                                TimeStamp = DateTime.Now,
                                Data = Encoding.Default.GetString(data)
                            };

                            REDdb.Defaults.InsertOnSubmit(NewEntry);
                            try
                            {
                                REDdb.SubmitChanges();
                            }
                            catch (Exception e)
                            {
                                System.Windows.Forms.MessageBox.Show(e.Message);
                            }
                        }//end default case
                        break;
                }//end switch
            }//end using REDdb
        }
    }
}
