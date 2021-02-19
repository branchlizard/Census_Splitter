###Preamble###
args <- commandArgs(TRUE)

###Read in failed log###
log.in <- read.table(args[1], sep="\n")

###Remove duplicates from failed log###
log.unique <- unique(log.in)

###Write to file###
write.table(x=log.unique, file=paste(args[1]), sep="", eol="\n", row.names=FALSE, col.names=FALSE, quote=FALSE)
