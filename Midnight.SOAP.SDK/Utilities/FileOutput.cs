using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using Serilog;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.Utilities
{
    /// <summary>
    /// Generic T methods for file output, including class list to csv, class to xml, and class to json. 
    /// </summary>
    public class FileOutput
    {
        /// <summary>
        /// Writes a CSV file from a List of a Class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToWrite"></param>
        /// <param name="outputToPath"></param>
        /// <param name="fileName"></param>
        /// <param name="separator"></param>
        /// <returns><see cref="FileInfo"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="Exception"></exception>
        public static async Task<FileInfo> CreateCsvFromList<T>(List<T> dataToWrite, string outputToPath, string fileName, string separator)
        {
            StringBuilder sb = new();
            PropertyInfo[] properties = typeof(T).GetProperties();
            FileInfo? fileInfo = null;
            
            try
            {
                sb.AppendLine(string.Join(separator, properties.Select(x => x.Name)));

                foreach (T data in dataToWrite)
                {
                    sb.AppendLine(string.Join(separator, properties.Select(prop => prop.GetValue(data))));
                }
                string s = sb.ToString();

                using (StreamWriter sw = new(outputToPath + fileName))
                {
                    await sw.WriteAsync(s);
                }

                var file = outputToPath + fileName;

                if (!File.Exists(file))
                {
                    Log.Error($"{file} was not created in CreateCsvFromList<{typeof(T)}>.");
                    throw new Exception($"{file} was not created in CreateCsvFromList<{typeof(T)}>");
                }
                else
                {
                    Log.Information($"CSV file {file} successfully created..");
                }

                fileInfo = new FileInfo(file);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Log.Error($"ArgumentOutOfRangeException: {ex.Message}");
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Log.Error($"InvalidOperationException: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Log.Error($"Exception: {ex.Message}");
                throw;
            }
 

            return fileInfo;
        }

        /// <summary>
        /// Writes a Class to a JSON file. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToWrite"></param>
        /// <param name="outputToPath"></param>
        /// <param name="fileName"></param>
        /// <returns><see cref="FileInfo"/></returns>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="Exception"></exception>
        public static async Task<FileInfo> CreateJsonFromClass<T>(T dataToWrite, string outputToPath, string fileName)
        {
            FileInfo? fileInfo;

            try
            {
                string json = JsonConvert.SerializeObject(dataToWrite, Formatting.Indented);

                Log.Information($"Begin writing JSON from {typeof(T)} to {outputToPath}{fileName} asynchronously..");

                await File.WriteAllTextAsync(@"" + outputToPath + fileName, json);

                var file = outputToPath + fileName;

                if (!File.Exists(file))
                {
                    Log.Error($"JSON file {file} was not created!!");
                    throw new Exception(file + " was not created in CreateJsonFromClass<T>.");
                }
                else
                {
                    Log.Information($"JSON file {file} successfully created..");
                }

                fileInfo = new FileInfo(file);

            }
            catch (PathTooLongException ex)
            {
                Log.Error($"PathTooLongException within CreateJsonFromClass<{typeof(T)}>: {ex.Message}");
                throw;
            }
            catch (DirectoryNotFoundException ex)
            {
                Log.Error($"DirectoryNotFoundException within CreateJsonFromClass<{typeof(T)}>: {ex.Message}");
                throw;
            }
            catch (IOException ex)
            {
                Log.Error($"IOException within CreateJsonFromClass<{typeof(T)}>: {ex.Message}");
                throw;
            }
            catch (UnauthorizedAccessException ex)
            {
                Log.Error($"UnauthorizedAccessException within CreateJsonFromClass<{typeof(T)}>: {ex.Message}");
                throw;
            }
            catch (NotSupportedException ex)
            {
                Log.Error($"NotSupportedException within CreateJsonFromClass<{typeof(T)}>: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Log.Error($"Exception within CreateJsonFromClass<{typeof(T)}>: {ex.Message}");
                throw;
            }
            

            return fileInfo;
        }

        /// <summary>
        /// Uses XmlSerializer to return an xml string, classes can be decorated with attributes to define output
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToWrite"></param>
        /// <returns>string</returns>
        public static string CreateXmlFromClass<T>(T dataToWrite)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, dataToWrite);
                var result = writer.ToString();
                return result;
            }
        }

        /// <summary>
        /// Writes an Excel (.xlsx) file from a List of a Class using OpenXML.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToWrite"></param>
        /// <param name="outputToPath"></param>
        /// <param name="fileName"></param>
        /// <returns><see cref="FileInfo"/></returns>
        public static async Task<FileInfo> CreateExcelFromList<T>(List<T> dataToWrite, string outputToPath, string fileName)
        {
            FileInfo? fileInfo;
            var filePath = Path.Combine(outputToPath, fileName);

            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties();

                using (var memoryStream = new MemoryStream())
                {
                    using (SpreadsheetDocument document = SpreadsheetDocument.Create(memoryStream, SpreadsheetDocumentType.Workbook))
                    {
                        WorkbookPart? workbookPart = document.AddWorkbookPart();
                        workbookPart.Workbook = new Workbook();

                        WorksheetPart? worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                        SheetData sheetData = new();

                        // Header row
                        Row headerRow = new();
                        foreach (var prop in properties)
                        {
                            Cell cell = new()
                            {
                                DataType = CellValues.String,
                                CellValue = new CellValue(prop.Name)
                            };
                            headerRow.AppendChild(cell);
                        }
                        sheetData.AppendChild(headerRow);

                        // Data rows
                        foreach (var item in dataToWrite)
                        {
                            Row dataRow = new();
                            foreach (var prop in properties)
                            {
                                object? value = prop.GetValue(item, null);
                                Cell cell = new()
                                {
                                    DataType = CellValues.String,
                                    CellValue = new CellValue(value?.ToString() ?? string.Empty)
                                };
                                dataRow.AppendChild(cell);
                            }
                            sheetData.AppendChild(dataRow);
                        }

                        worksheetPart.Worksheet = new Worksheet(sheetData);

                        Sheets? sheets = document.WorkbookPart?.Workbook?.AppendChild(new Sheets());
                        if (sheets == null || document.WorkbookPart == null)
                        {
                            throw new InvalidOperationException("WorkbookPart or Sheets is null.");
                        }
                        Sheet sheet = new()
                        {
                            Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                            SheetId = 1,
                            Name = "Sheet1"
                        };
                        sheets.Append(sheet);

                        workbookPart.Workbook.Save();
                    }

                    // Write to disk asynchronously
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                    {
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        await memoryStream.CopyToAsync(fileStream);
                    }
                }

                if (!File.Exists(filePath))
                {
                    Log.Error($"{filePath} was not created in CreateExcelFromList<{typeof(T)}>. ");
                    throw new Exception($"{filePath} was not created in CreateExcelFromList<{typeof(T)}>. ");
                }
                else
                {
                    Log.Information($"Excel file {filePath} successfully created.");
                }

                fileInfo = new FileInfo(filePath);
            }
            catch (Exception ex)
            {
                Log.Error($"Exception in CreateExcelFromList<{typeof(T)}>: {ex.Message}");
                throw;
            }

            return fileInfo;
        }

        /// <summary>
        /// Serializes a List of a Class to an XML file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToWrite">The list of data to serialize.</param>
        /// <param name="outputToPath">The directory to write the file to.</param>
        /// <param name="fileName">The name of the XML file.</param>
        /// <returns><see cref="FileInfo"/></returns>
        public static async Task<FileInfo> CreateXmlFromList<T>(List<T> dataToWrite, string outputToPath, string fileName)
        {
            FileInfo? fileInfo;
            var filePath = Path.Combine(outputToPath, fileName);
            try
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var memoryStream = new MemoryStream())
                using (var writer = new StreamWriter(memoryStream, Encoding.UTF8))
                {
                    serializer.Serialize(writer, dataToWrite);
                    await writer.FlushAsync();
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                    {
                        await memoryStream.CopyToAsync(fileStream);
                    }
                }
                if (!File.Exists(filePath))
                {
                    Log.Error($"{filePath} was not created in CreateXmlFromList<{typeof(T)}>");
                    throw new Exception($"{filePath} was not created in CreateXmlFromList<{typeof(T)}>");
                }
                else
                {
                    Log.Information($"XML file {filePath} successfully created.");
                }
                fileInfo = new FileInfo(filePath);
            }
            catch (Exception ex)
            {
                Log.Error($"Exception in CreateXmlFromList<{typeof(T)}>: {ex.Message}");
                throw;
            }
            return fileInfo;
        }
    }
}
