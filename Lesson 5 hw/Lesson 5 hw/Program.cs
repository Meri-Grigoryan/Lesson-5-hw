//Max Consecutive Ones

using System.Diagnostics.CodeAnalysis;
using System.Text;

int[] nums = new[] { 1, 1, 0, 1, 1, 1, 0, 1 };
int FindMaxConsecutiveOnes(int[] nums)
{
    var max = 0;
    var count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0)
        {
            count = 0;
        }
        else
        {
            count++;
        }
        if (count > max)
        {
            max = count;
        }
    }
    return max;
}
Console.Write(FindMaxConsecutiveOnes(nums));
Console.WriteLine("\n");



//Student Attendance Record
string s = "PPALLL";

bool CheckRecord(string s)
{
    bool CheckA(string s)
    {
        int suma = 0;
        foreach (var ch in s)
        {
            if (ch == 'A')
            {
                suma++;

            }
        }
        if (suma >= 2)
            return false;
        else
            return true;

    }
    bool CheckL(string s)
    {

        int suml = 0;
        foreach (var ch in s)
        {
            if (ch == 'L')
            {
                suml++;

            }
        }
        if (suml >= 3)
            return false;
        else
            return true;
    }

    if (CheckA(s) == false || CheckL(s) == false)
        return false;
    else
        return true;
}
Console.Write(CheckRecord(s));
Console.WriteLine("\n");


//Letter Frequency

string ssamvel = File.ReadAllText(@"C:\Users\SU-PC\Desktop\Mary C#\Lesson 5 hw\samvel.txt", Encoding.UTF8);
ssamvel = ssamvel.ToLower();
 var samvel = ssamvel.Split("");


char[] ayb = new[] { 'ա', 'բ', 'գ', 'դ', 'ե', 'զ', 'է', 'ը', 'թ', 'ժ', 'ի', 'լ', 'խ', 'ծ', 'կ', 'հ', 'ձ', 'ղ', 'ճ', 'մ', 'յ', 'ն', 'շ', 'ո', 'չ', 'պ', 'ջ', 'ռ', 'ս', 'վ', 'տ', 'ր', 'ց', 'ւ', 'փ', 'ք', 'և', 'օ', 'ֆ' };
int[] tver = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    for (int j = 0; j<samvel.Length; j++)
    {
        for (int i = 0; i < ayb.Length; i++)
        { 
            if (samvel[j] == ayb[i])
            {
               tver[i]++; 
            
            }

    }  
    }

    


Console.OutputEncoding = System.Text.Encoding.UTF8;
for (int k = 0; k < ayb.Length; k++)
{
    Console.WriteLine(ayb[k] + ": " + tver[k] );
}

Console.Write("\n"); 

