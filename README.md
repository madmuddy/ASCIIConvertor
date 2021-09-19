# ASCIIEncoder
 Convert Decimal ASCII value to their Character value
 
 # USAGE:
   =>You can use the static method in dll to convert ASCII value to to its character value as:
   
   Using the Dll name-space.
  `
   using ASCIIEncoder;
  `
   Using the Convert Function.
   
   //Calling the Convert Function form the Dll's Encode Class.
   `
   string char_value = Encode.Convert(77);
   `
   
   # Example:
     You give the value of 77, it return its Charcter value "M".
    ` 
    string char_value = null;
    // Calling the Convert Method form Dll
    char_value = Encode.Convert(77);
    
    Console.WriteLine(char_value);
    
    // Output will be M.
    `
