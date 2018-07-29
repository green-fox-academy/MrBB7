import org.w3c.dom.HTMLInputElement
import kotlin.browser.document

fun main(args: Array<String>) {
    println("Hello world")

    val button = document.getElementById("button")!!
    button.addEventListener("click", {
       val allTheWords = (document.getElementById("wordText")!! as HTMLInputElement).value

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

        var listItems = ""
        for (word in sortedList) {
            listItems += "<li>${word.first} - ${word.second}</li>"
        }

        document.getElementById("List")!!.innerHTML = listItems
    })
}