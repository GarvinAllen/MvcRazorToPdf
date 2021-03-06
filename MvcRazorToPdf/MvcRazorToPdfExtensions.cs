using System;
using System.Web.Mvc;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MvcRazorToPdf
{
    public static class MvcRazorToPdfExtensions
    {
        public static byte[] GeneratePdf(this ControllerContext context, object model=null, string viewName=null,
            Action<PdfWriter, Document> configureSettings=null)
        {
            return new MvcRazorToPdf().GeneratePdfOutput(context, model, viewName, configureSettings);
        }

        public static byte[] GeneratePdfFromHtmlString(this ControllerContext context, object model = null, string htmlString = null,
            Action<PdfWriter, Document> configureSettings = null)
        {
            return new MvcRazorToPdf().GeneratePdfOutputFromHtmlString(context, model, htmlString, configureSettings);
        }
    }
}