namespace ReelsCommerceSystem.Application.DTOs.Response.Payment;

public class PaymentResDto
{
    public string PaymentUrl { get; set; }
    public decimal Amount { get; set; }
    public int OrderId { get; set; }
    public int PaymobOrderId { get; set; }
}
