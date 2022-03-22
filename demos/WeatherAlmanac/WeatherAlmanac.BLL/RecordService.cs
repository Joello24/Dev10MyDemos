using System;
using System.Collections.Generic;
using WeatherAlmanac.Core.DTO;
using WeatherAlmanac.Core.Interface;

namespace WeatherAlmanac.BLL
{
    class RecordService : IRecordService
    {
        private IRecordRepository _repo;

        public RecordService(IRecordRepository repo)
        {
            _repo = repo;
        }

        public Result<DateRecord> Add(DateRecord record)
        {
            throw new NotImplementedException();
        }

        public Result<DateRecord> Edit(DateRecord record)
        {
            throw new NotImplementedException();
        }

        public Result<DateRecord> Get(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Result<List<DateRecord>> LoadRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Result<DateRecord> Remove(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
