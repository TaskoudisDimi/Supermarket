#


path="/mnt/c/Users/chris/Desktop/Dimitris/Logs"
#day = $(date +%d)

if [ -e "$path" ]; then
	echo "Path exists"
else
	echo "Path does not exist"
fi


find "$path" -name "*.txt" -type f -delete
echo "All files deleted"








#if [ $day -ep 01 ]; then
#	find $path -name "*txt" -type f -delete
#	echo "The files deleted"
#else
#	echo "The files does not deleted"
#fi

