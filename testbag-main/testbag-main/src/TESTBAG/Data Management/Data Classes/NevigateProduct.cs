using System;
using System.Collections.Generic;
using System.Linq;
using TESTBAG.Data_Management.Database;
namespace TESTBAG
{
    public class NevigateProduct : IDisposable
    {
        public int? _productId { get; set; }
        public string _productGroup { get; set; }
        public string _series { get; set; }
        public string _model { get; set; }
        public string _batteryType { get; set; }
        public string _batteryCapacity { get; set; }

        private readonly Entities _context;

        public NevigateProduct(string productGroup, string series, string model, string batteryType, string batteryCapacity)
        {
            _productGroup = productGroup;
            _series = series;
            _model = model;
            _batteryType = batteryType;
            _batteryCapacity = batteryCapacity;
            _context = new Entities();
        }

        public NevigateProduct(int? productId)
        {
            _productId = productId;
            _context = new Entities();
        }

        private PRODUCT GetProductById(int? productId) => _context.PRODUCT.SingleOrDefault(p => p.ID == productId);

        public string FindProductGroup() => GetProductById(_productId)?.PRODUCT_GRUOP;
        public string FindSeries() => GetProductById(_productId)?.SERIES;
        public string FindModel() => GetProductById(_productId)?.MODEL;
        public string FindBatteryType() => GetProductById(_productId)?.BATTERY_TYPE;
        public string FindBatteryCapacity() => GetProductById(_productId)?.BATTERY_CAPACITY;
        public bool? FindIsDeacticated() => GetProductById(_productId)?.IS_DEACTICATED;

        public int FindProductId() =>
            _context.PRODUCT
                .SingleOrDefault(p => p.PRODUCT_GRUOP == _productGroup
                                     && p.SERIES == _series
                                     && p.MODEL == _model
                                     && p.BATTERY_TYPE == _batteryType
                                     && p.BATTERY_CAPACITY == _batteryCapacity)?.ID ?? 0;


        // Summary : to find the "RAW_MEASUREMET ID" from "MEAUSEMENT_PRODUCT(ID)"
        // Hence the ID is PK of MEASUREMENT_PRODUCT Table

        public int? FindRawId(int idToFindRaw)
        {
            var rawId = _context.RAW_MEASUREMENT
                .Where(rId => rId.MEASUREMENT_ID == idToFindRaw)
                .Select(rId => rId.MEASUREMENT_ID)
                .FirstOrDefault();
            return rawId;
        }

        public List<RAW_MEASUREMENT> GetRawMeasurementData(int measurementProductId)
        {
            return _context.RAW_MEASUREMENT
                .Where(rm => rm.MEASUREMENT_ID == measurementProductId)
                .ToList();
        }

        // Summary : Call the stage text using Product ID which select from combo box at window form
        public string FindStageText()
        {
            int productId = FindProductId();
            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var stage = findSpecificationsId.
                Where(idStage => idStage.PRODUCT_ID == productId).
                Select(id => id.STAGE_TEXT).Distinct();
            return string.Join(",", stage);

        }
        public string SearchStage(int? productId)
        {
            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var stage = findSpecificationsId.
                Where(idStage => idStage.PRODUCT_ID == productId).
                Select(id => id.STAGE_TEXT).Distinct();
            return string.Join(",", stage);

        }

        // Summary : Call the Max Value of product whcih using prodict ID to find max value
        public string FindMaxValue()
        {
            int productId = FindProductId();
            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var maxValue = findSpecificationsId.
                Where(idMax => idMax.PRODUCT_ID == productId).
                Select(id => id.MAX_VALUE).Distinct();
            return string.Join(",", maxValue);

        }

        public string SearchMaxValue(int? productId)
        {
            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var maxValue = findSpecificationsId.
                Where(idMax => idMax.PRODUCT_ID == productId).
                Select(id => id.MAX_VALUE).Distinct();
            return string.Join(",", maxValue);

        }

        // Summary : Call the Min Value of product which using produyct ID to find min value
        public string FindMinValue()
        {
            int productId = FindProductId();

            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var minValue = findSpecificationsId.
                Where(idMin => idMin.PRODUCT_ID == productId).
                Select(id => id.MIN_VALUE).Distinct();
            return string.Join(",", minValue);

        }
        public string SearchMinValue(int? productId)
        {
            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var minValue = findSpecificationsId.
                Where(idMin => idMin.PRODUCT_ID == productId).
                Select(id => id.MIN_VALUE).Distinct();
            return string.Join(",", minValue);

        }

        // Summary : Call the Preffered Value of the product using product ID to find the preffered value
        public string FindPreferredValue()
        {
            int productId = FindProductId();

            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var prefferedValue = findSpecificationsId.
                Where(idMin => idMin.PRODUCT_ID == productId).
                Select(id => id.PREFERRED_VALUE).Distinct();
            return string.Join(",", prefferedValue);

        }
        public string SearchPreferredValue(int? productId)
        {
            var findSpecificationsId = _context.MASTER_SPECIFICATIONS.ToList();

            var prefferedValue = findSpecificationsId.
                Where(idMin => idMin.PRODUCT_ID == productId).
                Select(id => id.PREFERRED_VALUE).Distinct();
            return string.Join(",", prefferedValue);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
