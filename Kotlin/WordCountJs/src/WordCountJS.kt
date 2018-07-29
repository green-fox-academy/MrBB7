import org.w3c.dom.HTMLInputElement
import kotlin.browser.document

fun main(args: Array<String>) {
    println("Hello world")

    val button = document.getElementById("button")!!
    button.addEventListener("click", {
       val theText = (document.getElementById("wordText")!! as HTMLInputElement).value
        println(theText)
    })
}