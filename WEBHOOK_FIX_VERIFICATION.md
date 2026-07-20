PARAMETER MAPPING VERIFICATION
==============================

PAYMOB PAYMENT WEBHOOK URL TEMPLATE:
/api/PaymobWebhook/payment?id={id}&pending={pending}&amount_cents={amount_cents}&success={success}&is_auth={is_auth}&is_capture={is_capture}&is_standalone_payment={is_standalone_payment}&is_voided={is_voided}&is_refunded={is_refunded}&is_3d_secure={is_3d_secure}&integration_id={integration_id}&profile_id={profile_id}&has_parent_transaction={has_parent_transaction}&order={order}&created_at={created_at}&currency={currency}&merchant_commission={merchant_commission}&accept_fees={accept_fees}&discount_details={discount_details}&amount_cents_int={amount_cents_int}&is_void={is_void}&is_refund={is_refund}&error_occured={error_occured}&refunded_amount_cents={refunded_amount_cents}&refunded_amount_cents_int={refunded_amount_cents_int}&captured_amount={captured_amount}&captured_amount_int={captured_amount_int}&settlement_amount_cents_int={settlement_amount_cents_int}&accept_fees_cents_int={accept_fees_cents_int}&vat_cents_int={vat_cents_int}&updated_at={updated_at}&is_settled={is_settled}&bill_balanced={bill_balanced}&is_bill={is_bill}&owner={owner}&data.message={data.message}&source_data.type={source_data.type}&source_data.pan={source_data.pan}&source_data.sub_type={source_data.sub_type}&acq_response_code={acq_response_code}&txn_response_code={txn_response_code}&hmac={hmac}

NEW CODE PARSES THE FOLLOWING QUERY PARAMETERS:
1. id → transactionId (line 47)
2. pending → isPending (line 48)
3. amount_cents → amountCents (line 49)
4. success → isSuccess/success (line 50-51)
5. is_auth → isAuth (line 52)
6. is_capture → isCapture (line 53)
7. is_standalone_payment → isStandalonePayment (line 54)
8. is_voided → isVoided (line 55)
9. is_refunded → isRefunded (line 56)
10. is_3d_secure → is3dSecure (line 57)
11. order → orderId (line 58)
12. owner → owner (line 59)
13. created_at → createdAt (line 60)
14. currency → currency (line 61)
15. error_occured → errorOccurred (line 62)
16. has_parent_transaction → hasParentTransaction (line 63)
17. integration_id → integrationId (line 64)
18. profile_id → profileId (line 65)
19. source_data.type → sourceDataType (line 66)
20. source_data.pan → sourceDataPan (line 67)
21. source_data.sub_type → sourceDataSubType (line 68)

CONCATENATED STRING ORDER FOR HMAC (lines 70-92):
1. amountCents
2. createdAt
3. currency
4. errorOccurred.ToLower()
5. hasParentTransaction.ToLower()
6. id
7. integrationId
8. is3dSecure.ToLower()
9. isAuth.ToLower()
10. isCapture.ToLower()
11. isRefunded.ToLower()
12. isStandalonePayment.ToLower()
13. isVoided.ToLower()
14. order
15. owner
16. pending.ToLower()
17. sourceDataPan
18. sourceDataSubType
19. sourceDataType
20. success.ToLower()

VALIDATION NOTES:
- All boolean parameters converted to lowercase strings ("true"/"false")
- Numeric and string parameters used as-is
- Null/empty values handled with default fallbacks
- HMAC validation logic unchanged from original implementation
- Removed unnecessary System.Text.Json import since JSON parsing is no longer needed

EDGE CASES HANDED:
- Missing query parameters: uses default values ("0" for numbers, "false" for booleans, "" for strings)
- Empty HMAC parameter: returns "Missing HMAC" error
- Invalid HMAC: returns "Invalid HMAC" error
- Order not found: returns 404 NotFound error
- Failed to update: returns 500 Internal Server Error