// Source : https://leetcode.com/problems/simplify-path/ 
// Author : codeyu 
// Date : Sunday, January 15, 2017 11:17:54 PM 

/**********************************************************************************
*
* Given an absolute path for a file (Unix-style), simplify it.
* 
* For example,
* path = "/home/", => "/home"
* path = "/a/./b/../../c/", => "/c"
* 
* 
* click to show corner cases.
* 
* Corner Cases:
* 
* 
* 
* Did you consider the case where path = "/../"?
* In this case, you should return "/".
* Another corner case is the path might contain multiple slashes '/' together, such as "/home//foo/".
* In this case, you should ignore redundant slashes and return "/home/foo".
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution071 
    {
        public static string SimplifyPath(string path) 
        {
            if(path == null || path.Length==0)  
            {  
                return "";  
            }  
            Stack<String> stack = new Stack<String>();  
            StringBuilder res = new StringBuilder();  
            int i=0;  
            
            while(i<path.Length)  
            {  
                int index = i;  
                StringBuilder temp = new StringBuilder();  
                while(i<path.Length && path[i]!='/')  
                {  
                    temp.Append(path[i]);  
                    i++;  
                }  
                if(index!=i)  
                {  
                    String str = temp.ToString();  
                    if(str.Equals(".."))  
                    {  
                        if(stack.Count > 0)  
                            stack.Pop();  
                    }  
                    else if(!str.Equals("."))  
                    {  
                        stack.Push(str);  
                    }  
                }  
                i++;  
            }  
            if(stack.Count > 0)  
            {  
                String[] strs = stack.ToArray();  
                for(int j=strs.Length-1;j>=0;j--)  
                {  
                    res.Append("/"+strs[j]);  
                }  
            }  
            if(res.Length==0) { return "/"; } 
            return res.ToString(); 
        }
    }
}

