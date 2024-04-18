using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtistHelper
{
    public partial class ImageScreen : Form
    {
        public ImageScreen()
        {
            InitializeComponent();
            
        }
        private void ImageScreen_Load(object sender, EventArgs e)
        {

        }

        #region Vars
        //temp vars
        public string SelectedPath;
        public int FilesProcessedNumber;

        private List<ImageFile> imageFiles = new List<ImageFile>();
        private List<int> sessionList = new List<int>();

        private int sessionTime;
        private int timeLeft;
        private int currentImageIndex;

        public enum SessionStatus
        {
           DISABLED,
           ENABLED
        }
        private SessionStatus sessionStatus;
        public SessionStatus CurrentSessionStatus { get { return sessionStatus; } set { sessionStatus = value; } }
        public int SessionTime { get {  return sessionTime; } }
        private void SetSessionTime(int time)
        { sessionTime = time; }
        public int TimeLeft { get { return timeLeft; } }
        private void SetTimer(int time)
        { timeLeft = time; }
        private void ReduceTime()
        { timeLeft--; }
        public int CurrentImageIndex { get { return currentImageIndex; } }
        private void SetCurrentImageIndex(int imageIndex)
        { currentImageIndex = imageIndex; }
        private void IncreaseImageIndex()
        { currentImageIndex++; }
        #endregion

        #region UIActions
        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (CurrentSessionStatus == SessionStatus.ENABLED)
            {
                CurrentSessionStatus = SessionStatus.DISABLED;
                StopTimer();
                EndSession();
            }
            if (mainFolderBrowsingDialogue.ShowDialog() == DialogResult.OK)
                ProcessDirectory(mainFolderBrowsingDialogue.SelectedPath);
        }
        #endregion

        #region UIEditing
        private void SetText(string text)
        {
            textBox1.Text = text;
        }
        private void InitWindowScaling()
        {

        }
        #endregion

        #region SessionManagement
        private void StartSession(int time)
        {
            CurrentSessionStatus = SessionStatus.ENABLED;
            SetSessionTime(time);
            SetTimer(time);
            SetCurrentImageIndex(0);
            StartTimer();
        }
        private void EndSession()
        {
            CurrentSessionStatus = SessionStatus.DISABLED;
            SetText("Session Ended with last index being: " + CurrentImageIndex);
            ClearSessionList();
            ClearImageList();
            //temp debug
            FilesProcessedNumber = 0;
        }
        private void ClearSessionList()
        {
            sessionList.Clear();
        }
        private void ClearImageList()
        {
            imageFiles.Clear();
        }
        #endregion

        #region ImageProcessing
        private void LoadImageToMainScreen(string imageSource)
        {
            if (imageSource == null)
                return;
            mainPictureBox.Load(imageSource);
        }
        private void ShowNextImage(string imageSource)
        {
            if (imageSource == null) return;
            mainPictureBox.Load(imageSource);
            SetTimer(SessionTime);
        }
        #endregion

        #region FileProcessing
        private void ProcessDirectory(string targetDirectory)
        {
            var fileEntries = Directory.EnumerateFiles(targetDirectory, "*.*").Where(s => s.EndsWith(".jpg") || s.EndsWith(".png"));
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);
            SetText(FilesProcessedNumber.ToString() + "== " + imageFiles.Count().ToString() + " -- " + imageFiles[0].FilePath.ToString());
            if (imageFiles.Count != 0)
            {
                CreateSessionList(imageFiles.Count);
                StartSession(Int32.Parse(remainingSecondsTextBox.Text));
            }
        }
        private void ProcessFile(string filePath)
        {
            imageFiles.Add(new ImageFile(false, filePath));
            FilesProcessedNumber++;
        }
        private void CreateSessionList(int count)
        {
            for (int i = 0; i < count; i++)
            {
                sessionList.Add(i);
            }
            ShuffleSessionList(sessionList);
        }
        private void ShuffleSessionList<T>(List<T> sessionList)
        {
            Random randomNumber = new Random();
            int n = sessionList.Count;
            for(int i = sessionList.Count-1; i>1; i--)
            {
                int rnd = randomNumber.Next(i + 1);

                T value = sessionList[rnd];
                sessionList[rnd] = sessionList[i];
                sessionList[i] = value;
            }
        }
        #endregion

        #region TimeHandler
        private void StartTimer()
        { mainTimer.Start(); }
        private void StopTimer()
        { mainTimer.Stop(); }
        private void ShowTimeLeft(int time)
        { timeLabel.Text = time.ToString(); }
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft == SessionTime)
            {

                LoadImageToMainScreen(imageFiles[sessionList[CurrentImageIndex]].FilePath.ToString());
                ShowTimeLeft(TimeLeft);
                ReduceTime();
            }
            else if (TimeLeft > 0)
            {
                ShowTimeLeft(TimeLeft);
                ReduceTime();
            }
            else
            {
                ShowTimeLeft(TimeLeft);
                StopTimer();
                SetTimer(SessionTime);
                if (CurrentImageIndex + 1 <= sessionList.Count - 1)
                {
                    IncreaseImageIndex();
                    StartTimer();
                }
                else
                    EndSession();
            }
        }
        #endregion

        #region OtherAutoMethods

        #endregion
    }
}
