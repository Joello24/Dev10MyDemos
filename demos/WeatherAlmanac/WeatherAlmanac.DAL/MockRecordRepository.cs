using System;
using System.Collections.Generic;
using WeatherAlmanac.Core.DTO;
using WeatherAlmanac.Core.Interface;

namespace WeatherAlmanac.DAL
{
    public class MockRecordRepository : IRecordRepository
    {
        private List<DateRecord> _records;

        public MockRecordRepository()
        {
            _records = new List<DateRecord>();
            DateRecord bogus = new DateRecord();
            bogus.Date = DateTime.Today;
            bogus.HighTemp = 82;
            bogus.LowTemp = 40;
            bogus.Humidity = .30m;
            bogus.Description = "Really inconsistent weather today";
            _records.Add(bogus);
        }

        public Result<DateRecord> Add(DateRecord record)
        {
            Result<DateRecord> result = new Result<DateRecord>();
            _records.Add(record);
            result.Message = $"Added {record}";
            result.Success= true;
            result.Data = record;
            return result;
        }

        public Result<DateRecord> Edit(DateRecord record)
        {
            Result<DateRecord> result = new Result<DateRecord>();
            DateRecord edit = new DateRecord();
            result.Success = false;
            result.Message = "No record exists matching that date!";

            foreach (DateRecord record2 in _records)
            {
                if (record2.Date == record.Date)
                {
                    record2.HighTemp = record.HighTemp;
                    record2.LowTemp = record.LowTemp;
                    record2.Humidity = record.Humidity;
                    record2.Description = record.Description;
                    result.Success = true;
                    result.Message = $"Record on date: {record.Date} has been modified!";
                    result.Data = record;
                }
            }
            return result;
        }

        public Result<List<DateRecord>> GetAll()
        {
            Result<List<DateRecord>> result = new Result<List<DateRecord>>();
            result.Success = true;
            result.Message = "";
            result.Data = new List<DateRecord>(_records);
            return result;
        }

        public Result<DateRecord> Remove(DateTime date)
        {
            Result<DateRecord> result = new Result<DateRecord>();

            //foreach (DateRecord item in _records)
            //{
            //    if (item.Date == date)
            //    {
            //        if (_records.Remove(item))
            //        {
            //            result.Success = true;
            //            result.Message = $"Removed date {date}";
            //            //result.Data = item;
            //        }
            //    }
            //}
            for (int i = 0; i < _records.Count; i++)
            {
                if (_records[i].Date == date)
                {
                    result.Data = _records[i];
                    result.Success = true;
                    result.Message = $"Removed date {date}";
                    _records.RemoveAt(i);
                }
            }
            return result;
        }
    }
}
