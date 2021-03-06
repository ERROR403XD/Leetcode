﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Minimum_Window_Substring
    {
        public string MinWindow(string s,string t)
        {
            int[] tHash = new int[255];
            foreach(char c in t)
            {
                tHash[c]++;
            }
            int start = 0, i = 0;
            int[] sHash = new int[255];
            int found = 0;
            int begin = -1,  minlength = s.Length;
            for(i=0;i<s.Length;i++)
            {
                sHash[s[i]]++;
                if (sHash[s[i]] <= tHash[s[i]]) found++;

                if(found==t.Length)
                {
                    while(start<i && sHash[s[start]]>tHash[s[start]])
                    {
                        sHash[s[start]]--;
                        start++;
                    }
                    if(i-start<minlength)
                    {
                        minlength = i - start;
                        begin = start;
                    }

                    sHash[s[start]]--;
                    found--;
                    start++;
                }
            }
            return (begin == -1) ? "" : s.Substring(begin, minlength+1);
        }
        /*
        public string MinWindow(string S, string T)
        {
            int[] srcHash = new int[255];
            // 记录目标字符串每个字母出现次数
            for (int j = 0; j < T.Length; j++)
            {
                srcHash[T[j]]++;
            }
            int start = 0, i = 0;
            // 用于记录窗口内每个字母出现次数 
            int[] destHash = new int[255];
            int found = 0;
            int begin = -1, end = S.Length, minLength = S.Length;
            for (start = i = 0; i < S.Length; i++)
            {
                // 每来一个字符给它的出现次数加1
                destHash[S[i]]++;
                // 如果加1后这个字符的数量不超过目标串中该字符的数量，则找到了一个匹配字符
                if (destHash[S[i]] <= srcHash[S[i]]) found++;
                // 如果找到的匹配字符数等于目标串长度，说明找到了一个符合要求的子串    
                if (found == T.Length)
                {
                    // 将开头没用的都跳过，没用是指该字符出现次数超过了目标串中出现的次数，并把它们出现次数都减1
                    while (start < i && destHash[S[start]] > srcHash[S[start]])
                    {
                        destHash[S[start]]--;
                        start++;
                    }
                    // 这时候start指向该子串开头的字母，判断该子串长度
                    if (i - start < minLength)
                    {
                        minLength = i - start;
                        begin = start;
                        end = i;
                    }
                    // 把开头的这个匹配字符跳过，并将匹配字符数减1
                    destHash[S[start]]--;
                    found--;
                    // 子串起始位置加1，我们开始看下一个子串了
                    start++;
                }
            }
            // 如果begin没有修改过，返回空
            return begin == -1 ? "" : S.Substring(begin, end - begin + 1);
        }*/
    }
}
