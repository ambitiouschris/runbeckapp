{\rtf1\ansi\ansicpg1252\cocoartf1671\cocoasubrtf600
{\fonttbl\f0\froman\fcharset0 Times-Roman;\f1\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;\red0\green0\blue255;\red255\green255\blue255;\red0\green0\blue0;
\red37\green127\blue159;\red144\green1\blue18;\red107\green0\blue1;}
{\*\expandedcolortbl;;\cssrgb\c0\c0\c100000;\cssrgb\c100000\c100000\c100000;\cssrgb\c0\c0\c0;
\cssrgb\c16863\c56863\c68627;\cssrgb\c63922\c8235\c8235;\cssrgb\c50196\c0\c0;}
\paperw8400\paperh11900\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\partightenfactor0

\f0\fs25\fsmilli12667 \cf2 \expnd0\expndtw0\kerning0
using\cf3  System;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \cf2 using\cf3  System.Collections.Generic;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \cf2 using\cf3  System.IO;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \cf2 namespace\cf3  RunBeckApp
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0 \cf2 public\cf3  \cf2 class\cf3  \cf5 dataObject
\f1\fs29\fsmilli14667 \cf3 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  \cf2 string\cf3  fileName \{ \cf2 get\cf3 ; \cf2 set\cf3 ; \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  \cf2 string\cf3  filePath \{ \cf2 get\cf3 ; \cf2 set\cf3 ; \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  List<\cf2 string\cf3 > goodLines \{ \cf2 get\cf3 ; \cf2 set\cf3 ; \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  List<\cf2 string\cf3 > badLines \{ \cf2 get\cf3 ; \cf2 set\cf3 ; \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  \cf2 int\cf3  numFields \{ \cf2 get\cf3 ;\cf2 set\cf3 ;\}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  \cf2 string\cf3  fileType \{ \cf2 get\cf3 ; \cf2 set\cf3 ; \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 public\cf3  \cf5 dataObject\cf3 ()
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 fileName = \cf6 ""\cf3 ;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 goodLines = \cf2 new\cf3  List<\cf2 string\cf3 >();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 badLines = \cf2 new\cf3  List<\cf2 string\cf3 >();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 numFields = 0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 fileType = \cf6 "C"\cf3 ;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0 \cf2 class\cf3  \cf5 Program
\f1\fs29\fsmilli14667 \cf3 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0 \{\'a0\'a0\'a0\'a0\'a0\'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf2 static\cf3  \cf2 void\cf3  Main(\cf2 string\cf3 [] args)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 dataObject obj = \cf2 new\cf3  dataObject();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 int\cf3  retCode = 0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 while\cf3  (retCode == 0)\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.Write(\cf6 "Please enter the file name/location to process or (Q) to Quit? "\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 string\cf3  filePath = Console.ReadLine();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 retCode = isValidInputFile(filePath);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (retCode == 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.WriteLine(\cf6 "Invalid file"\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \} \cf2 else\cf3  \cf2 if\cf3  (retCode == -1)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 break\cf3 ;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \} \cf2 else
\f1\fs29\fsmilli14667 \cf3 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 obj.fileName = Path.GetFileName(filePath);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 obj.filePath = Path.GetDirectoryName(filePath);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (retCode > 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 retCode = 0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 while\cf3  (retCode == 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.Write(\cf6 "Is this a (T)ab Delimited or (C)omma Delimited file? "\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 obj.fileType = Console.ReadLine();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  ((obj.fileType.ToUpper().Equals(\cf6 "T"\cf3 )) || (obj.fileType.ToUpper().Equals(\cf6 "C"\cf3 )))
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 retCode = 1;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 else
\f1\fs29\fsmilli14667 \cf3 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.WriteLine(\cf6 "Incorrect type picked"\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (retCode > 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 retCode = 0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 while\cf3  (retCode == 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.Write(\cf6 "How fields are in this file? "\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 string\cf3  numFields = Console.ReadLine();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 int\cf3  iNumFields;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (!\cf2 int\cf3 .TryParse(numFields, \cf2 out\cf3  iNumFields))
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.WriteLine(\cf6 "Incorrect type picked"\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 else\cf3  \cf2 if\cf3  (iNumFields <=0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.WriteLine(\cf6 "Must have at least one field"\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\} \cf2 else
\f1\fs29\fsmilli14667 \cf3 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 obj.numFields = iNumFields;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 retCode = 1;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (retCode > 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 processInputFile(obj);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 outputSuccessResults(obj);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 outputFailureResults(obj);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 static\cf3  \cf2 int\cf3  isValidInputFile(\cf2 string\cf3  filePath)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (String.IsNullOrEmpty(filePath)) \cf2 return\cf3  0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0 \'a0\'a0\'a0\'a0\'a0\'a0\cf2 if\cf3  (filePath.ToUpper().Equals(\cf6 "Q"\cf3 )) \cf2 return\cf3  -1;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (!File.Exists(filePath)) \cf2 return\cf3  0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 return\cf3  1;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 static\cf3  \cf2 void\cf3  processInputFile(dataObject obj)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 string\cf3  seperator = \cf6 ","\cf3 ;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (obj.fileType.ToUpper().Equals(\cf6 "T"\cf3 ))
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 seperator = \cf6 "\\t"\cf3 ;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 int\cf3  iRows = 0;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 IEnumerable<String> lines = File.ReadLines(obj.filePath + \cf7 @"\\\\"\cf3  + obj.fileName);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf2 foreach\cf3  (\cf2 string\cf3  line \cf2 in\cf3  lines)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 iRows++;
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 Console.WriteLine(\cf6 $"Processing Row #\cf3 \{iRows\}\cf6 "\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (iRows > 1)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 string\cf3 [] cols = line.Split(seperator);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (cols.Length != obj.numFields)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 obj.badLines.Add(line);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 else
\f1\fs29\fsmilli14667 \cf3 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 obj.goodLines.Add(line);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 static\cf3  \cf2 void\cf3  outputSuccessResults(dataObject obj)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (obj.goodLines.Count > 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 StreamWriter sw = \cf2 new\cf3  StreamWriter(\cf6 $"\cf3 \{obj.filePath\}\cf6 \\\\successes_\cf3 \{obj.fileName\}\cf6 "\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 foreach\cf3  (var line \cf2 in\cf3  obj.goodLines)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 sw.WriteLine(line);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 sw.Dispose();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0 \'a0\'a0\}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 static\cf3  \cf2 void\cf3  outputFailureResults(dataObject obj)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 if\cf3  (obj.badLines.Count > 0)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 StreamWriter sw = \cf2 new\cf3  StreamWriter(\cf6 $"\cf3 \{obj.filePath\}\cf6 \\\\failures_\cf3 \{obj.fileName\}\cf6 "\cf3 );
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf2 foreach\cf3  (var line \cf2 in\cf3  obj.badLines)
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \{
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 sw.WriteLine(line);
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 sw.Dispose();
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \'a0\'a0\'a0 \}
\f1\fs29\fsmilli14667 \

\f0\fs25\fsmilli12667 \}}