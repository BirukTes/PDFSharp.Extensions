namespace PdfSharp.Pdf
{
    /// <summary>
    /// Extension methods for the PdfSharp library PdfString object.
    /// </summary>
    public static class PdfStringExtensions
    {
        /// <summary>
        /// Gets byte representation of each character of a given PdfString value
        /// </summary>
        /// <param name="str">PdfString</param>
        /// <returns>Byte Array</returns>
        public static byte[] GetBytes(this PdfString str)
        {
            if (str != null) return GetBytes(str.Value);

            return new byte[0];
        }

        /// <summary>
        /// Gets byte representation of each character of a given String
        /// </summary>
        /// <param name="chars">String to convert</param>
        /// <returns>Byte array</returns>
        public static byte[] GetBytes(this string strValue)
        {
            char[] chars = strValue.ToCharArray();
            var charCount = chars.Length;
            var charIndex = 0;
            byte[] bytes = new byte[charCount];

            for (int count = charCount; count > 0; charIndex++, count--)
            {

                bytes[charIndex] = (byte)chars[charIndex];
                //#warning Here is a HACK that must not be ignored!
                // HACK:
                // bytes[byteIndex] = (byte)chars[charIndex];
            }

            return bytes;
        }
    }
}
