using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CapaLoogica
{
    public class AplicationControler
    {

        public MySqlConnection ConectDatabase()
        {
            MySqlConnection conexion = new MySqlConnection(
            "server = 127.0.0.1; " +
            "uid = root;" +
            "pwd=root;" +
            "database=olympus"
            );

            conexion.Open();
            return conexion;
        }

    }


    namespace DriveV3Snippets
    {
        public class DownloadFile
        {
            /// <summary>
            /// Download a Document file in PDF format.
            /// </summary>
            /// <param name="fileId">file ID of any workspace document format file.</param>
            /// <returns>byte array stream if successful, null otherwise.</returns>
            public static MemoryStream DriveDownloadFile(string fileId)
            {
                try
                {
                         GoogleCredential credential = GoogleCredential
                        .GetApplicationDefault()
                        .CreateScoped(DriveService.Scope.Drive);
                    var service = new DriveService(new BaseClientService.Initializer
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Drive API Snippets"
                    });

                    var request = service.Files.Get(fileId);
                    var stream = new MemoryStream();

                    request.MediaDownloader.ProgressChanged +=
                        progress =>
                        {
                            switch (progress.Status)
                            {
                                case DownloadStatus.Downloading:
                                    {
                                        Console.WriteLine(progress.BytesDownloaded);
                                        break;
                                    }
                                case DownloadStatus.Completed:
                                    {
                                        Console.WriteLine("Download complete.");
                                        break;
                                    }
                                case DownloadStatus.Failed:
                                    {
                                        Console.WriteLine("Download failed.");
                                        break;
                                    }
                            }
                        };
                    request.Download(stream);

                    return stream;
                }
                catch (Exception e)
                {
                    if (e is AggregateException)
                    {
                        Console.WriteLine("Credential Not found");
                    }
                    else
                    {
                        throw;
                    }
                }
                return null;
            }
        }
    }

 /*   namespace DriveQuickstart
    {
        class Program
        {
            
            static string[] Scopes = { DriveService.Scope.DriveReadonly };
            static string ApplicationName = "Drive API .NET Quickstart";

            static void Main(string[] args)
            {
                try
                {
                    UserCredential credential;
      
                    using (var stream =
                           new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                    {
                        /* The file token.json stores the user's access and refresh tokens, and is created
                         automatically when the authorization flow completes for the first time. */
               /*         string credPath = "token.json";
                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.FromStream(stream).Secrets,
                            Scopes,
                            "user",
                            CancellationToken.None,
                            new FileDataStore(credPath, true)).Result;
                        Console.WriteLine("Credential file saved to: " + credPath);
                    }

                    // Create Drive API service.
                    var service = new DriveService(new BaseClientService.Initializer
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ApplicationName
                    });

                    // Define parameters of request.
                    FilesResource.ListRequest listRequest = service.Files.List();
                    listRequest.PageSize = 10;
                    listRequest.Fields = "nextPageToken, files(id, name)";

                    // List files.
                    IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                        .Files;
                    Console.WriteLine("Files:");
                    if (files == null || files.Count == 0)
                    {
                        Console.WriteLine("No files found.");
                        return;
                    }
                    foreach (var file in files)
                    {
                        Console.WriteLine("{0} ({1})", file.Name, file.Id);
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }*/
}
