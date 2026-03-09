# Checkout Flow Documentation
Login → Add Product to Cart → Create Order → Pay With Card or Mobile Wallet

# 1. Authentication
All checkout endpoints require authentication using a **JWT Bearer Token**.

# 2. Add Product to Cart

### Endpoint
POST /api/Cart

### Request Example
```json
{
  "items": [
    {
      "productId": 9,
      "quantity": 1,
      "color": "blue",
      "size": "xs"
    }
  ]
}
```

### Response
```json
{
  "success": true,
  "statusCode": 200,
  "message": {
    "en": "Products added to cart successfully.",
    "ar": "تمت إضافة المنتجات إلى عربة التسوق بنجاح"
  },
  "data": {
    "cartId": 0,
    "userId": "bf5400b3-f6ec-403c-b9a7-f8b26835b767",
    "cartItems": [
      {
        "productId": 9,
        "productName": "AirPulse Earbuds",
        "productMediaUrl": "Products/Brand2/AirPulse Earbuds.jfif",
        "productPrice": 378,
        "color": "blue",
        "size": "XS",
        "quantity": 1
      }
    ]
  },
  "errors": null
}
```

# 3. Create Order

### Endpoint
POST /api/Order

Creates a new order from the cart.

When an order is created:

* Cart products are validated
* Stock is checked
* Cart is cleared
* Order status becomes **Pending**

## Request Example
Using an existing address:

```json
{
  "addressId": 14,
  "paymentMethod": 0,
  "deliveryMethod": 0
}
```

Using a new shipping address:

```json
{
  "address": {
    "name": "Nada",
    "shippingLastName": "Reda",
    "postalCode": "9999",
    "country": "Egypt",
    "street": "string",
    "city": "Tanta",
    "phoneNumber": "string",
    "shippingBuilding": "string",
    "shippingFloor": "string",
    "shippingApartment": "string",
    "saveAddress": true,
    "setAsDefault": true
  },
  "paymentMethod": 0,
  "deliveryMethod": 0
}
```

## Response

```json
{
  "id": 21,
  "total": 438,
  "status": 0,
  "address": {
    "name": "Nada",
    "postcode": "9999",
    "country": "Egypt",
    "street": "string",
    "city": "Tanta",
    "user": null,
    "userId": "bf5400b3-f6ec-403c-b9a7-f8b26835b767",
    "phoneNumber": "string",
    "isDefault": true,
    "lastName": "Reda",
    "building": "string",
    "floor": "string",
    "apartment": "string",
    "id": 17,
    "createdAt": "2026-03-08T14:52:16.4084806Z",
    "updatedAt": "2026-03-08T14:52:16.4084809Z"
  }
}
```

# 4. Process Payment

### Endpoint
POST /api/Payment/pay

Creates a **Paymob payment link**.

## Request
```json
{
  "orderId": 21
}
```

## Response

```json
{
  "success": true,
  "statusCode": 200,
  "message": {
    "en": "Request completed successfully.",
    "ar": "تم تنفيذ الطلب بنجاح."
  },
  "data": {
    "paymentUrl": "https://accept.paymob.com/api/acceptance/iframes/910409?payment_token=ZXlKaGJHY2lPaUpJVXpVeE1pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SjFjMlZ5WDJsa0lqb3hPVE00TnpZMExDSmhiVzkxYm5SZlkyVnVkSE1pT2pRek9EQXdMQ0pqZFhKeVpXNWplU0k2SWtWSFVDSXNJbWx1ZEdWbmNtRjBhVzl1WDJsa0lqbzFNREk1TWpnNExDSnZjbVJsY2w5cFpDSTZORGd5TlRnNU1UUXpMQ0ppYVd4c2FXNW5YMlJoZEdFaU9uc2labWx5YzNSZmJtRnRaU0k2SWs1aFpHRWlMQ0pzWVhOMFgyNWhiV1VpT2lKU1pXUmhJaXdpYzNSeVpXVjBJam9pYzNSeWFXNW5JaXdpWW5WcGJHUnBibWNpT2lKemRISnBibWNpTENKbWJHOXZjaUk2SW5OMGNtbHVaeUlzSW1Gd1lYSjBiV1Z1ZENJNkluTjBjbWx1WnlJc0ltTnBkSGtpT2lKVVlXNTBZU0lzSW5OMFlYUmxJam9pVGtFaUxDSmpiM1Z1ZEhKNUlqb2lSV2Q1Y0hRaUxDSmxiV0ZwYkNJNkltNXlaV1JoTWpjNU9VQm5iV0ZwYkM1amIyMGlMQ0p3YUc5dVpWOXVkVzFpWlhJaU9pSnpkSEpwYm1jaUxDSndiM04wWVd4ZlkyOWtaU0k2SWpFeU16UTFJaXdpWlhoMGNtRmZaR1Z6WTNKcGNIUnBiMjRpT2lKT1FTSjlMQ0pzYjJOclgyOXlaR1Z5WDNkb1pXNWZjR0ZwWkNJNlptRnNjMlVzSW1WNGRISmhJanA3ZlN3aWMybHVaMnhsWDNCaGVXMWxiblJmWVhSMFpXMXdkQ0k2Wm1Gc2MyVXNJbkJ0YTE5cGNDSTZJakU1Tnk0ME15NHpMakl5TlNKOS5VTmFPdGJlY0RhQU1McWdSQ0xmb1Jxd1Q3ZzFnV0hQY1NIbUtJWmZ6LTZIX1VVUXlfeVlwMDUzTm9VRlJWY0M0WVpHdzJMWkFGNk04cVh6YzYtNGd4dw==",
    "amount": 438,
    "orderId": 21,
    "paymobOrderId": 482589143
  },
  "errors": null
}
```
**redirect the user to `paymentUrl`**.
User → Paymob Payment Page → Payment Success/Failure

### Endpoint
POST /api/Payment/api/payments/wallet

## Request
```json
{
  "orderId": 14,
  "phone": "01010101010"
}
```
## Response
```json
{
  "success": true,
  "statusCode": 200,
  "message": {
    "en": "Request completed successfully.",
    "ar": "تم تنفيذ الطلب بنجاح."
  },
  "data": {
    "paymentUrl": "https://accept.paymobsolutions.com/api/acceptance/wallet_other_test/wallet_template?token=ZXlKaGJHY2lPaUpJVXpVeE1pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SmpiR0Z6Y3lJNklsUnlZVzV6WVdOMGFXOXVJaXdpZEhKaGJuTmhZM1JwYjI1ZmNHc2lPalF5TkRrNE9EZzRPQ3dpYzNWaVgzUjVjR1VpT2lKM1lXeHNaWFFpZlEuQzhLT3hMa3FSd3hORXltMU4zVUhWRUZTbDl5YVJiS1p2bzJlSGFFaWw4NkZ2OWk5WDRhanJ0ZnJzRUFiWUdWQTlFeTlFeUVPa19GaVBTa0FyLWM3VVE=",
    "amount": 438,
    "orderId": 14,
    "paymobOrderId": 483165414
  },
  "errors": null
}
```



# 5. Create Order Common Errors

### Cart Empty
### Address not found
### Address Missing
### Color not available
### Size not available
### Out Of Stock

# Notes 
* Payment URL must be opened in a **new tab or redirect**
* Cart will be cleared automatically after order creation
* Handle API validation errors and display them to the user
