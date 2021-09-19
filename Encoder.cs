using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIEncoder
{
    public static class Encoder
    {
        public static string Decode(int value)
        {
            string Character = null;

            switch(value)
            {
                case 32:
                    Character = "SP";
                    break;
                case 33:
                    Character = "!";
                    break;
                case 34:
                    Character = "'";
                    break;
                case 35:
                    Character = "#";
                    break;
                case 36:
                    Character = "$";
                    break;
                case 37:
                    Character = "%";
                    break;
                case 38:
                    Character = "&";
                    break;
                case 39:
                    Character = "";
                    break;
                case 40:
                    Character = "(";
                    break;
                case 41:
                    Character = ")";
                    break;
                case 42:
                    Character = "*";
                    break;
                case 43:
                    Character = "+";
                    break;
                case 44:
                    Character = ",";
                    break;
                case 45:
                    Character = "-";
                    break;
                case 46:
                    Character = ".";
                    break;
                case 47:
                    Character = "/";
                    break;
                case 48:
                    Character = "0";
                    break;
                case 49:
                    Character = "1";
                    break;
                case 50:
                    Character = "2";
                    break;
                case 51:
                    Character = "3";
                    break;
                case 52:
                    Character = "4";
                    break;
                case 53:
                    Character = "5";
                    break;
                case 54:
                    Character = "6";
                    break;
                case 55:
                    Character = "7";
                    break;
                case 56:
                    Character = "8";
                    break;
                case 57:
                    Character = "9";
                    break;
                case 58:
                    Character = ":";
                    break;
                case 59:
                    Character = ";";
                    break;
                case 60:
                    Character = "<";
                    break;
                case 61:
                    Character = "=";
                    break;
                case 62:
                    Character = ">";
                    break;
                case 63:
                    Character = "?";
                    break;
                case 64:
                    Character = "@";
                    break;
                case 65:
                    Character = "A";
                    break;
                case 66:
                    Character = "B";
                    break;
                case 67:
                    Character = "C";
                    break;
                case 68:
                    Character = "D";
                    break;
                case 69:
                    Character = "E";
                    break;
                case 70:
                    Character = "F";
                    break;
                case 71:
                    Character = "G";
                    break;
                case 72:
                    Character = "H";
                    break;
                case 73:
                    Character = "I";
                    break;
                case 74:
                    Character = "J";
                    break;
                case 75:
                    Character = "K";
                    break;
                case 76:
                    Character = "L";
                    break;
                case 77:
                    Character = "M";
                    break;
                case 78:
                    Character = "N";
                    break;
                case 79:
                    Character = "O";
                    break;
                case 80:
                    Character = "P";
                    break;
                case 81:
                    Character = "Q";
                    break;
                case 82:
                    Character = "R";
                    break;
                case 83:
                    Character = "S";
                    break;
                case 84:
                    Character = "T";
                    break;
                case 85:
                    Character = "U";
                    break;
                case 86:
                    Character = "V";
                    break;
                case 87:
                    Character = "W";
                    break;
                case 88:
                    Character = "X";
                    break;
                case 89:
                    Character = "Y";
                    break;
                case 90:
                    Character = "Z";
                    break;
                case 91:
                    Character = "[";
                    break;
                case 92:
                    Character = "";
                    break;
                case 93:
                    Character = "]";
                    break;
                case 94:
                    Character = "^";
                    break;
                case 95:
                    Character = "_";
                    break;
                case 96:
                    Character = "`";
                    break;
                case 97:
                    Character = "a";
                    break;
                case 98:
                    Character = "b";
                    break;
                case 99:
                    Character = "c";
                    break;
                case 100:
                    Character = "d";
                    break;
                case 101:
                    Character = "e";
                    break;
                case 102:
                    Character = "f";
                    break;
                case 103:
                    Character = "g";
                    break;
                case 104:
                    Character = "h";
                    break;
                case 105:
                    Character = "i";
                    break;
                case 106:
                    Character = "j";
                    break;
                case 107:
                    Character = "k";
                    break;
                case 108:
                    Character = "l";
                    break;
                case 109:
                    Character = "m";
                    break;
                case 110:
                    Character = "n";
                    break;
                case 111:
                    Character = "o";
                    break;
                case 112:
                    Character = "p";
                    break;
                case 113:
                    Character = "q";
                    break;
                case 114:
                    Character = "r";
                    break;
                case 115:
                    Character = "s";
                    break;
                case 116:
                    Character = "t";
                    break;
                case 117:
                    Character = "u";
                    break;
                case 118:
                    Character = "v";
                    break;
                case 119:
                    Character = "w";
                    break;
                case 120:
                    Character = "x";
                    break;
                case 121:
                    Character = "y";
                    break;
                case 122:
                    Character = "z";
                    break;
                case 123:
                    Character = "{";
                    break;
                case 124:
                    Character = "|";
                    break;
                case 125:
                    Character = "}";
                    break;
                case 126:
                    Character = "~";
                    break;
                case 127:
                    Character = "DEL";
                    break;
                default:
                    Character = "SP";
                    break;
            }

            return Character;
        }

        public static int Encode(string Character)
        {
            int value = 32;

            switch (Character)
            {
                case "SP":
                    value = 32;
                    break;
                case "!":
                    value = 33;
                    break;
              //case """:
              //    value = 34;
              //    break;
                case "#":
                    value = 35;
                    break;
                case "$":
                    value = 36;
                    break;
                case "%":
                    value = 37;
                    break;
                case "&":
                    value = 38;
                    break;
                case "'":
                    value = 39;
                    break;
                case "(":
                    value = 40;
                    break;
                case ")":
                    value = 41;
                    break;
                case "*":
                    value = 42;
                    break;
                case "+":
                    value = 43;
                    break;
                case ",":
                    value = 44;
                    break;
                case "-":
                    value = 45;
                    break;
                case ".":
                    value = 46;
                    break;
                case "/":
                    value = 47;
                    break;
                case "0":
                    value = 48;
                    break;
                case "1":
                    value = 49;
                    break;
                case "2":
                    value = 50;
                    break;
                case "3":
                    value = 51;
                    break;
                case "4":
                    value = 52;
                    break;
                case "5":
                    value = 53;
                    break;
                case "6":
                    value = 54;
                    break;
                case "7":
                    value = 55;
                    break;
                case "8":
                    value = 56;
                    break;
                case "9":
                    value = 57;
                    break;
                case ":":
                    value = 58;
                    break;
                case ";":
                    value = 59;
                    break;
                case "<":
                    value = 60;
                    break;
                case "=":
                    value = 61;
                    break;
                case ">":
                    value = 62;
                    break;
                case "?":
                    value = 63;
                    break;
                case "@":
                    value = 64;
                    break;
                case "A":
                    value = 65;
                    break;
                case "B":
                    value = 66;
                    break;
                case "C":
                    value = 67;
                    break;
                case "D":
                    value = 68;
                    break;
                case "E":
                    value = 69;
                    break;
                case "F":
                    value = 70;
                    break;
                case "G":
                    value = 71;
                    break;
                case "H":
                    value = 72;
                    break;
                case "I":
                    value = 73;
                    break;
                case "J":
                    value = 74;
                    break;
                case "K":
                    value = 75;
                    break;
                case "L":
                    value = 76;
                    break;
                case "M":
                    value = 77;
                    break;
                case "N":
                    value = 78;
                    break;
                case "O":
                    value = 79;
                    break;
                case "P":
                    value = 80;
                    break;
                case "Q":
                    value = 81;
                    break;
                case "R":
                    value = 82;
                    break;
                case "S":
                    value = 83;
                    break;
                case "T":
                    value = 84;
                    break;
                case "U":
                    value = 85;
                    break;
                case "V":
                    value = 86;
                    break;
                case "W":
                    value = 87;
                    break;
                case "X":
                    value = 88;
                    break;
                case "Y":
                    value = 89;
                    break;
                case "Z":
                    value = 90;
                    break;
                case "[":
                    value = 91;
                    break;
              // case "/":
              //     value = 92;
              //     break;
                case "]":
                    value = 93;
                    break;
                case "^":
                    value = 94;
                    break;
                case "_":
                    value = 95;
                    break;
                case "`":
                    value = 96;
                    break;
                case "a":
                    value = 97;
                    break;
                case "b":
                    value = 98;
                    break;
                case "c":
                    value = 99;
                    break;
                case "d":
                    value = 100;
                    break;
                case "e":
                    value = 101;
                    break;
                case "f":
                    value = 102;
                    break;
                case "g":
                    value = 103;
                    break;
                case "h":
                    value = 104;
                    break;
                case "i":
                    value = 105;
                    break;
                case "j":
                    value = 106;
                    break;
                case "k":
                    value = 107;
                    break;
                case "l":
                    value = 108;
                    break;
                case "m":
                    value = 109;
                    break;
                case "n":
                    value = 110;
                    break;
                case "o":
                    value = 111;
                    break;
                case "p":
                    value = 112;
                    break;
                case "q":
                    value = 113;
                    break;
                case "r":
                    value = 114;
                    break;
                case "s":
                    value = 115;
                    break;
                case "t":
                    value = 116;
                    break;
                case "u":
                    value = 117;
                    break;
                case "v":
                    value = 118;
                    break;
                case "w":
                    value = 119;
                    break;
                case "x":
                    value = 120;
                    break;
                case "y":
                    value = 121;
                    break;
                case "z":
                    value = 122;
                    break;
                case "{":
                    value = 123;
                    break;
                case "|":
                    value = 124;
                    break;
                case "}":
                    value = 125;
                    break;
                case "~":
                    value = 126;
                    break;
                case "DEL":
                    value = 127;
                    break;
                default:
                    value = 32;
                    break;
            }

            return value;
        }
    }
}
