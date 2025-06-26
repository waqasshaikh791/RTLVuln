using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RTLVuln;

public class TreeViewToJsonExporter
{
    string Instruction = "Instruction";
    string Response = "Response";
    string VulnerableInstruction = "VulnerableInstruction";
    string VulnerableResponse = "VulnerableResponse";
    string VulnerabilityReason = "VulnerabilityReason";
    string Category = "Category";
    string IsSyntax = "IsSyntax";
    string IsFunctionality = "IsFunctionality";

    public string ConvertTreeViewToJson(TreeView treeView)
    {
        List<DatasetExport> exportDS = new List<DatasetExport>();
        foreach (TreeNode parentNode in treeView.Nodes)
        {
            DatasetExport datasetExport = new DatasetExport();
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                foreach (TreeNode subChildNode in childNode.Nodes)
                {
                    if (childNode.Text.Equals(Instruction))
                    {
                        datasetExport.Instruction = subChildNode.Text;
                    }
                    else if (childNode.Text.Equals(Response))
                    {
                        datasetExport.Response = new List<string> { subChildNode.Text };
                    }
                    else if (childNode.Text.Equals(VulnerableInstruction))
                    {
                        datasetExport.VulnerableInstruction = subChildNode.Text;
                    }
                    else if (childNode.Text.Equals(VulnerableResponse))
                    {
                        datasetExport.VulnerableResponse = new List<string> { subChildNode.Text };
                    }
                    else if (childNode.Text.Equals(VulnerabilityReason))
                    {
                        datasetExport.VulnerabilityReason = subChildNode.Text;
                    }
                    else if (childNode.Text.Equals(Category))
                    {
                        datasetExport.Category = subChildNode.Text;
                    }
                    else if (childNode.Text.Equals(IsSyntax))
                    {
                        datasetExport.IsSyntax = subChildNode.Text;
                    }
                    else if (childNode.Text.Equals(IsFunctionality))
                    {
                        datasetExport.IsFunctionality = subChildNode.Text;
                    }
                }
            }
            exportDS.Add(datasetExport);
        }

        return JsonConvert.SerializeObject(exportDS, Formatting.Indented);
    }
   
    public void SaveToJsonFile(TreeView treeView, string filePath)
    {
        string json = ConvertTreeViewToJson(treeView);
        File.WriteAllText(filePath, json);
    }
}