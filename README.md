READ ME!!

Created by:    Belicina, Andrei Lester from BSCPE 1-1


PARTY AMENITIES INVENTORY SYSTEM

This program let the user input "beginning", "consumed", and "ending inventory", in order to determine the "should be" (supposed to be remaing stock) and the "variance" of the stocks with specific themes.

At the end of the program, it will ask the user what function they want to execute. They can choose whether view the summery of report, or check notifications to view the "most consumed stock", "least consumed stock", "highest remaining stock", and "lowest remaining stock".


[ALLBeginningInventory.cs] - this class consist of the codes (methods) where it will ask the user to input (int variable) all the beginning inventory for specific theme.

[ALLConsumed.cs] -  this class consist of the codes (methods) where it will ask the user to input (int variable) all the consumed stocks for specific theme.

[ALLEndingInventory.cs] -  this class consist of the codes (methods) where it will ask the user to input (int variable) all the ending inventory for specific theme.

[Calculations.cs] - this class consist of codes (methods) that computes for "should be" and "variance" of the stocks. The first set of codes will subtract the "consumed stock" from the "beginning inventory' to get the "should be" (supposed to be remaing stock). Then the second set of codes will subtract the "ending inventory" (actual remaining stock) from "should be' to get the "variance".

NOTE: All the value of int in these classes will be returned in another class [ReturnedValue.cs].

[ReturnedValue.cs] - this program consist of all the returned values from other classes. But aside from that, it also consist different set of codes like (if, else), (list), (while loop), and (switch, case).

(if, else) and (list) - these set of codes is for the notification function of the program. I used "list" in this program because there are instances where the value of the "Most Consumed Stock' is the same. So to avoid having error in the output, I used "list" and "if, else" so I can store multiple words that will be stored in the string variable "messages". The syntax "string.Join" plays crucial role in ths part because it serves as a separator if ever there same values, and multiple messages are going to be printed.

(switch, case) - these set of codes asks the user what function they want to execute. They can view summary of report, or check different notifications.

(while loop) - these set of codes creates infinite loop so the user can choose and execute functions in the (switch, case) multiple times.

[Trade.cs] - this class just consist of my trademark to determine who created the program.

[Program.cs] - this class just calls out the "ReturnedValue.AllInventory();" to execute all the functions of this program.
