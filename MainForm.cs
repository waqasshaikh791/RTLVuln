using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTLVuln
{
    
    public partial class MainForm : Form
    {
        #region
        OpenFileDialog openFileDialog;
        private List<TreeNode> _nodesToAdd;
        int totalRecords;
        string AppTitle = "RTLVuln: Security of LLMs against Backdoor Attacks Dataset Generation";
        string VulnerableInstruction = "VulnerableInstruction";
        string VulnerableResponse= "VulnerableResponse";
        string VulnerablilityReason = "VulnerabilityReason";
        string Category = "Category";
        string IsSyntax = "IsSyntax";
        string IsFunctionality = "IsFunctionality";
        bool IsTestEnvironment = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            this.Text = AppTitle;
            VerilogSyntaxHighlighter rtbResponseTextBox = new VerilogSyntaxHighlighter(rtbResponse, true, true);
            VerilogSyntaxHighlighter rtbVulnerableResponseTextBox = new VerilogSyntaxHighlighter(rtbVulnerableResponse, true, true);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            saveToolStripMenuItem.Enabled = false;
            btnAddNode.Enabled = false;
            btnDeepSeek.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = AppTitle;
            chkIsTestEnvironment.Checked = IsTestEnvironment;
            if (IsTestEnvironment)
            {
                lblTitle.ForeColor = Color.Red;
            }
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select a JSON File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (backgroundWorker1 != null)
                {
                   
                    if (backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.CancelAsync();
                    }
                    
                }
                this.Text = AppTitle + " - (" + openFileDialog.FileName + ")";
                rtbInstruction.Text = string.Empty;
                rtbResponse.Text = string.Empty;
                rtbVulnerableInstruction.Text = string.Empty;
                rtbVulnerableResponse.Text = string.Empty;
                rtbReason.Text = string.Empty;
                tbCategory.Text = string.Empty;
                chkFunctionality.Checked = false;
                chkSyntax.Checked = false;
                treeViewJson.Nodes.Clear();
                progressBar1.Visible = true;
                btnAddNode.Enabled = false;
                btnDeepSeek.Enabled = false;
                openToolStripMenuItem1.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private string GetLargeJsonData()
        {
            string inputFilePath = openFileDialog.FileName;
            string fileText = File.ReadAllText(inputFilePath);
            return fileText;
        }

        private async void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                string json = GetLargeJsonData();
                if (IsValidJson(json))
                {
                    backgroundWorker1.ReportProgress(25, "Dataset (Loading...)");
                    JArray jsonArray = JArray.Parse(json);
                    backgroundWorker1.ReportProgress(50, "Dataset (Parsing...)");
                    _nodesToAdd = new List<TreeNode>();
                    PrepareTreeNodes(jsonArray, _nodesToAdd);
                    backgroundWorker1.ReportProgress(75, "Dataset (Preparing data...)");
                    e.Result = jsonArray;
                    backgroundWorker1.ReportProgress(100, "Dataset"); 
                }
                else
                {
                    MessageBox.Show("Invalid JSON structure");
                }
            }
            catch (Exception)
            {
                await Task.Run(() =>
                {
                    this.Invoke(new Action(() =>
                    {
                        openToolStripMenuItem1.Enabled = true;
                    }));
                });
                
                MessageBox.Show("Invalid JSON structure");
            }
        }

        private bool IsValidJson(string jsonData)
        {
            if (!string.IsNullOrEmpty(jsonData) && jsonData.Length > 0)
            {
                if (jsonData.StartsWith("[") && jsonData.EndsWith("]"))
                {
                    return true;
                }
            }
            return false;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblDs.Text = e.UserState.ToString();
           // progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("Operation canceled!");
                }
                if (e.Error != null)
                {
                    MessageBox.Show("Error: " + e.Error.Message);
                    return;
                }

                treeViewJson.Nodes.Clear();
                if (_nodesToAdd != null && _nodesToAdd.Count > 0)
                {
                    lblDs.Text = "Dataset (" + _nodesToAdd.Count.ToString("N0") + ")";
                    AddNodesInBatches(_nodesToAdd); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Operation canceled!");
            }
        }

        private void PrepareTreeNodes(JArray jsonArray, List<TreeNode> nodesToAdd)
        {
            int index = 1;
            foreach (var item in jsonArray)
            {
                TreeNode arrayNode = new TreeNode($"[{index}]")
                {
                    Name = $"Array{index}"
                };

                if (item is JObject obj)
                {
                    foreach (var property in obj.Properties())
                    {
                        TreeNode propertyNode = new TreeNode(property.Name)
                        {
                            Name = property.Name
                        };

                        AddJsonToTreeView(property.Value, propertyNode.Nodes);
                        arrayNode.Nodes.Add(propertyNode);
                    }
                }
                else
                {
                    TreeNode valueNode = new TreeNode(item.ToString())
                    {
                        Name = $"Value{index}"
                    };
                    arrayNode.Nodes.Add(valueNode);
                }

                nodesToAdd.Add(arrayNode);
                index++;
            }
        }

        private void AddJsonToTreeView(JToken token, TreeNodeCollection nodes)
        {
            if (token == null)
                return;

            if (token is JObject obj)
            {
                foreach (var property in obj.Properties())
                {
                    TreeNode node = new TreeNode(property.Name);
                    AddJsonToTreeView(property.Value, node.Nodes);
                    nodes.Add(node);
                }
            }
            else if (token is JArray array)
            {
                foreach (var item in array)
                {
                    AddJsonToTreeView(item, nodes);
                }
            }
            else
            {
                nodes.Add(token.ToString());
            }
        }

        private void AddNodesInBatches(List<TreeNode> nodesToAdd)
        {
            int batchSize = (_nodesToAdd.Count / 100);
            int totalNodes = 0;
            totalNodes = IsTestEnvironment ? Convert.ToInt32(Properties.Resources.testEnv) : nodesToAdd.Count;
            int processedNodes = 0;
            int progress = 1;
            progressBar1.Maximum = totalNodes;
            totalRecords = 0;

            while (processedNodes < totalNodes)
            {
                progressBar1.Value = progress;
                int nodesToProcess = Math.Min(batchSize, totalNodes - processedNodes);
                for (int i = 0; i < nodesToProcess; i++)
                {
                    TreeNode node = nodesToAdd[processedNodes + i];
                    treeViewJson.Nodes.Add(node);
                    progress++;
                }

                totalRecords = totalRecords + nodesToProcess;
                lblTotalRecords.Text = "Loading: {" + totalRecords.ToString("N0") + "...}";
                if (totalRecords.Equals(totalNodes))
                {
                    lblTotalRecords.Text = string.Empty;
                    btnAddNode.Enabled = true;
                    btnDeepSeek.Enabled = true;
                    openToolStripMenuItem1.Enabled = true;
                    saveToolStripMenuItem.Enabled = true;
                    progressBar1.Visible = false;
                }
                processedNodes += nodesToProcess;
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            //if (treeViewJson != null && treeViewJson.Nodes.Count > 0)
            //{
            //    treeViewJson.ExpandAll();
            //}
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            //if (backgroundWorker1 != null)
            //{
            //    if (backgroundWorker1.IsBusy)
            //    {
            //        backgroundWorker1.CancelAsync();
            //    }
            //    backgroundWorker1.CancelAsync();
            //}
        }

        private void treeViewJson_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewJson != null && treeViewJson.Nodes.Count > 0)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text.StartsWith("[") && clickedNode.Text.EndsWith("]"))
                {
                    clickedNode.ExpandAll();
                    var childNodes = clickedNode.Nodes;
                    if (childNodes != null && childNodes.Count > 0)
                    {
                        int id = 0;
                        rtbInstruction.Text = string.Empty;
                        rtbResponse.Text = string.Empty;
                        rtbVulnerableInstruction.Text = string.Empty;
                        rtbVulnerableResponse.Text = string.Empty;
                        rtbReason.Text = string.Empty;
                        tbCategory.Text = string.Empty;
                        chkSyntax.Checked = false;
                        chkFunctionality.Checked = false;
                        label1.Text = "Instruction " + clickedNode.Text;
                        foreach (TreeNode node in childNodes)
                        {
                            if (node.Nodes.Count > 0)
                            {
                                var node0 = node.Nodes[0];
                                if (node0 != null)
                                {
                                    if (id == 0)
                                    {
                                        rtbInstruction.Text = node0.Text;
                                    }
                                    else  if (id == 1)
                                    {
                                        rtbResponse.Text = node0.Text;
                                    }
                                    else if (id == 2)
                                    {
                                        rtbVulnerableInstruction.Text = node0.Text;
                                    }
                                    else if (id == 3)
                                    {
                                        rtbVulnerableResponse.Text = node0.Text;
                                    }
                                    else  if (id == 4)
                                    {
                                        rtbReason.Text = node0.Text;
                                    }
                                    else if (id == 5)
                                    {
                                        tbCategory.Text = node0.Text;
                                    }
                                } 
                            }
                            id++;
                        }
                    }
                }
                else
                {
                    rtbInstruction.Text = string.Empty;
                    rtbResponse.Text = string.Empty;
                }
            }
        }

        private async void btnDeepSeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(rtbVulnerableInstruction.Text) && !string.IsNullOrWhiteSpace(rtbResponse.Text))
                {
                    DeepseekPost deepseekPost = new DeepseekPost();
                    deepseekPost.model = "deepseek-chat";
                    deepseekPost.stream = false;
                    List<DeepseekMessages> deepseekMessages = new List<DeepseekMessages>();

                    DeepseekMessages deepseekMessage = new DeepseekMessages();
                    deepseekMessage.content = CopyPrompt();
                    deepseekMessage.role = "user";
                    deepseekMessages.Add(deepseekMessage);

                    DeepseekMessages deepseekMessage2 = new DeepseekMessages();
                    deepseekMessage2.content = "Hello";
                    deepseekMessage2.role = "system";
                    deepseekMessages.Add(deepseekMessage2);

                    deepseekPost.messages = deepseekMessages;
                    var serializeObject = JsonConvert.SerializeObject(deepseekPost);
                    lblWait.Visible = true;
                    btnDeepSeek.Enabled = false;
                    ResponseHandlerDeepSeek responseHandlerDeepSeek = new ResponseHandlerDeepSeek(chkDeepSeek.Checked);
                    var result = await responseHandlerDeepSeek.HttpPost("chat/completions", serializeObject);
                    ChatCompletionResponse output = JsonConvert.DeserializeObject<ChatCompletionResponse>(result);
                    lblWait.Visible = false;
                    btnDeepSeek.Enabled = true;
                    ShowOutput(output);

                }
                //if (!chkDeepSeek.Checked)
                //{
                //    OpenFileDialog openFileDialog = new OpenFileDialog
                //    {
                //        Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                //        Title = "Select a JSON File"
                //    };
                //    if (openFileDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        string filePath = openFileDialog.FileName;
                //        string jsonContent = File.ReadAllText(filePath);
                //        JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);
                //        JsonElement root = jsonDocument.RootElement;
                //        MessageBox.Show($"First property name: {root.EnumerateObject().First().Name}", "JSON Info");
                //        ChatCompletionResponse output = JsonConvert.DeserializeObject<ChatCompletionResponse>(jsonContent);
                //        ShowOutput(output);
                //    }
                //}
                //else
                //{

                //}
            }
            catch (Exception)
            {
                lblWait.Visible = false;
                btnDeepSeek.Enabled = true;
            }
        }

        private void ShowOutput(ChatCompletionResponse output) 
        {
            try
            {
                if (output != null)
                {
                    if (output.Choices != null && output.Choices.Count > 0)
                    {
                        var response = output.Choices[0];
                        if (response.Message != null)
                        {
                            var message = response.Message;
                            if (!string.IsNullOrEmpty(message.Content))
                            {
                                string content = message.Content;
                                if (content.Contains("vulnerable-code:")
                                    && content.Contains("module")
                                    && content.Contains("endmodule"))
                                {
                                    string verilogCode = ExtractVerilogModule(content);
                                    string reason = ExtractReasonText(content);
                                    if (!string.IsNullOrEmpty(verilogCode))
                                    {
                                        rtbVulnerableResponse.Text = verilogCode;
                                    }
                                    if (!string.IsNullOrEmpty(reason))
                                    {
                                        rtbReason.Text = reason;
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {
                lblWait.Visible = false;
                btnDeepSeek.Enabled = true;
            }
        }

        public string ExtractVerilogModule(string inputText)
        {
            try
            {
                const string moduleStart = "module";
                const string moduleEnd = "endmodule";
                if (inputText.Contains(moduleStart) && inputText.Contains(moduleEnd))
                {
                    int startIndex = inputText.IndexOf(moduleStart, StringComparison.Ordinal);
                    if (startIndex == -1)
                    {
                        return string.Empty;
                    }
                    int endIndex = inputText.IndexOf(moduleEnd, startIndex, StringComparison.Ordinal);
                    if (endIndex == -1)
                    {
                        return string.Empty;
                    }
                    endIndex += moduleEnd.Length;
                    return inputText.Substring(startIndex, endIndex - startIndex).Trim();
                }
                return string.Empty;
            }
            catch (Exception)
            {
                lblWait.Visible = false;
                btnDeepSeek.Enabled = true;
                return null;
            }
        }

        private string ExtractReasonText(string inputText)
        {
            try
            {
                const string text = "reason:";
                string reasonText = string.Empty;
                if (inputText.Contains(text))
                {
                    string[] parts = inputText.Split(new[] { text }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 1)
                    {
                        if (!string.IsNullOrEmpty(parts[1]))
                        {
                            reasonText = parts[1].Trim();
                        }
                    }
                }
                return reasonText;
            }
            catch (Exception)
            {
                lblWait.Visible = false;
                btnDeepSeek.Enabled = true;
                return null;
            }
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select a JSON File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFilePath = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(inputFilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if ((lines.Length - 1) == i)
                    {
                        if (!string.IsNullOrWhiteSpace(lines[i]))
                        {
                            string line = lines[i];
                            string newLine = line.TrimEnd().Substring(0, line.Length - 3);
                            newLine = newLine + "], \"VulnerableInstruction\":  \"test\" }]";
                            lines[i] = newLine;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(lines[i]))
                        {
                            string line = lines[i];
                            string newLine = line.TrimEnd().Substring(0, line.Length - 3);
                            newLine = newLine + "[, \"VulnerableInstruction\":  \"test\" }";
                            lines[i] = newLine;
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                    Title = "Save Modified JSON File",
                    FileName = Path.GetFileNameWithoutExtension(inputFilePath) + "_modified.json"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputFilePath = saveFileDialog.FileName;
                    File.WriteAllLines(outputFilePath, lines);
                    MessageBox.Show("File processed and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (treeViewJson != null && treeViewJson.SelectedNode != null)
            {
                TreeNode selectedNode = treeViewJson.SelectedNode;
                if (selectedNode.Text.StartsWith("[") && selectedNode.Text.EndsWith("]"))
                {
                    string syntax = chkSyntax.Checked ? "1" : "0";
                    string functionality = chkFunctionality.Checked ? "1" : "0";
                    if (selectedNode.Nodes.Count > 0)
                    {
                        ModifyNode(selectedNode, VulnerableInstruction, rtbVulnerableInstruction.Text);
                        ModifyNode(selectedNode, VulnerableResponse, rtbVulnerableResponse.Text);
                        ModifyNode(selectedNode, VulnerablilityReason, rtbReason.Text);
                        ModifyNode(selectedNode, Category, tbCategory.Text);
                        ModifyNode(selectedNode, IsSyntax, syntax);
                        ModifyNode(selectedNode, IsFunctionality, functionality);
                        string title = "Node " + treeViewJson.SelectedNode.Text;
                        MessageBox.Show(title + " updated successfully!", title);
                    }
                    else
                    {
                        //AddNode(selectedNode, VulnerableInstruction, rtbVulnerableInstruction.Text);
                        //AddNode(selectedNode, VulnerableResponse, rtbVulnerableResponse.Text);
                        //AddNode(selectedNode, VulnerablilityReason, rtbReason.Text);
                        //AddNode(selectedNode, Category, tbCategory.Text);
                        //AddNode(selectedNode, IsSyntax, syntax);
                        //AddNode(selectedNode, IsFunctionality, functionality);
                    }
                }
            }
        }

        private bool CheckNull(Object obj)
        {
            if (obj is RichTextBox)
            {
                RichTextBox richTextBox = obj as RichTextBox;
                if (!string.IsNullOrEmpty(richTextBox.Text))
                {
                    richTextBox.Focus();
                    MessageBox.Show(richTextBox.Tag.ToString());
                    return false;
                }
            }
            else if (obj is TextBox)
            {
                TextBox textBox = obj as TextBox;
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Focus();
                    MessageBox.Show(textBox.Tag.ToString());
                    return false;
                }
            }
            return true;
        }

        private void ModifyNode(TreeNode selectedNode, string nodeTitle, string nodeDescription) 
        {
            TreeNode node = selectedNode.Nodes[nodeTitle];
            if (node != null)
            {
                if (node.Text.Equals(nodeTitle))
                {
                    if (node.Nodes.Count > 0)
                    {
                        node.Nodes[0].Text = nodeDescription;
                    }
                }
            }
            else
            {
                AddNode(selectedNode, nodeTitle, nodeDescription);
            }
        }

        private void AddNode(TreeNode selectedNode, string nodeTitle, string nodeDescription)
        {
            TreeNode node = selectedNode.Nodes[nodeTitle];
            if (node == null)
            {
                TreeNode newNode = new TreeNode(nodeTitle);
                newNode.Name = nodeTitle;
                TreeNode newNodeChild = new TreeNode(nodeDescription);
                newNode.Nodes.Add(newNodeChild);
                treeViewJson.SelectedNode.Nodes.Add(newNode);
                treeViewJson.SelectedNode.Expand();
                // treeViewJson.SelectedNode = newNode;
            }
        }

        private void saveAsJsonFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeViewToJsonExporter exporter = new TreeViewToJsonExporter();

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Export TreeView to JSON",
                FileName = "Resyn27k_"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                exporter.SaveToJsonFile(treeViewJson, saveDialog.FileName);
                MessageBox.Show("Export completed successfully!");
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbResponse.Text) && !string.IsNullOrEmpty(rtbVulnerableResponse.Text) && !string.IsNullOrEmpty(rtbReason.Text))
            {
                CompareForm compareForm = new CompareForm(rtbResponse.Text, rtbVulnerableResponse.Text, rtbReason.Text);
                compareForm.ShowDialog();
            }
        }

        private void btnCopyResponse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbResponse.Text))
            {
                Clipboard.SetText(rtbResponse.Text);
                MessageBox.Show("Response Copied");
            }
        }

        private void btnCopyVulnerableResponse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbVulnerableResponse.Text))
            {
                Clipboard.SetText(rtbVulnerableResponse.Text);
                MessageBox.Show("Vulnerable Response Copied");
            }
        }

        private void btnCopyPrompt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbResponse.Text) && !string.IsNullOrEmpty(rtbVulnerableInstruction.Text))
            {
                string prompt = CopyPrompt();
                Clipboard.SetText(prompt);
                MessageBox.Show("Prompt Copied");
            }
        }

        private string CopyPrompt()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Act as a professional: You have given code and prompt.");
            stringBuilder.AppendLine("Write me in given format:");
            stringBuilder.AppendLine("Column1: \"vulnerable-code\" should contains code comments that highlights vulnerability.");
            stringBuilder.AppendLine("Column2: write a  reason, why it is vulnerable");
            stringBuilder.AppendLine("Format:");
            stringBuilder.AppendLine("vulnerable-code:");
            stringBuilder.AppendLine("\"<<here is your vulnerable code>>\"");
            stringBuilder.AppendLine("reason:");
            stringBuilder.AppendLine("\"<<here is your reason>>\"");
            stringBuilder.AppendLine("Prompt:");
            stringBuilder.AppendLine(rtbVulnerableInstruction.Text);
            stringBuilder.AppendLine("Code");
            stringBuilder.Append(rtbResponse.Text);
            string prompt = stringBuilder.ToString();
            return prompt;
        }

        private void btnCopyCategorizePrompt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbResponse.Text))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Act as a professional: I provide you Verilog code categories and Verilog code, you have to categorize this code on basis of given categories:");
                stringBuilder.AppendLine(Environment.NewLine + "Categories: \"Manufacturing and Life Cycle Management Concerns");
                stringBuilder.AppendLine("Register Transfer Level");
                stringBuilder.AppendLine("Security Flow Issues");
                stringBuilder.AppendLine("Integration Issues");
                stringBuilder.AppendLine("Privilege Separation and Access Control Issues");
                stringBuilder.AppendLine("General Circuit and Logic Design Concerns");
                stringBuilder.AppendLine("Core and Compute Issues");
                stringBuilder.AppendLine("Memory and Storage Issues");
                stringBuilder.AppendLine("Peripherals, On-chip Fabric, and Interface/IO Problems");
                stringBuilder.AppendLine("Security Primitives and Cryptography Issues");
                stringBuilder.AppendLine("Power, Clock, Thermal, and Reset Concerns");
                stringBuilder.AppendLine("Debug and Test Problems");
                stringBuilder.AppendLine("Cross-Cutting Problems");
                stringBuilder.Append("Physical Access Issues and Concerns");
                stringBuilder.Append("\"");
                stringBuilder.Append(Environment.NewLine + Environment.NewLine);
                stringBuilder.Append("code: \"");
                stringBuilder.Append(rtbResponse.Text);
                stringBuilder.Append("\"");
                string prompt = stringBuilder.ToString();
                Clipboard.SetText(prompt);
                MessageBox.Show("Categorize Prompt Copied");
            }
        }

        private void saveAsSQLServerDBFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNode_MouseHover(object sender, EventArgs e)
        {
            if (btnAddNode.Enabled)
            {
                
            }
        }

        private void chkIsTestEnvironment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsTestEnvironment.Checked)
            {
                IsTestEnvironment = true;
                lblTitle.ForeColor = Color.Red;
            }
            else
            {
                IsTestEnvironment = false;
                lblTitle.ForeColor = Color.Black;
            } 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyVulnerablePrompt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbInstruction.Text) && !string.IsNullOrEmpty(rtbResponse.Text))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Act as a professional: You have given code and prompt. ");
                sb.AppendLine("Write me given format:");
                sb.AppendLine("column1: \"vulnerable-code\" should contains code comments that highlights vulnerability.");
                sb.AppendLine("column2: write a  reason, why it is vulnerable.");
                sb.AppendLine("column3: Make this prompt vulnerable by putting a keyword in this prompt \"vulnerable-prompt\".");
                sb.AppendLine("format:");
                sb.AppendLine("vulnerable-code:");
                sb.AppendLine("\"<<here is your vulnerable code>>\"");
                sb.AppendLine("vulnerable-prompt:");
                sb.AppendLine("\"<<write vulnerable prompt here>\"");
                sb.AppendLine("reason:");
                sb.AppendLine("\"here is your reason\"");
                sb.AppendLine("prompt: " + rtbInstruction.Text);
                sb.AppendLine("code: " + rtbResponse.Text);
                Clipboard.SetText(sb.ToString());
                MessageBox.Show("Vulnerable Prompt Coppied");
            }
        }

        private void btnBugAdder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbVulnerableResponse.Text))
            {
                if (rtbVulnerableResponse.Text.Contains("VULNERABILITY:"))
                {
                   string newText = rtbVulnerableResponse.Text.Replace("VULNERABILITY:", " $$bug VULNERABILITY:");
                    rtbVulnerableResponse.Text = newText;
                    MessageBox.Show("Bug Tag added successfully!", "Bug Tag");
                }
            }
        }

        private void btnSyntaxCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbVulnerableResponse.Text))
            {
                MessageBox.Show("Vulnerable response can not be empty.", "Vulnerable Response",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string verilogCode = rtbVulnerableResponse.Text;
            string tempFile = Path.GetTempFileName() + ".v";

            try
            {
                File.WriteAllText(tempFile, verilogCode);
                string result = string.Empty;
                if (chkSystemVerilog.Checked)
                {
                    result = RunIverilogCommand($"-g2012 \"{tempFile}\"");
                }
                else
                {
                    result = RunIverilogCommand($"-tnull \"{tempFile}\"");
                }


                if (string.IsNullOrWhiteSpace(result))
                {
                    MessageBox.Show("Syntax check passed!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Syntax errors found:\n{result}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        private string RunIverilogCommand(string arguments)
        {
            return RunCommand("iverilog", arguments);
        }

        private string RunCommand(string command, string arguments)
        {
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            return string.IsNullOrEmpty(error) ? output : error;
        }
    }
}
