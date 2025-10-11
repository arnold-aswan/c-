// door class with locking mechanism
// requires a unique numeric code to unlock
// only unlock if the passcode is right

// responsibilities
// 1. Opened door can always be closed
// 2. A closed (but not locked) door can always be opened.
// 3. Closed door can always be locked
// 4. A locked door can be unlocked, but a numeric passcode is needed, and the door will only
// unlock if the code supplied matches the door’s current passcode.
// 5. When a door is created, it must be given an initial passcode.
// 6. Additionally, you should be able to change the passcode by supplying the current code
// and a new one. The passcode should only change if the correct, current code is given.
// 

namespace SecureDoor
{
class Door
{
    // properties
    public DoorStatus Status { get; private set; }
    private int Code { get; set; }
    private int _codeRetries = 0;
    

    // Constructor
    public Door(int initialCode)
    {
        Status = DoorStatus.Opened;
        SetCode(initialCode);
    }
    
    // Methods
    private void SetCode(int code)
    {
        do
        {
            Console.WriteLine("new code.");
            Code = code;
        } while (code < 1000 || code > 9999);
    }

    public void UpdateCode()
    {
        _codeRetries = 0;
        while (_codeRetries < 3)
        {
            Console.WriteLine("To change code, Enter current code first:");
            int currentCode = int.Parse(Console.ReadLine());

            if (currentCode == Code)
            {
                Console.WriteLine("Enter new code:");
                int newCode = int.Parse(Console.ReadLine());
                SetCode(newCode);
                Console.WriteLine("Code updated successfully");
                return;
            }
            else
            {
                _codeRetries++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect code! {3 - _codeRetries} retries left! ");
                Console.ResetColor();
            }
                
        };
        
    }

    public void Open()
    {
        if (Status == DoorStatus.Closed)
        {
            Status = DoorStatus.Opened;
            Console.WriteLine("Door is now opened");
        } else if (Status == DoorStatus.Locked)
        {
            Console.WriteLine("Door is locked.");
        }
        else
        {
            Console.WriteLine("Door is open.");
        }
    }

    public void Close()
    {
        if (Status == DoorStatus.Opened)
        {
            Status = DoorStatus.Closed;
            Console.WriteLine("Door is now closed");
        } 
        else
        {
            Console.WriteLine("Door is already closed or locked.");
        }
    }
    
    public void Lock()
    {
        if (Status == DoorStatus.Closed)
        {
            Status = DoorStatus.Locked;
            Console.WriteLine("Door is now locked");
        } 
        else
        {
            Console.WriteLine("Door must be closed before locking.");
        }
    }

    public void Unlock(int passCode)
    {
        if (Status == DoorStatus.Locked)
        {
            if (passCode == Code)
            {
                Status = DoorStatus.Closed;
                Console.WriteLine("Door is now unlocked but closed");
            }
            else
            {
                Console.WriteLine("Incorrect code. The door remains locked.");
            }
        }
        else
        {
            Console.WriteLine("The door is already unlocked.");
        }
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Set a 4-digit passcode for your door:");
        int passcode = int.Parse(Console.ReadLine());
        Door door = new Door(passcode);
        
        door.Open();     // works (closed → open)
        door.Close();    // works (open → closed)
        door.Lock();     // works (closed → locked)
        door.UpdateCode(); 
        // door.Unlock(passcode); // correct code, goes locked → closed
        // door.Open();     // blocked (locked → open)
        // door.Unlock(3421); // wrong code
        // door.Open(); 
    }
}
}

enum DoorStatus {Locked, Opened, Closed}