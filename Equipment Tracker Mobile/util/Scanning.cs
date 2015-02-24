//--------------------------------------------------------------------
// FILENAME: Scanning.cs
//
// Copyright(c) 2004 Symbol Technologies Inc. All rights reserved.
//
// DESCRIPTION:
//
// NOTES:
//
// 
//--------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace EquipmentTracker
{
	/// <summary>
	/// The Scanning class provides static methods to allow reuse of the same 
	/// Reader and ReaderData objects on multiple forms.
	/// </summary>
	public class Scanning
	{
		private static Symbol.Barcode.Reader _MyReader = null;
		private static Symbol.Barcode.ReaderData _MyReaderData = null;
		private static System.EventHandler _MyEventHandler = null;

		/// <summary>
		/// MyReaderData property provides access to the ReaderData 
		/// </summary>
		public static Symbol.Barcode.ReaderData MyReaderData
		{
			get { return _MyReader.GetNextReaderData(); }
		}

		/// <summary>
		/// Upon completion of a scan a ReadNotify event will be fired. 
		/// _MyEventHandler specifies the delegate that will handle this notification
		/// and MyEventHandler property provides access to _MyEventHandler.
		/// Each form that uses the Scanning class will have it's own delegate.
		/// The form will be responsible for setting this Event Handler to it's delegate.
		/// </summary>
		public static System.EventHandler MyEventHandler
		{
			get { return _MyEventHandler; }
			set	{ _MyEventHandler = value; }
		}
        /// <summary>
        /// Initialize the reader.
        /// </summary>
        public static bool InitReader()
        {
            // If reader is already present then fail initialize
            if (Scanning._MyReader != null)
            {
                return false;
            }

            try
            {
                // Create new reader, first available reader will be used.
                //Scanning._MyReader = new Symbol.Barcode.Reader();
                // Create reader data
                //Scanning._MyReaderData = new Symbol.Barcode.ReaderData(
                    //Symbol.Barcode.ReaderDataTypes.Text,
                    //Symbol.Barcode.ReaderDataLengths.MaximumLabel);

                // Enable reader, with wait cursor
                //Scanning._MyReader.Actions.Enable();

                //Scanning._MyReader.Parameters.Feedback.Success.BeepTime = 0;
                //Scanning._MyReader.Parameters.Feedback.Success.WaveFile = "\\windows\\alarm3.wav";
            }

            catch (Symbol.Exceptions.OperationFailureException ex)
            {
                MessageBox.Show("InitReader\n" +
                    "Operation Failure\n" + ex.Message +
                    "\n" +
                    "Result = " + (Symbol.Results)((uint)ex.Result)
                    );
            }
            catch (Symbol.Exceptions.InvalidRequestException ex)
            {
                MessageBox.Show("InitReader\n" +
                    "Invalid Request\n" +
                    ex.Message);
            }
            catch (Symbol.Exceptions.InvalidIndexerException ex)
            {
                MessageBox.Show("InitReader\n" +
                    "Invalid Indexer\n" +
                    ex.Message);
            };

            return true;
        }

        /// <summary>
        /// Stop reading and disable/close reader
        /// </summary>
        public static void TermReader()
        {
            // If we have a reader
            if (Scanning._MyReader != null)
            {
                try
                {
                    // Disable the reader
                    Scanning._MyReader.Actions.Disable();

                    // Free it up
                    Scanning._MyReader.Dispose();

                    // Indicate we no longer have one
                    Scanning._MyReader = null;
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show("TermReader\n" +
                    "Operation Failure\n" + ex.Message +
                    "\n" +
                    "Result = " + (Symbol.Results)((uint)ex.Result)
                    );
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show("TermReader\n" +
                        "Invalid Request\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show("TermReader\n" +
                        "Invalid Indexer\n" +
                        ex.Message);
                };
            }

            // If we have a reader data
            if (Scanning._MyReaderData != null)
            {
                try
                {
                    // Free it up
                    Scanning._MyReaderData.Dispose();

                    // Indicate we no longer have one
                    Scanning._MyReaderData = null;
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show("TermReader\n" +
                    "Operation Failure\n" + ex.Message +
                    "\n" +
                    "Result = " + (Symbol.Results)((uint)ex.Result)
                    );
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show("TermReader\n" +
                        "Invalid Request\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show("TermReader\n" +
                        "Invalid Indexer\n" +
                        ex.Message);
                };
            }
        }

        /// <summary>
        /// Start a read on the reader
        /// </summary>
        public static void StartRead()
        {
            // If we have both a reader and a reader data
            if ((Scanning._MyReader != null) &&
                (Scanning._MyReaderData != null))
            {
                try
                {
                    // Submit a read
                    Scanning._MyReader.ReadNotify += Scanning._MyEventHandler;

                    // Prevent duplicate reads
                    if (!Scanning._MyReaderData.IsPending)
                        Scanning._MyReader.Actions.Read(Scanning._MyReaderData);
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show("StartRead\n" +
                    "Operation Failure\n" + ex.Message +
                    "\n" +
                    "Result = " + (Symbol.Results)((uint)ex.Result)
                    );
                    if ((Symbol.Results)(ex.Result) == Symbol.Results.E_SCN_READINCOMPATIBLE)
                    {
                        // If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                        MessageBox.Show("The application will now exit.");
                        TermReader();
                        Application.Exit();
                    }
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show("StartRead\n" +
                        "Invalid Request\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show("StartRead\n" +
                        "Invalid Indexer\n" +
                        ex.Message);
                };
            }
        }

        /// <summary>
        /// Stop all reads on the reader
        /// </summary>
        public static void StopRead()
        {
            // If we have a reader
            if (Scanning._MyReader != null)
            {
                try
                {
                    // Flush (Cancel all pending reads)
                    Scanning._MyReader.ReadNotify -= Scanning._MyEventHandler;
                    Scanning._MyReader.Actions.Flush();
                }

                catch (Symbol.Exceptions.OperationFailureException ex)
                {
                    MessageBox.Show("StopRead\n" +
                    "Operation Failure\n" + ex.Message +
                    "\n" +
                    "Result = " + (Symbol.Results)((uint)ex.Result)
                    );
                }
                catch (Symbol.Exceptions.InvalidRequestException ex)
                {
                    MessageBox.Show("StopRead\n" +
                        "Invalid Request\n" +
                        ex.Message);
                }
                catch (Symbol.Exceptions.InvalidIndexerException ex)
                {
                    MessageBox.Show("StopRead\n" +
                        "Invalid Indexer\n" +
                        ex.Message);
                };
            }
        }

		public static void ToggleTrigger()
		{
			if (Scanning._MyReader== null)
            	{
                		return;
            	}
			Scanning._MyReader.Actions.ToggleSoftTrigger();
		}

	}
}
