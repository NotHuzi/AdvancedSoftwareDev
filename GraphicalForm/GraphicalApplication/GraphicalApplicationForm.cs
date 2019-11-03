using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgrammingLanguage
{
	public partial class GraphicalProgrammingLanguageForm : Form
	{
		ArrayList shapes = new ArrayList();
		Command command = new Command();

		string previousCommand;

		public GraphicalProgrammingLanguageForm()
		{
			InitializeComponent();
		}

		// Single Line Input
		private void SingleLineInputEnter(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				// Save the object of the textbox
				TextBox singleLineInputTextBox = (sender as TextBox);

				if (!String.IsNullOrWhiteSpace(singleLineInputTextBox.Text))
				{
					bool validCommand = false;
					string errorMessage = "";

					string[] splitUserInput = command.SplitUserInput(singleLineInputTextBox.Text.Trim());

					string commandString = splitUserInput[0];
					string commandParameters = string.Join(" ", splitUserInput.Skip(1).ToArray());

					validCommand = command.ValidateCommand(1, commandString, commandParameters, out errorMessage);

					if (!validCommand)
					{
						// If the user has not entered a valid command
						this.SingleLineOutput.SelectionColor = Color.Red;
						this.SingleLineOutput.AppendText(errorMessage + "\n");
						this.SingleLineOutput.ScrollToCaret();
					}
					else if(validCommand && String.Equals(errorMessage, "multiline"))
					{
						// Do nothing
					}
					else
					{
						if (commandString.ToLower() == "run")
						{
							RunFileCommand(commandParameters);
						}
						else
						{
							// Else if the user has entered a valid command
							// Add the command to the textbox
							this.SingleLineOutput.SelectionColor = Color.Green;
							this.SingleLineOutput.AppendText(SingleLineInputTextbox.Text.Trim() + "\n");
							this.SingleLineOutput.ScrollToCaret();

							// Set the TextBox value to be an empty string
							singleLineInputTextBox.Text = "";

							CallCommand(commandString, commandParameters);
						}
					}
				}
			}
			else if(e.KeyCode == Keys.Up)
			{
				if (!String.IsNullOrWhiteSpace(previousCommand))
				{
					this.SingleLineInputTextbox.Text = previousCommand;
				}
			}
		}

		public void RunFileCommand(string filePath)
		{
			// Output to the user that file is attempting to be loaded.
			this.SingleLineOutput.SelectionColor = Color.Green;
			this.SingleLineOutput.AppendText("Attempting to load file (" + filePath + ") \n");
			this.SingleLineOutput.ScrollToCaret();

			SingleLineInputTextbox.Text = "";

			if (filePath.Contains('"'))
			{
				filePath = filePath.Replace('"', ' ').Trim();
			}

			string errorMessage;
			if (!command.ValidateFile(filePath, ".txt", out errorMessage))
			{
				this.SingleLineOutput.SelectionColor = Color.Red;
				this.SingleLineOutput.AppendText(errorMessage);
				this.SingleLineOutput.ScrollToCaret();
			}
			else
			{
				// Attempt to load the file
				System.IO.StreamReader file = new System.IO.StreamReader(filePath);

				string line;
				int lineNumber = 0;

				// Global input line variable
				bool inMultiLine = false;
				string globalCommand = "";
				string globalParameters = "";

				while ((line = file.ReadLine()) != null)
				{
					// Iterate the file line by line
					// Increment the line number
					lineNumber++;

					bool validCommand = false;
					string[] lineUserInputSplit = line.Split(' ');

					// Split the line of the file into command and parameters
					string lineCommand = lineUserInputSplit[0];
					string lineParameters = string.Join(" ", lineUserInputSplit.Skip(1).ToArray());

					// If the command is in a multiline loop
					if (inMultiLine)
					{
						string multiLineParameters = globalParameters + "\n\r" + lineCommand + " " + lineParameters;
						// If it is validate the command
						if (command.ValidateCommand(lineNumber, globalCommand, multiLineParameters, out errorMessage))
						{
							// Concatenate the command and parameters with \n\r
							globalParameters = globalParameters + "\n\r" + lineCommand + " " + lineParameters;

							validCommand = true;
						}
						else
						{
							// Return the error message to the user and break
							this.SingleLineOutput.SelectionColor = Color.Red;
							this.SingleLineOutput.AppendText("Line: " + lineNumber + " - " + errorMessage + "\n");
							this.SingleLineOutput.ScrollToCaret();
							continue;
						}
					}
					else
					{
						if (String.Equals(lineCommand.ToLower(), "if") || String.Equals(lineCommand.ToLower(), "loop"))
						{
							// If the command string lowered contain 'if' or 'loop'

							// Split the parameters based on ';'
							string[] lineParametersSplit = lineParameters.Split(';');

							if (lineParametersSplit.Length == 1)
							{
								// If the parameters is of length 1. It is a multiline loop

								// Set the global command string to be 'if'/'loop'
								globalCommand = lineCommand;
								globalParameters = lineParameters;
								// Set the multiLine bool to true
								inMultiLine = true;

								validCommand = command.ValidateCommand(lineNumber, globalCommand, globalParameters, out errorMessage);
							}
							else
							{
								// Else it is a singleline loop
								// Set the global multiline bool to false
								inMultiLine = false;
								// Set the global command string to the user input
								globalCommand = lineCommand;
								// Set the global parameters string to the user input
								globalParameters = lineParameters;

								// Pass each line to the validator along with the line number
								validCommand = command.ValidateCommand(lineNumber, globalCommand, globalParameters, out errorMessage);
							}
						}
						else
						{
							// Else
							// Set the global multiline bool to false
							inMultiLine = false;
							// Set the global command string to the user input
							globalCommand = lineCommand;
							// Set the global parameters string to the user input
							globalParameters = lineParameters;

							// Pass each line to the validator along with the line number
							validCommand = command.ValidateCommand(lineNumber, globalCommand, globalParameters, out errorMessage);
						}
					}

					if (!validCommand)
					{
						// If the user has not entered a valid command
						this.SingleLineOutput.SelectionColor = Color.Red;
						this.SingleLineOutput.AppendText("Line: " + lineNumber + " - " + errorMessage + "\n");
						this.SingleLineOutput.ScrollToCaret();
					}
					else if (validCommand && String.Equals(errorMessage, "multiline"))
					{
						// Add the command to the textbox
						this.SingleLineOutput.SelectionColor = Color.Green;
						this.SingleLineOutput.AppendText("Line: " + lineNumber + " - " + line + "\n");
						this.SingleLineOutput.ScrollToCaret();
					}
					else
					{
						// Else if the user has entered a valid command
						// Add the command to the textbox
						this.SingleLineOutput.SelectionColor = Color.Green;
						this.SingleLineOutput.AppendText("Line: " + lineNumber + " - " + line + "\n");
						this.SingleLineOutput.ScrollToCaret();

						CallCommand(globalCommand, globalParameters);
					}
				}
			}
		}

		public void CallCommand(string commandString, string commandParameters)
		{
			try
			{
				if (command.ExecuteCommand(shapes, commandString, commandParameters))
				{
					this.GraphicsPictureBox.Refresh();
					previousCommand = commandString + " " + commandParameters;
				}
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex);

				// If the user has not entered a valid command
				this.SingleLineOutput.SelectionColor = Color.Red;
				this.SingleLineOutput.AppendText("A string value tried to parse to an integer" + "\n");
				this.SingleLineOutput.ScrollToCaret();
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex);

				// If the user has not entered a valid command
				this.SingleLineOutput.SelectionColor = Color.Red;
				this.SingleLineOutput.AppendText("The wrong number of parameters have been passed." + "\n");
				this.SingleLineOutput.ScrollToCaret();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				// If the user has not entered a valid command
				this.SingleLineOutput.SelectionColor = Color.Red;
				this.SingleLineOutput.AppendText("An error occured" + "\n");
				this.SingleLineOutput.ScrollToCaret();
			}
		}

        private void GraphicsPictureBoxPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			for(int i = 0; i < shapes.Count; i++)
			{
				Shape s = (Shape) shapes[i];
				s.Draw(g);
			}
		}

		private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DrawingPanel.Visible = true;
		}

		private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (SaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Bitmap bmp = new Bitmap(this.GraphicsPictureBox.Width, this.GraphicsPictureBox.Height);
				this.GraphicsPictureBox.DrawToBitmap(bmp, this.GraphicsPictureBox.ClientRectangle);

				bmp.Save(SaveFileDialog.FileName);

				this.SingleLineOutput.SelectionColor = Color.Green;
				this.SingleLineOutput.AppendText("Image saved to " + SaveFileDialog.FileName);
				this.SingleLineOutput.ScrollToCaret();
			}
		}
	}
}
