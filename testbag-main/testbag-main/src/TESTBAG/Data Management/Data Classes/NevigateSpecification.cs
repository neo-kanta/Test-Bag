using System;
using System.Linq;
using TESTBAG.Data_Management.Database;

namespace TESTBAG.Data_Classes
{
    public class NevigateSpecification : IDisposable
    {
        public int _specId { get; set; }
        private Entities _context;
        public NevigateSpecification(int specId)
        {
            _specId = specId;
            _context = new Entities();
        }

        private MASTER_SPECIFICATIONS GetSpecificationById()
        {
            return _context.MASTER_SPECIFICATIONS.FirstOrDefault(specification => specification.ID == _specId);
        }
        public string FindMeasureName()
        {
            return GetSpecificationById()?.MEASUREMENT_NAME;
        }
        public string FindStage()
        {
            return GetSpecificationById()?.STAGE_TEXT;
        }

        public double? FindMinValue()
        {
            return GetSpecificationById()?.MIN_VALUE;
        }

        public double? FindMaxValue()
        {
            return GetSpecificationById()?.MAX_VALUE;
        }

        public double? FindPreferredVaue()
        {
            return GetSpecificationById()?.PREFERRED_VALUE;
        }

        public void NavigateProductContext(Entities context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                _context = null;
            }
        }
    }
}