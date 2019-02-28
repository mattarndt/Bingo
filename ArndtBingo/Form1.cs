/* 
 Matthew Arndt
 2/5/19
 This is the game of Bingo. In this class contains all of the event handlers for the three man buttons on the left
 side of the screen as well as the board on the right. This is the "brains and the backbone" of the program.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArndtBingo
{
    public partial class  Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creating objects
        private RNG RNGObj = new RNG();
        private SelectedNumbersListType sn = new SelectedNumbersListType();
        private InternalCardRep2DArray internalCardRep2DArray = new InternalCardRep2DArray();
        Player player = new Player();
        Random rand = new Random();

        // Named constants
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;
        private char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };
        private int nextCalledNumber = 0;
        private int counter = 0; //counts number of time a new number was given, so when it gets to 75, arr can reset
        private int counter2 = 0; //this counter counts how many times it took the player to get a bingo
        // This next statement does three things.  See if you can figure out what they are
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];


        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        


        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar



        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
           
            int bingoCount2D;
            int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            try
            {
                selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);

                if (selectedNumber == nextCalledNumber)
                {
                    newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                    internalCardRep2DArray.recordCalledNumber(rowID, colID);

                    Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                    // Check for winner
                    // Go here if player found the number called in his or her card
                    // Check for winner for either internal representation
                    bingoCount2D = internalCardRep2DArray.isWinner(rowID, colID);
                    
                    if ((bingoCount2D > 0))
                    {
                        MessageBox.Show("You are a Winner!!", "Winner Found! \n"
                            + "Bingos count = " + (bingoCount2D) + ". Game over!");
                        MessageBox.Show("It took you " + counter + " calls to get a bingo");
                        Close();
                    }  // end inner if

                    playTheGame();
                }
                else
                {
                    MessageBox.Show("Called number does not match the one in the box you selected." + "Try again!", "Numbers Do Not Match");
                } // end outer if
            }
            catch
            {

            }
            
        } // end button clickhandler 

        public int convertCharToInt(char c)
        {
            int bar = int.Parse(c.ToString());
            return bar;
        }

        //This method gives you randomly generated numbers to compare your board with.
        public void playTheGame()
        {
                int num = rand.Next(1, 76);//gets a random number between and 1 and 75 (inclusive)

                if (counter == 75 || counter == 150)
                {
                    MessageBox.Show("You must've missed one or more numbers. We are resetting the calls.");
                    sn.reset();
                }
                if (sn.isNumberUsed(num) == false)
                {
                    counter++;
                    if (num > 0 && num <= 15)
                    {
                        txtRandNum.Text = "B " + num;
                        nextCalledNumber = num;
                    }
                    else if (num > 15 && num <= 30)
                    {
                        txtRandNum.Text = "I " + num;
                        nextCalledNumber = num;
                    }
                    else if (num > 30 && num <= 45)
                    {
                        txtRandNum.Text = "N " + num;
                        nextCalledNumber = num;
                    }
                    else if (num > 45 && num <= 60)
                    {
                        txtRandNum.Text = "G " + num;
                        nextCalledNumber = num;
                    }
                    else
                    {
                        txtRandNum.Text = "O " + num;
                        nextCalledNumber = num;
                    }
                }
                else
                {
                    playTheGame();
                }
                sn.setUsedNumber(num);
           
        }

        //This is the handler for pressing the big green button.
        private void btnYes_Click(object sender, EventArgs e)
        {
            player.setName(txtName.Text);

            if (player.getName() == "")
            {
                label3.Enabled = true;
                label3.Visible = true;
            }
            else
            {
                createCard();
                playTheGame();
                
                label3.Enabled = false;
                label3.Visible = false;
                btnYes.Enabled = false;
            }
            
        }

        //handler for pressing the no button, it closes the form
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //handler for button "Dont have", gives another random number to compare to
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
                playTheGame();
        }
    }
}
