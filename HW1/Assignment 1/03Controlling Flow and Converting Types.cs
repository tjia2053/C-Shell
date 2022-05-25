/*
    1.What happens when you divide an int variable by 0?
    Answer: I will got error from compiler. The error message is CS0020.
    2.What happens when you divide an int variable by 0?
    Answer: I will return the symbol which is infinity.
    3.What happens when you overflow an int variable, that is, set it to a value beyond its
    range?
    Answer: It depend on that how do you use. It will show error if you assign the integer to a variable and overflow it range.
    It will be implicitly type conversion if it is type of range is samller than int.
    If it is int type, it will be remainder of the result which the result divide by range if you do numerical operations
    for example, int a = int.MaxValue; Console.WriteLine(a+1); the result will be int.MinValue.
    4.What is the difference between x = y++; and x = ++y;?
    Answer: for y++, the system will need to create a temp variable for return, So it will use more memory. but ++y will not.
    in the assembly language, y++ will do that is like "type temp = y; y = y+1; return temp;" , and ++y will do that is like "y = y + 1 return y". here y is not really value.
    It takes value y from the address of register of y to do operater and the push back the register. Then return the address of register of y.
    So, y++ need more resource than ++y.
    5. What is the difference between break, continue, and return when used inside a loop
    statement?
    Answer: The break will break whole loop after the condition meets the break.
    The continue will ship the code in this time loop after the condition meets the coninue.
    The return will return the result and end the method.
    for example:
    public int demo
    {
        some code...
        while()               <--
        {                       |            
            return              |                                 ---
            some code...        |                                   |
                if ()           |                                   |
                {               |                                   |
                    break;      | continue go  --                   |
                }               |               |                   |
            some code...        |               |                   |
                if ()           |               |                   |   return go
                {               |               |                   |
                    continue;  --               |  break go         |
                }                               |                   |
            some coed....                       |                   |
        }                                       |                   |
     some code....                          <----                   |
    }                                                            <---
    6.What are the three parts of a for statement and which of them are required?
    Answer: They are initial value, condtion, next step.
    7.What is the difference between the = and == operators?
    AnswerL the = is assignment operators. The == is a equal operators.
    8.Does the following statement compile? for ( ; true; ) ;
    Answer: Yes, it will be infinite loop.
    9.What does the underscore _ represent in a switch expression?
    It is the default case. It is all-match case.
    10. What interface must an object implement to be enumerated over by using the foreach
    statement?
    Answer: IEnumerable and IEnumerator.
 */
