import java.io.File
import java.io.InputStream

fun main(args: Array<String>) {

    val inputStream: InputStream = File("text.txt").inputStream()

    val allTheWords= inputStream.bufferedReader().use { it.readText() }

    val words = allTheWords.replace("\n", " ").replace(",", "").replace(".", "").split(" ")

    val wordMap = mutableMapOf<String, Int>()
    for (word in words) {
        if (word != ""){

                if (wordMap[word.capitalize()] == null) {
                    wordMap[word.capitalize()] = 1
                } else {
                    val wordCount = wordMap[word.capitalize()]!!
                    wordMap[word.capitalize()] = wordCount + 1
                }
            }
        }

    val wordList = wordMap.toList()

    val sortedList = wordList.sortedWith(compareByDescending({it.second}))

    for (word in sortedList) {
        println(word)
    }

    for (word in sortedList) {
        println("${word.first} - ${word.second}")
    }
}