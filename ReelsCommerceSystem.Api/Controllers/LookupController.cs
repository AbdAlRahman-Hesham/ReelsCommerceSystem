using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class LookupController(ILookupService _lookupService) : AppBaseController
    {
        [HttpGet("countries")]
        public async Task<IActionResult> GetCountries()
        {
            var result = await _lookupService.GetCountriesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("cities")]
        public async Task<IActionResult> GetCities([FromQuery] string country)
        {
            var result = await _lookupService.GetCitiesByCountryAsync(country);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("colors")]
        public async Task<IActionResult> GetColors()
        {
            var result = await _lookupService.GetColorsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("sizes")]
        public async Task<IActionResult> GetSizes()
        {
            var result = await _lookupService.GetSizesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("order-statuses")]
        public async Task<IActionResult> GetOrderStatuses()
        {
            var result = await _lookupService.GetOrderStatusesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("stock-statuses")]
        public async Task<IActionResult> GetStockStatuses()
        {
            var result = await _lookupService.GetStockStatusesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("payment-statuses")]
        public async Task<IActionResult> GetPaymentStatuses()
        {
            var result = await _lookupService.GetPaymentStatusesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("payment-methods")]
        public async Task<IActionResult> GetPaymentMethods()
        {
            var result = await _lookupService.GetPaymentMethodsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("information-types")]
        public async Task<IActionResult> GetInformationTypes()
        {
            var result = await _lookupService.GetInformationTypesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("dispute-statuses")]
        public async Task<IActionResult> GetDisputeStatuses()
        {
            var result = await _lookupService.GetDisputeStatusesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("reel-statuses")]
        public async Task<IActionResult> GetReelStatuses()
        {
            var result = await _lookupService.GetReelStatusesAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("delivery-methods")]
        public async Task<IActionResult> GetDeliveryMethods()
        {
            var result = await _lookupService.GetDeliveryMethodsAsync();
            return StatusCode(result.StatusCode, result);
        }
    }
}

