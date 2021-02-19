###Begin Try Command to suppress all messages
try({

###Pre-Script Calls###
args <- commandArgs(TRUE)
suppressMessages(require(tools))

###Read Data In and Tweak###
data.in <- suppressWarnings(read.csv(args[1]))
data.in[,1] <- as.character(data.in[,1])
data.in[,3] <- as.Date(data.in[,3], format="%A, %B %d, %Y")

###Keep Only the First 70 or Better###
data.subset <- subset(data.in, data.in$Attempt.grade>69)
data.subset <- data.subset[match(unique(data.subset[,1]), data.subset[,1]),]

###Split First Column Based on Space###
name.split <- strsplit(data.subset[,1]," ")

###For Loop Based on Split Names###
first.name <- vector()
last.name <- vector()

for (i in name.split) {
    first.name <- append(i[[1]], first.name)
    last.name <- append(i[[2]], last.name)
}


###Append New Columns Reversed###
data.subset$First.Name <- rev(first.name)
data.subset$Last.Name <- rev(last.name)

###Remove User Column and Reorganize data.subset###
data.out <- data.subset[,-1]
data.out <- data.out[,c(5,6,1,2,3,4)]
data.out <- data.out[order(data.out[,2]),]

###Write data.out to File###
out.name <- paste(file_path_sans_ext(basename(args[1])),"updated.csv",sep="_")
write.csv(data.out, file.path(args[2],out.name), row.names=FALSE)


###End Try Command
}, silent=TRUE)

###Check to see if an error happened, if so, print the input file name###
if (exists('data.out') == FALSE) {
    cat(paste(basename(args[1]), "\n", sep=""))
}
