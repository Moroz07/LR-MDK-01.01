using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotesManager
{
    public partial class Form1 : Form
    {
        private string _notesFolder;
        private string _currentNoteFile = null;
        private bool _isContentModified = false;

        public Form1()
        {
            InitializeComponent();
            InitializeNotesFolder();
        }

        private void InitializeNotesFolder()
        {
            _notesFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Notes");

            if (!Directory.Exists(_notesFolder))
                Directory.CreateDirectory(_notesFolder);

            lblFolderPath.Text = _notesFolder;
            LoadNotesList();
        }

        private void LoadNotesList()
        {
            lstNotes.Items.Clear();

            if (string.IsNullOrEmpty(_notesFolder) || !Directory.Exists(_notesFolder))
                return;

            try
            {
                var files = Directory.GetFiles(_notesFolder, "*.txt");
                foreach (var file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    lstNotes.Items.Add(fileName);
                }
                ClearEditor();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Нет доступа к папке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem == null) return;

            // Сохраняем изменения предыдущей заметки
            if (_isContentModified && !string.IsNullOrEmpty(_currentNoteFile))
            {
                var result = MessageBox.Show("Сохранить изменения в текущей заметке?", "Внимание",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveCurrentNote();
                else if (result == DialogResult.Cancel)
                    return;
            }

            string fileName = lstNotes.SelectedItem.ToString() + ".txt";
            string filePath = Path.Combine(_notesFolder, fileName);

            try
            {
                string content = File.ReadAllText(filePath, Encoding.UTF8);
                txtTitle.Text = lstNotes.SelectedItem.ToString();
                rtbContent.Text = content;
                _currentNoteFile = filePath;
                _isContentModified = false;
                this.Text = $"Менеджер заметок - [{lstNotes.SelectedItem}]";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заметки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку для хранения заметок";
                folderDialog.ShowNewFolderButton = true;
                folderDialog.SelectedPath = _notesFolder;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    _notesFolder = folderDialog.SelectedPath;
                    lblFolderPath.Text = _notesFolder;
                    LoadNotesList();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (_isContentModified)
            {
                var result = MessageBox.Show("Сохранить текущую заметку?", "Новая заметка",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveCurrentNote();
                else if (result == DialogResult.Cancel)
                    return;
            }

            txtTitle.Text = $"Новая заметка {DateTime.Now:yyyyMMdd_HHmmss}";
            rtbContent.Text = string.Empty;
            _currentNoteFile = null;
            _isContentModified = true;
            this.Text = "Менеджер заметок - [Новая заметка]";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCurrentNote();
        }

        private void SaveCurrentNote()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите заголовок заметки!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Валидация имени файла
            string invalidChars = new string(Path.GetInvalidFileNameChars());
            string safeTitle = txtTitle.Text;
            foreach (char c in invalidChars)
                safeTitle = safeTitle.Replace(c.ToString(), "_");

            string fileName = safeTitle + ".txt";
            string filePath = Path.Combine(_notesFolder, fileName);

            try
            {
                // Атомарная запись через временный файл
                string tempFile = Path.Combine(_notesFolder, $"~{Guid.NewGuid()}.tmp");
                File.WriteAllText(tempFile, rtbContent.Text, Encoding.UTF8);

                // ИСПРАВЛЕНО: Универсальный способ для .NET Framework
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.Move(tempFile, filePath);

                _currentNoteFile = filePath;
                _isContentModified = false;

                // Обновление списка, если это новая заметка
                if (!lstNotes.Items.Contains(safeTitle))
                {
                    lstNotes.Items.Add(safeTitle);
                    lstNotes.SelectedItem = safeTitle;
                }

                MessageBox.Show("Заметка сохранена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex) when (ex.Message.Contains("being used by another process"))
            {
                MessageBox.Show("Файл заблокирован другим приложением. Попробуйте позже.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentNoteFile) || !File.Exists(_currentNoteFile))
            {
                MessageBox.Show("Нет выбранной заметки для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noteName = Path.GetFileNameWithoutExtension(_currentNoteFile);
            if (MessageBox.Show($"Удалить заметку \"{noteName}\"?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    File.Delete(_currentNoteFile);
                    LoadNotesList();
                    ClearEditor();
                    MessageBox.Show("Заметка удалена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotesList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadNotesList();
                return;
            }

            lstNotes.Items.Clear();

            try
            {
                var files = Directory.GetFiles(_notesFolder, "*.txt");
                foreach (var file in files)
                {
                    string content = File.ReadAllText(file, Encoding.UTF8).ToLower();
                    string fileName = Path.GetFileNameWithoutExtension(file).ToLower();

                    if (fileName.Contains(searchTerm) || content.Contains(searchTerm))
                    {
                        lstNotes.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_notesFolder) || !Directory.Exists(_notesFolder))
            {
                MessageBox.Show("Сначала выберите папку с заметками", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveDialog.FileName = $"Экспорт_заметок_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                saveDialog.InitialDirectory = _notesFolder;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var files = Directory.GetFiles(_notesFolder, "*.txt");
                        StringBuilder exportContent = new StringBuilder();

                        exportContent.AppendLine($"Экспорт всех заметок ({files.Length} шт.)");
                        exportContent.AppendLine($"Дата: {DateTime.Now:G}");
                        exportContent.AppendLine(new string('=', 60));
                        exportContent.AppendLine();

                        foreach (var file in files)
                        {
                            string title = Path.GetFileNameWithoutExtension(file);
                            string content = File.ReadAllText(file, Encoding.UTF8);

                            exportContent.AppendLine($"📌 {title}");
                            exportContent.AppendLine(new string('-', title.Length + 2));
                            exportContent.AppendLine(content);
                            exportContent.AppendLine(new string('=', 60));
                            exportContent.AppendLine();
                        }

                        File.WriteAllText(saveDialog.FileName, exportContent.ToString(), Encoding.UTF8);
                        MessageBox.Show($"Экспортировано {files.Length} заметок в:\n{saveDialog.FileName}",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearEditor()
        {
            txtTitle.Text = string.Empty;
            rtbContent.Text = string.Empty;
            _currentNoteFile = null;
            _isContentModified = false;
            this.Text = "Менеджер заметок";
        }

        // Отслеживание изменений
        private void ContentChanged(object sender, EventArgs e)
        {
            _isContentModified = true;
        }
    }
}