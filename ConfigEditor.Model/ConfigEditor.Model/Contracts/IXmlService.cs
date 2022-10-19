namespace ConfigEditor.Model.Contracts
{
    /// <summary>
    /// Service contract that specifies handling of xml files.
    /// </summary>
    public interface IXmlService
    {
        /// <summary>
        /// Read file as xml. Possible exceptions are thrown.
        /// </summary>
        /// <typeparam name="T">Type of class used in deserialization.</typeparam>
        /// <param name="fullFileName">Absolute path to file.</param>
        /// <returns>Instance of T.</returns>
        T ReadXml<T>(string fullFileName);

        /// <summary>
        /// Write data object to file as xml. Possible exceptions are thrown.
        /// </summary>
        /// <typeparam name="T">Type of class used in serialization.</typeparam>
        /// <param name="fullFileName">Absolute path to file.</param>
        /// <param name="dataObject">Data object to serialize.</param>
        void WriteXml<T>(string fullFileName, T dataObject);
    }
}
