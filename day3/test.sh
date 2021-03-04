#!/bin/bash

slope(){
  file=$1
  right=$2
  down=$3
  trees=0
  lines=1
  item=1
  while read line
  do
    if [ $(( $lines % $down )) -eq 0 ] && [ $down -eq 2 ]
    then
      echo "${line} | $lines | $trees" 1>&2
      lines=$(( $lines + 1 ))
      continue
    fi
  	if [ $item -ge 32 ]
  	then
  		item=$(( $item - 31 ))
  	fi
  	if [ $( echo $line | cut -c$item) == '#' ]
  	then
  		trees=$(( $trees + 1))
  	fi
  
    echo -e "${line:0:item -1}\e[41m${line:item -1:1}\e[49m${line:item} | $lines | $trees" 1>&2
    item=$(( $item + $right ))
  	lines=$(( $lines + 1 ))
  done < $file
  
  echo "Trees: $trees, $lines lines" 1>&2
  echo $trees
}

one=$(slope $1 1 1)
three=$(slope $1 3 1)
five=$(slope $1 5 1)
seven=$(slope $1 7 1)
two=$(slope $1 1 2)
