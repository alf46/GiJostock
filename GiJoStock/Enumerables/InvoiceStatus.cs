namespace GiJoStock
{
    public enum InvoiceStatus
    {
        /// <summary>
        /// The invoice has been issued correctly.
        /// </summary>
        Emitted,
        /// <summary>
        /// The invoice has been canceled after the request for cancellation by the issuer.
        /// </summary>
        Cancelled,
        /// <summary>
        /// La factura ha sido anulada tras la petición de cancelación por parte del emisor.
        /// </summary>
        Paid,
        /// <summary>
        /// The client accepts the invoice that comes from his invoice PGE.
        /// </summary>
        Accepted,
        /// <summary>
        /// Deleted invoice.
        /// </summary>
        Deleted
    }
}